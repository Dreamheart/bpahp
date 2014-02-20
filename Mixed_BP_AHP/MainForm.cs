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

namespace Mixed_BP_AHP
{
    public partial class MainForm : Form
    {
        private BasicAHP ahp = null;
        private DataSet matrixAHP = null;
        private DataSet matrixBPAHP = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AHP_test_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string,double> dict = SetJudgmentMatrixFromDataSet(this.matrixAHP);
                this.AddNewSeriesToChart(chart1, "AHP决策", dict);
                View_tabControl.SelectedTab = ResultView_Page;
            }
            catch (NullJudgmentMatrixException ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<string,double> SetJudgmentMatrixFromDataSet(DataSet dsMatrix)
        {
            string[] stringParam = XMLConfigurationTool.GetConfigItem("Debug_Structure", "1,3,2").Split(',');
            int[] intParam = Array.ConvertAll<string, int>(stringParam, delegate(string s) { return int.Parse(s); });

            this.ahp = new BasicAHP(intParam);

            this.ahp.SetJudgmentMatrix(dsMatrix);

            double[] result = ahp.Assessment();

            Dictionary<string, double> dict = new Dictionary<string, double>();

            for (int i = 0; i < result.Length; i++)
            {
                dict.Add(string.Format("方案{0}", i+1), result[i]);
            }

            return dict;
        }



        private void Menu_OpenJudgmentFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            //获得训练数据输入数据文件名
            openFile.Title = "Select JudgmentMatrix File ...";
            openFile.Filter = "Excel files (*.xlsx)|*.xlsx|Excel files (*.xls)|*.xls|All files (*.*)|*.*";
            DialogResult result = openFile.ShowDialog();
            string file_input = openFile.FileName;
            
            if (DialogResult.OK == result)
            {
                ExcelDocument excelFile = new ExcelDocument();

                this.matrixAHP = excelFile.Parse(file_input);

                AHP_tabControl.TabPages.Clear();

                foreach (DataTable table in this.matrixAHP.Tables)
                {
                    TabPage page = new TabPage(table.TableName.TrimEnd('$'));

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = table;

                    page.Controls.Add(dgv);

                    dgv.Dock = DockStyle.Fill;

                    AHP_tabControl.TabPages.Add(page);
                }
            }
        }

        private void BP_AHP_Decision()
        {
            Dictionary<string,double> dict = SetJudgmentMatrixFromDataSet(ahp.GetAdjustedMatrix());

            this.AddNewSeriesToChart(chart1,"BP-AHP决策",dict);
            View_tabControl.SelectedTab = ResultView_Page;
        }

        private void AdjustConsistencyAndDisplay()
        {
            BPAHP_tabControl.TabPages.Clear();

            ahp.AdjustConsistency();
            DataSet bpMatrix = ahp.GetAdjustedMatrix();
            int i = 0;

            foreach (TabPage page in AHP_tabControl.TabPages)
            {
                TabPage newpage = new TabPage(page.Text);

                DataGridView dgv = new DataGridView();
                dgv.ReadOnly = true;
                dgv.DataSource = bpMatrix.Tables[i++];

                newpage.Controls.Add(dgv);

                dgv.Dock = DockStyle.Fill;

                BPAHP_tabControl.TabPages.Add(newpage);
            }
        }

        private void BP_AHP_Test_Click(object sender, EventArgs e)
        {
            if (null == this.ahp)
            {
                MessageBox.Show("请先加载数据并进行AHP决策", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AdjustConsistencyAndDisplay();
                BP_AHP_Decision();
                
            }

        }

        private void CreateBarChart(Chart chartInstance, string[] seriesNames, Dictionary<string, double>[] seriesCollection)
        {
            chartInstance.Series.Clear();
            for (int i = 0; i < seriesNames.Length; i++)
            {
                if (null == seriesNames[i])
                {
                    continue;
                }
                Series curSeries = chartInstance.Series.Add(seriesNames[i]);
                curSeries.IsValueShownAsLabel = true;
                curSeries.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                curSeries.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                foreach (string key in seriesCollection[i].Keys)
                {
                    curSeries.Points.AddXY(key, seriesCollection[i][key]);
                }
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





        private void ForDev_Open_Click(object sender, EventArgs e)
        {            
            
            //config.SetConfigItem("DataFileName", "MultiLayerData.xlsx");
            //config.SetConfigItem("DataColumnBeginIndex", "1");
            //config.SetConfigItem("CRLimit", "0.01");
            //config.SetConfigItem("TotalLayers", "4");
            //config.SetConfigItem("TargetName", "理想度");
            //config.SetConfigItem("PlanNames", "计划1;计划2;计划3;计划4");
            //config.SetConfigItem("理想度", "准则1A;准则1B;准则1C");
            //config.SetConfigItem("准则1A","准则2A;准则2B");
            //config.SetConfigItem("准则1B","准则2B;准则2C;准则2D");
            //config.SetConfigItem("准则1C","准则2A;准则2B;准则2D");

            OpenFileDialog openFile = new OpenFileDialog();

            //获得AHP工程文件路径
            openFile.Title = "选择AHP工程文件...";
            openFile.Filter = "AHP工程文件(*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult result = openFile.ShowDialog();
            string file_input = openFile.FileName;

            //读取工程文件获得数据文件路径
            AHPSolution config = new AHPSolution(file_input);
            DisplaySolutionInfo(file_input, config);    //显示Solution信息到界面上
            string file_data = config.GetDataFilePath();


            if (DialogResult.OK == result)
            {
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

                MultiLayersAHP mahp = new MultiLayersAHP(config, this.matrixAHP);
                mahp.CalculatePriorities();
                mahp.CalculateTargetPriorities();

                mahp.TestMethod();
            }

            
        }

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
