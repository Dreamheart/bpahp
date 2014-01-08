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
using AHP;
using Microsoft.Office.Core;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mixed_BP_AHP
{
    public partial class MainForm : Form
    {
        private int DataColumnBeginIndex = 1;
        private BasicAHP ahp = null;
        private DataSet matrixAHP = null;

        private string[] names = null;
        private Dictionary<string, double>[] seriesCollection = null;

        public MainForm()
        {
            InitializeComponent();
        }


        ///// <summary>
        ///// 通过对话框选择BP网络训练数据文件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void menuImportTrainData_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFile = new OpenFileDialog();

        //    //获得训练数据输入数据文件名
        //    openFile.Title = "Training input...";
        //    openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        //    DialogResult result1 = openFile.ShowDialog();
        //    string file_input = openFile.FileName;

        //    //获得训练数据期望输出文件名
        //    openFile.Title = "Training output...";
        //    openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        //    DialogResult result2 = openFile.ShowDialog();
        //    string file_output = openFile.FileName;

        //    if (DialogResult.OK == result1 && DialogResult.OK == result2)
        //    {
        //        bpn = new BasicBPNet();
        //        bool isSuccess = bpn.ImportTrainData(file_input, file_output);
        //        if (isSuccess)
        //        {
        //            DataTable tmp = bpn.TrainDataTable;

        //            dataGrid_Data.DataSource = null;
        //            dataGrid_Data.Rows.Clear();
        //            dataGrid_Data.Columns.Clear();
                    
        //            dataGrid_Data.DataSource = tmp;
                    
        //            object[] row = new object[2];
        //            for (int i = 0; i < tmp.Columns.Count; i++)
        //            {
        //                row[0] = tmp.Columns[i].Caption;
        //                row[1] = tmp.Columns[i].DataType.ToString();
        //                dataGrid_Var.Rows.Add(row);
        //            }
                    
                    

        //            MessageBox.Show("Train data loaded!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Something wrong in your file...", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //private void menuTrainBPNet_Click(object sender, EventArgs e)
        //{
        //    bpn.init();
        //    int study = 0;
        //    do
        //    {
        //        study++;
        //        bpn.train();
        //        //bp.rate = 0.95 - (0.95 - 0.3) * study / 50000;
        //        //Console.Write("第 " + study + "次学习： ");
        //        //Console.WriteLine(" 均方差为 " + bp.e);  

        //    } while (bpn.e > 0.001 && study < 50000);

        //    text_output.Text += "第 " + study + "次学习： ";
        //    text_output.Text += " 均方差为 " + bpn.e + "  " + System.Environment.NewLine;

        //    bpn.saveMatrix(bpn.w, "w.txt");
        //    bpn.saveMatrix(bpn.v, "v.txt");
        //    bpn.saveMatrix(bpn.b1, "b1.txt");
        //    bpn.saveMatrix(bpn.b2, "b2.txt");
        //    bpn.saveParas("para.txt");
        //}

        //private void menuImportPredictData_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFile = new OpenFileDialog();

        //    //获得预测数据文件名
        //    openFile.Title = "Predict input...";
        //    openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        //    DialogResult result = openFile.ShowDialog();
        //    string file_input = openFile.FileName;

        //    if (DialogResult.OK == result)
        //    {
        //        bpn = new BasicBPNet();
        //        bool isSuccess = bpn.ImportPredictData(file_input);
        //        if (isSuccess)
        //        {
        //            DataTable tmp = bpn.PredictDataTable;

        //            dataGrid_Data.DataSource = null;
        //            dataGrid_Data.Rows.Clear();
        //            dataGrid_Data.Columns.Clear();
                    
        //            dataGrid_Var.Rows.Clear();

        //            dataGrid_Data.DataSource = tmp;

        //            object[] row = new object[2];
        //            for (int i = 0; i < tmp.Columns.Count; i++)
        //            {
        //                row[0] = tmp.Columns[i].Caption;
        //                row[1] = tmp.Columns[i].DataType.ToString();
        //                dataGrid_Var.Rows.Add(row);
        //            }

        //            MessageBox.Show("Predict data loaded!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Something wrong in your file...", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //}

        //private void menuPredict_Click(object sender, EventArgs e)
        //{
        //    text_output.Text += bpn.PredictData();
        //}

        //private void menuSaveBPNet_Click(object sender, EventArgs e)
        //{
        //    bpn.SaveBPNet();
        //}

        //private void menuLoadBPNet_Click(object sender, EventArgs e)
        //{
        //    bpn = new BasicBPNet();
        //    bpn.LoadBPNet();
        //}

        private void AHP_test_Click(object sender, EventArgs e)
        {
            //text_output.Text += "AHP决策结果：" + System.Environment.NewLine;
            try
            {
                Dictionary<string,double> dict = SetJudgmentMatrixFromDataSet(this.matrixAHP);
                this.AddNewSeriesToChart(chart1, "AHP决策", dict);
                View_tabControl.SelectedTab = ResultView_Page;

                //插入数据

                //this.names[0] = "AHP决策";
                //this.seriesCollection[0] = dict;

                //this.CreateBarChart(chart1, this.names, this.seriesCollection);
            }
            catch (NullJudgmentMatrixException ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        private Dictionary<string,double> SetJudgmentMatrixFromDataSet(DataSet dsMatrix)
        {
            int[] a = { 1, 3, 2 };
            #region Temp

            this.names = new string[2];
            this.seriesCollection = new Dictionary<string, double>[2];

            #endregion


            this.ahp = new BasicAHP(a);

            this.ahp.SetJudgmentMatrix(dsMatrix);

            double[] result = ahp.Assessment();

            Dictionary<string, double> dict = new Dictionary<string, double>();

            for (int i = 0; i < result.Length; i++)
            {
                dict.Add(string.Format("方案{0}", i), result[i]);
            }

            return dict;

          


            //for (int index = 0; index < result.Length; index++)
            //{
            //    text_output.Text += string.Format("方案{0}决策结果:  {1}  ", index, result[index]) + System.Environment.NewLine;
            //}
            //text_output.Select(text_output.Text.Length, 0);
            //text_output.ScrollToCaret();
        }



        private void Menu_OpenJudgmentFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            //获得训练数据输入数据文件名
            openFile.Title = "Select JudgmentMatrix File ...";
            openFile.Filter = "Text files (*.xlsx)|*.xlsx|Text files (*.xls)|*.xls|All files (*.*)|*.*";
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
            //text_output.Text += "BP-AHP混合决策结果：" + System.Environment.NewLine;
            Dictionary<string,double> dict = SetJudgmentMatrixFromDataSet(ahp.GetBPAdjustMatrix());

            //插入数据

            //this.names[1] = "BP-AHP决策";
            //this.seriesCollection[1] = dict;

            this.AddNewSeriesToChart(chart1,"BP-AHP决策",dict);
            View_tabControl.SelectedTab = ResultView_Page;
            //this.CreateBarChart(chart1, this.names, this.seriesCollection);
        }

        private void AdjustConsistencyAndDisplay()
        {
            BPAHP_tabControl.TabPages.Clear();

            ahp.AdjustConsistency();
            DataSet bpMatrix = ahp.GetBPAdjustMatrix();
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

    }       
}
