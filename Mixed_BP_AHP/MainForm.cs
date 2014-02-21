using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BPNet;
using Algorithm_AHP;
using Microsoft.Office.Core;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;
using XMLConfiguration;
using BPAHP;

namespace Mixed_BP_AHP
{
    public partial class MainForm : Form
    {
        private AHPSolution config = null;
        private MultiLayersAHP mahp = null;
        private BPAdjustedAHP bpahp = null;
        private DataSet matrixAHP = null;
        //private DataSet matrixBPAHP = null;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void Menu_OpenJudgmentFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            //获得AHP工程文件路径
            openFile.Title = "选择AHP工程文件...";
            openFile.Filter = "AHP工程文件(*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult result = openFile.ShowDialog();

            if (DialogResult.OK == result)
            {
                string file_input = openFile.FileName;
                //读取工程文件获得数据文件路径
                this.config = new AHPSolution(file_input);
                DisplaySolutionInfo(file_input, config);    //显示Solution信息到界面上
                string file_data = config.GetDataFilePath();

                ExcelDocument excelFile = new ExcelDocument();
                this.matrixAHP = excelFile.Parse(file_data);

                AHP_tabControl.TabPages.Clear();

                foreach (DataTable table in this.matrixAHP.Tables)
                {
                    TabPage page = new TabPage(table.TableName.TrimEnd('$'));

                    DataGridView dgv = new DataGridView();
                    dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
                    dgv.ReadOnly = true;

                    dgv.DataSource = table;

                    page.Controls.Add(dgv);

                    dgv.Dock = DockStyle.Fill;

                    AHP_tabControl.TabPages.Add(page);
                }
             
            }

        }

        private void AHP_test_Click(object sender, EventArgs e)
        {
            try
            {
                this.mahp = new MultiLayersAHP(config, this.matrixAHP);
                mahp.CalculatePriorities();
                mahp.CalculateTargetPriorities();

                Dictionary<string, double> dict = mahp.GetTargetPriorities();
                this.AddNewSeriesToChart(chart1, "AHP决策", dict);
                View_tabControl.SelectedTab = ResultView_Page;
            }
            catch (NullJudgmentMatrixException ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void BP_AHP_Decision()
        //{
        //    Dictionary<string,double> dict = SetJudgmentMatrixFromDataSet(ahp.GetAdjustedMatrix());

        //    this.AddNewSeriesToChart(chart1,"BP-AHP决策",dict);
        //    View_tabControl.SelectedTab = ResultView_Page;
        //}

        //private void AdjustConsistencyAndDisplay()
        //{
        //    BPAHP_tabControl.TabPages.Clear();

        //    DataSet bpMatrix = bpahp.GetAdjustedMatrix();
        //    int i = 0;

        //    foreach (TabPage page in AHP_tabControl.TabPages)
        //    {
        //        TabPage newpage = new TabPage(page.Text);

        //        DataGridView dgv = new DataGridView();
        //        dgv.ReadOnly = true;
        //        dgv.DataSource = bpMatrix.Tables[i++];

        //        newpage.Controls.Add(dgv);

        //        dgv.Dock = DockStyle.Fill;

        //        BPAHP_tabControl.TabPages.Add(newpage);
        //    }
        //}

        private void BP_AHP_Test_Click(object sender, EventArgs e)
        {
            try
            {
                this.bpahp = new BPAdjustedAHP(config, this.matrixAHP);
                bpahp.CalculatePriorities();
                bpahp.CalculateTargetPriorities();

                Dictionary<string, double> dict = bpahp.GetTargetPriorities();
                this.AddNewSeriesToChart(chart1, "BP-AHP决策", dict);
                View_tabControl.SelectedTab = ResultView_Page;
            }
            catch (NullJudgmentMatrixException ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewSeriesToChart(Chart chartInstance, string seriesName, Dictionary<string, double> pointCollection)
        {
            Series curSeries = null;
            try
            {
                curSeries = chartInstance.Series.Add(seriesName);
            }
            catch (ArgumentException)
            {

                curSeries = chartInstance.Series[seriesName];
                curSeries.Points.Clear();
            }


            curSeries.IsValueShownAsLabel = true;
            curSeries.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            curSeries.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            foreach (string key in pointCollection.Keys)
            {
                curSeries.Points.AddXY(key, pointCollection[key]);
            }
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Option_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SetupWindow().ShowDialog();
        }

        /// <summary>
        /// 将SolutionFile中的AHP工程信息显示在界面上
        /// </summary>
        /// <param name="SolutionFile"></param>
        /// <param name="config"></param>
        private void DisplaySolutionInfo(string SolutionFile, AHPSolution config)
        {
            SolutionInfo_SolutionName.Text = SolutionFile;
            SolutionInfo_DataFilePath.Text = config.GetDataFilePath();
            SolutionInfo_BeginColumn.Text = config.GetBeginColumn().ToString();
            SolutionInfo_TotalLayers.Text = config.GetTotalLayers().ToString();
            SolutionInfo_CRLimit.Text = config.GetCRLimit().ToString();
            SolutionInfo_TargetName.Text = config.GetTargetName();
            SolutionInfo_PlanNames.Text = config.GetPlanNames();
        }

    }       
}
