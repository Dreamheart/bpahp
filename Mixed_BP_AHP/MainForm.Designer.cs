namespace Mixed_BP_AHP
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.BPAHP_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AHP_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenJudgmentFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Decision_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AHP_test = new System.Windows.Forms.ToolStripMenuItem();
            this.BP_AHP_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.Option_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.QT_Open = new System.Windows.Forms.ToolStripButton();
            this.QT_AHP = new System.Windows.Forms.ToolStripButton();
            this.QT_BPAHP = new System.Windows.Forms.ToolStripButton();
            this.AHP_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.View_tabControl = new System.Windows.Forms.TabControl();
            this.Design_Page = new System.Windows.Forms.TabPage();
            this.DataView_Page = new System.Windows.Forms.TabPage();
            this.ResultView_Page = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.QT_Setup = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SolutionInfo_PlanNames = new System.Windows.Forms.TextBox();
            this.SolutionInfo_TargetName = new System.Windows.Forms.TextBox();
            this.SolutionInfo_CRLimit = new System.Windows.Forms.TextBox();
            this.SolutionInfo_TotalLayers = new System.Windows.Forms.TextBox();
            this.SolutionInfo_BeginColumn = new System.Windows.Forms.TextBox();
            this.SolutionInfo_DataFilePath = new System.Windows.Forms.TextBox();
            this.SolutionInfo_SolutionName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BPAHP_tabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.AHP_tabControl.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.View_tabControl.SuspendLayout();
            this.Design_Page.SuspendLayout();
            this.DataView_Page.SuspendLayout();
            this.ResultView_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BPAHP_tabControl
            // 
            this.BPAHP_tabControl.Controls.Add(this.tabPage2);
            this.BPAHP_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BPAHP_tabControl.Location = new System.Drawing.Point(4, 22);
            this.BPAHP_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.BPAHP_tabControl.Name = "BPAHP_tabControl";
            this.BPAHP_tabControl.SelectedIndex = 0;
            this.BPAHP_tabControl.Size = new System.Drawing.Size(574, 588);
            this.BPAHP_tabControl.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(566, 559);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "BP调整的判断矩阵";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AHP_ToolStripMenuItem,
            this.Decision_ToolStripMenuItem,
            this.Help_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AHP_ToolStripMenuItem
            // 
            this.AHP_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OpenJudgmentFile,
            this.Exit_ToolStripMenuItem});
            this.AHP_ToolStripMenuItem.Name = "AHP_ToolStripMenuItem";
            this.AHP_ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.AHP_ToolStripMenuItem.Text = "文件(&F)";
            // 
            // Menu_OpenJudgmentFile
            // 
            this.Menu_OpenJudgmentFile.Image = ((System.Drawing.Image)(resources.GetObject("Menu_OpenJudgmentFile.Image")));
            this.Menu_OpenJudgmentFile.Name = "Menu_OpenJudgmentFile";
            this.Menu_OpenJudgmentFile.Size = new System.Drawing.Size(152, 24);
            this.Menu_OpenJudgmentFile.Text = "打开(&O)";
            this.Menu_OpenJudgmentFile.Click += new System.EventHandler(this.Menu_OpenJudgmentFile_Click);
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.Exit_ToolStripMenuItem.Text = "退出(&X)";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // Decision_ToolStripMenuItem
            // 
            this.Decision_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AHP_test,
            this.BP_AHP_Test,
            this.Option_ToolStripMenuItem});
            this.Decision_ToolStripMenuItem.Name = "Decision_ToolStripMenuItem";
            this.Decision_ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.Decision_ToolStripMenuItem.Text = "决策分析(&D)";
            // 
            // AHP_test
            // 
            this.AHP_test.Image = ((System.Drawing.Image)(resources.GetObject("AHP_test.Image")));
            this.AHP_test.Name = "AHP_test";
            this.AHP_test.Size = new System.Drawing.Size(153, 24);
            this.AHP_test.Text = "AHP(&A)";
            this.AHP_test.Click += new System.EventHandler(this.AHP_test_Click);
            // 
            // BP_AHP_Test
            // 
            this.BP_AHP_Test.Image = ((System.Drawing.Image)(resources.GetObject("BP_AHP_Test.Image")));
            this.BP_AHP_Test.Name = "BP_AHP_Test";
            this.BP_AHP_Test.Size = new System.Drawing.Size(153, 24);
            this.BP_AHP_Test.Text = "BP-AHP(&B)";
            this.BP_AHP_Test.Click += new System.EventHandler(this.BP_AHP_Test_Click);
            // 
            // Option_ToolStripMenuItem
            // 
            this.Option_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Option_ToolStripMenuItem.Image")));
            this.Option_ToolStripMenuItem.Name = "Option_ToolStripMenuItem";
            this.Option_ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.Option_ToolStripMenuItem.Text = "设置(&O)";
            this.Option_ToolStripMenuItem.Click += new System.EventHandler(this.Option_ToolStripMenuItem_Click);
            // 
            // Help_ToolStripMenuItem
            // 
            this.Help_ToolStripMenuItem.Name = "Help_ToolStripMenuItem";
            this.Help_ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.Help_ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QT_Open,
            this.QT_AHP,
            this.QT_BPAHP,
            this.QT_Setup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1215, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // QT_Open
            // 
            this.QT_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QT_Open.Image = ((System.Drawing.Image)(resources.GetObject("QT_Open.Image")));
            this.QT_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QT_Open.Name = "QT_Open";
            this.QT_Open.Size = new System.Drawing.Size(23, 22);
            this.QT_Open.Text = "打开";
            this.QT_Open.Click += new System.EventHandler(this.QT_Open_Click);
            // 
            // QT_AHP
            // 
            this.QT_AHP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QT_AHP.Image = ((System.Drawing.Image)(resources.GetObject("QT_AHP.Image")));
            this.QT_AHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QT_AHP.Name = "QT_AHP";
            this.QT_AHP.Size = new System.Drawing.Size(23, 22);
            this.QT_AHP.Text = "AHP决策";
            this.QT_AHP.Click += new System.EventHandler(this.QT_AHP_Click);
            // 
            // QT_BPAHP
            // 
            this.QT_BPAHP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QT_BPAHP.Image = ((System.Drawing.Image)(resources.GetObject("QT_BPAHP.Image")));
            this.QT_BPAHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QT_BPAHP.Name = "QT_BPAHP";
            this.QT_BPAHP.Size = new System.Drawing.Size(23, 22);
            this.QT_BPAHP.Text = "BP-AHP决策";
            this.QT_BPAHP.Click += new System.EventHandler(this.QT_BPAHP_Click);
            // 
            // AHP_tabControl
            // 
            this.AHP_tabControl.Controls.Add(this.tabPage1);
            this.AHP_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AHP_tabControl.Location = new System.Drawing.Point(4, 22);
            this.AHP_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.AHP_tabControl.Name = "AHP_tabControl";
            this.AHP_tabControl.SelectedIndex = 0;
            this.AHP_tabControl.Size = new System.Drawing.Size(596, 588);
            this.AHP_tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(588, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "原始判断矩阵";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1199, 614);
            this.splitContainer1.SplitterDistance = 604;
            this.splitContainer1.SplitterWidth = 13;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AHP_tabControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(604, 614);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "原始AHP判断矩阵";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BPAHP_tabControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(582, 614);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "经BP调整一致性的判断矩阵";
            // 
            // View_tabControl
            // 
            this.View_tabControl.Controls.Add(this.Design_Page);
            this.View_tabControl.Controls.Add(this.DataView_Page);
            this.View_tabControl.Controls.Add(this.ResultView_Page);
            this.View_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View_tabControl.Location = new System.Drawing.Point(0, 53);
            this.View_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.View_tabControl.Name = "View_tabControl";
            this.View_tabControl.SelectedIndex = 0;
            this.View_tabControl.Size = new System.Drawing.Size(1215, 626);
            this.View_tabControl.TabIndex = 11;
            // 
            // Design_Page
            // 
            this.Design_Page.Controls.Add(this.groupBox1);
            this.Design_Page.Location = new System.Drawing.Point(4, 25);
            this.Design_Page.Name = "Design_Page";
            this.Design_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Design_Page.Size = new System.Drawing.Size(1207, 597);
            this.Design_Page.TabIndex = 2;
            this.Design_Page.Text = "设计视图";
            this.Design_Page.UseVisualStyleBackColor = true;
            // 
            // DataView_Page
            // 
            this.DataView_Page.Controls.Add(this.splitContainer1);
            this.DataView_Page.Location = new System.Drawing.Point(4, 25);
            this.DataView_Page.Margin = new System.Windows.Forms.Padding(4);
            this.DataView_Page.Name = "DataView_Page";
            this.DataView_Page.Padding = new System.Windows.Forms.Padding(4);
            this.DataView_Page.Size = new System.Drawing.Size(1207, 622);
            this.DataView_Page.TabIndex = 0;
            this.DataView_Page.Text = "数据视图";
            this.DataView_Page.UseVisualStyleBackColor = true;
            // 
            // ResultView_Page
            // 
            this.ResultView_Page.Controls.Add(this.chart1);
            this.ResultView_Page.Location = new System.Drawing.Point(4, 25);
            this.ResultView_Page.Margin = new System.Windows.Forms.Padding(4);
            this.ResultView_Page.Name = "ResultView_Page";
            this.ResultView_Page.Padding = new System.Windows.Forms.Padding(4);
            this.ResultView_Page.Size = new System.Drawing.Size(972, 622);
            this.ResultView_Page.TabIndex = 1;
            this.ResultView_Page.Text = "结果视图";
            this.ResultView_Page.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(4, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(964, 614);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // QT_Setup
            // 
            this.QT_Setup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QT_Setup.Image = ((System.Drawing.Image)(resources.GetObject("QT_Setup.Image")));
            this.QT_Setup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QT_Setup.Name = "QT_Setup";
            this.QT_Setup.Size = new System.Drawing.Size(23, 22);
            this.QT_Setup.Text = "设置";
            this.QT_Setup.Click += new System.EventHandler(this.QT_Setup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 591);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "描述信息";
            // 
            // SolutionInfo_PlanNames
            // 
            this.SolutionInfo_PlanNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_PlanNames.Location = new System.Drawing.Point(92, 195);
            this.SolutionInfo_PlanNames.Name = "SolutionInfo_PlanNames";
            this.SolutionInfo_PlanNames.Size = new System.Drawing.Size(748, 25);
            this.SolutionInfo_PlanNames.TabIndex = 7;
            // 
            // SolutionInfo_TargetName
            // 
            this.SolutionInfo_TargetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_TargetName.Location = new System.Drawing.Point(92, 164);
            this.SolutionInfo_TargetName.Name = "SolutionInfo_TargetName";
            this.SolutionInfo_TargetName.Size = new System.Drawing.Size(748, 25);
            this.SolutionInfo_TargetName.TabIndex = 7;
            // 
            // SolutionInfo_CRLimit
            // 
            this.SolutionInfo_CRLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_CRLimit.Location = new System.Drawing.Point(92, 133);
            this.SolutionInfo_CRLimit.Name = "SolutionInfo_CRLimit";
            this.SolutionInfo_CRLimit.Size = new System.Drawing.Size(748, 25);
            this.SolutionInfo_CRLimit.TabIndex = 7;
            // 
            // SolutionInfo_TotalLayers
            // 
            this.SolutionInfo_TotalLayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_TotalLayers.Location = new System.Drawing.Point(92, 102);
            this.SolutionInfo_TotalLayers.Name = "SolutionInfo_TotalLayers";
            this.SolutionInfo_TotalLayers.Size = new System.Drawing.Size(748, 25);
            this.SolutionInfo_TotalLayers.TabIndex = 7;
            // 
            // SolutionInfo_BeginColumn
            // 
            this.SolutionInfo_BeginColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_BeginColumn.Location = new System.Drawing.Point(92, 71);
            this.SolutionInfo_BeginColumn.Name = "SolutionInfo_BeginColumn";
            this.SolutionInfo_BeginColumn.Size = new System.Drawing.Size(748, 25);
            this.SolutionInfo_BeginColumn.TabIndex = 7;
            // 
            // SolutionInfo_DataFilePath
            // 
            this.SolutionInfo_DataFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_DataFilePath.Location = new System.Drawing.Point(92, 40);
            this.SolutionInfo_DataFilePath.Name = "SolutionInfo_DataFilePath";
            this.SolutionInfo_DataFilePath.Size = new System.Drawing.Size(748, 25);
            this.SolutionInfo_DataFilePath.TabIndex = 7;
            // 
            // SolutionInfo_SolutionName
            // 
            this.SolutionInfo_SolutionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_SolutionName.Location = new System.Drawing.Point(92, 9);
            this.SolutionInfo_SolutionName.Name = "SolutionInfo_SolutionName";
            this.SolutionInfo_SolutionName.Size = new System.Drawing.Size(748, 25);
            this.SolutionInfo_SolutionName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "方案名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "目标名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CR阈值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "AHP层次";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "标识数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据文件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "工程文件";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SolutionInfo_BeginColumn);
            this.panel1.Controls.Add(this.SolutionInfo_PlanNames);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SolutionInfo_TargetName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SolutionInfo_CRLimit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SolutionInfo_TotalLayers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SolutionInfo_DataFilePath);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SolutionInfo_SolutionName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 567);
            this.panel1.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1215, 25);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "状态栏";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 704);
            this.Controls.Add(this.View_tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Mixed_BP_AHP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BPAHP_tabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.AHP_tabControl.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.View_tabControl.ResumeLayout(false);
            this.Design_Page.ResumeLayout(false);
            this.DataView_Page.ResumeLayout(false);
            this.ResultView_Page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl BPAHP_tabControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AHP_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenJudgmentFile;
        private System.Windows.Forms.ToolStripMenuItem Help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton QT_Open;
        private System.Windows.Forms.ToolStripButton QT_AHP;
        private System.Windows.Forms.ToolStripButton QT_BPAHP;
        private System.Windows.Forms.TabControl AHP_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Decision_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AHP_test;
        private System.Windows.Forms.ToolStripMenuItem BP_AHP_Test;
        private System.Windows.Forms.TabControl View_tabControl;
        private System.Windows.Forms.TabPage DataView_Page;
        private System.Windows.Forms.TabPage ResultView_Page;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage Design_Page;
        private System.Windows.Forms.ToolStripMenuItem Option_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton QT_Setup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SolutionInfo_PlanNames;
        private System.Windows.Forms.TextBox SolutionInfo_TargetName;
        private System.Windows.Forms.TextBox SolutionInfo_CRLimit;
        private System.Windows.Forms.TextBox SolutionInfo_TotalLayers;
        private System.Windows.Forms.TextBox SolutionInfo_BeginColumn;
        private System.Windows.Forms.TextBox SolutionInfo_DataFilePath;
        private System.Windows.Forms.TextBox SolutionInfo_SolutionName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

