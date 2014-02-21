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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.forDevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForDev_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SolutionInfo_SolutionName = new System.Windows.Forms.TextBox();
            this.SolutionInfo_DataFilePath = new System.Windows.Forms.TextBox();
            this.SolutionInfo_BeginColumn = new System.Windows.Forms.TextBox();
            this.SolutionInfo_TotalLayers = new System.Windows.Forms.TextBox();
            this.SolutionInfo_CRLimit = new System.Windows.Forms.TextBox();
            this.SolutionInfo_TargetName = new System.Windows.Forms.TextBox();
            this.SolutionInfo_PlanNames = new System.Windows.Forms.TextBox();
            this.ahP_Design_Guide1 = new Mixed_BP_AHP.AHP_Design_Guide();
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
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.BPAHP_tabControl.Size = new System.Drawing.Size(457, 613);
            this.BPAHP_tabControl.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(449, 584);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "BP调整的判断矩阵";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AHP_ToolStripMenuItem,
            this.Decision_ToolStripMenuItem,
            this.Help_ToolStripMenuItem,
            this.forDevToolStripMenuItem});
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
            this.Menu_OpenJudgmentFile.Name = "Menu_OpenJudgmentFile";
            this.Menu_OpenJudgmentFile.Size = new System.Drawing.Size(130, 24);
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
            this.AHP_test.Name = "AHP_test";
            this.AHP_test.Size = new System.Drawing.Size(153, 24);
            this.AHP_test.Text = "AHP(&A)";
            this.AHP_test.Click += new System.EventHandler(this.AHP_test_Click);
            // 
            // BP_AHP_Test
            // 
            this.BP_AHP_Test.Name = "BP_AHP_Test";
            this.BP_AHP_Test.Size = new System.Drawing.Size(153, 24);
            this.BP_AHP_Test.Text = "BP-AHP(&B)";
            this.BP_AHP_Test.Click += new System.EventHandler(this.BP_AHP_Test_Click);
            // 
            // Option_ToolStripMenuItem
            // 
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
            // forDevToolStripMenuItem
            // 
            this.forDevToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ForDev_Open});
            this.forDevToolStripMenuItem.Name = "forDevToolStripMenuItem";
            this.forDevToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.forDevToolStripMenuItem.Text = "For_Dev";
            // 
            // ForDev_Open
            // 
            this.ForDev_Open.Name = "ForDev_Open";
            this.ForDev_Open.Size = new System.Drawing.Size(118, 24);
            this.ForDev_Open.Text = "Open";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1215, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // AHP_tabControl
            // 
            this.AHP_tabControl.Controls.Add(this.tabPage1);
            this.AHP_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AHP_tabControl.Location = new System.Drawing.Point(4, 22);
            this.AHP_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.AHP_tabControl.Name = "AHP_tabControl";
            this.AHP_tabControl.SelectedIndex = 0;
            this.AHP_tabControl.Size = new System.Drawing.Size(478, 613);
            this.AHP_tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(470, 584);
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
            this.splitContainer1.Size = new System.Drawing.Size(964, 639);
            this.splitContainer1.SplitterDistance = 486;
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
            this.groupBox2.Size = new System.Drawing.Size(486, 639);
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
            this.groupBox3.Size = new System.Drawing.Size(465, 639);
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
            this.View_tabControl.Location = new System.Drawing.Point(235, 28);
            this.View_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.View_tabControl.Name = "View_tabControl";
            this.View_tabControl.SelectedIndex = 0;
            this.View_tabControl.Size = new System.Drawing.Size(980, 676);
            this.View_tabControl.TabIndex = 11;
            // 
            // Design_Page
            // 
            this.Design_Page.Controls.Add(this.ahP_Design_Guide1);
            this.Design_Page.Location = new System.Drawing.Point(4, 25);
            this.Design_Page.Name = "Design_Page";
            this.Design_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Design_Page.Size = new System.Drawing.Size(972, 647);
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
            this.DataView_Page.Size = new System.Drawing.Size(972, 647);
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
            this.ResultView_Page.Size = new System.Drawing.Size(972, 647);
            this.ResultView_Page.TabIndex = 1;
            this.ResultView_Page.Text = "结果视图";
            this.ResultView_Page.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(964, 639);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(235, 676);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SolutionInfo_PlanNames);
            this.groupBox1.Controls.Add(this.SolutionInfo_TargetName);
            this.groupBox1.Controls.Add(this.SolutionInfo_CRLimit);
            this.groupBox1.Controls.Add(this.SolutionInfo_TotalLayers);
            this.groupBox1.Controls.Add(this.SolutionInfo_BeginColumn);
            this.groupBox1.Controls.Add(this.SolutionInfo_DataFilePath);
            this.groupBox1.Controls.Add(this.SolutionInfo_SolutionName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 666);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "描述信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "工程文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "标识数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "AHP层次";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CR阈值";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "目标名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "方案名称";
            // 
            // SolutionInfo_SolutionName
            // 
            this.SolutionInfo_SolutionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_SolutionName.Location = new System.Drawing.Point(82, 22);
            this.SolutionInfo_SolutionName.Name = "SolutionInfo_SolutionName";
            this.SolutionInfo_SolutionName.Size = new System.Drawing.Size(136, 25);
            this.SolutionInfo_SolutionName.TabIndex = 7;
            // 
            // SolutionInfo_DataFilePath
            // 
            this.SolutionInfo_DataFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_DataFilePath.Location = new System.Drawing.Point(82, 53);
            this.SolutionInfo_DataFilePath.Name = "SolutionInfo_DataFilePath";
            this.SolutionInfo_DataFilePath.Size = new System.Drawing.Size(136, 25);
            this.SolutionInfo_DataFilePath.TabIndex = 7;
            // 
            // SolutionInfo_BeginColumn
            // 
            this.SolutionInfo_BeginColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_BeginColumn.Location = new System.Drawing.Point(82, 84);
            this.SolutionInfo_BeginColumn.Name = "SolutionInfo_BeginColumn";
            this.SolutionInfo_BeginColumn.Size = new System.Drawing.Size(136, 25);
            this.SolutionInfo_BeginColumn.TabIndex = 7;
            // 
            // SolutionInfo_TotalLayers
            // 
            this.SolutionInfo_TotalLayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_TotalLayers.Location = new System.Drawing.Point(82, 115);
            this.SolutionInfo_TotalLayers.Name = "SolutionInfo_TotalLayers";
            this.SolutionInfo_TotalLayers.Size = new System.Drawing.Size(136, 25);
            this.SolutionInfo_TotalLayers.TabIndex = 7;
            // 
            // SolutionInfo_CRLimit
            // 
            this.SolutionInfo_CRLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_CRLimit.Location = new System.Drawing.Point(82, 146);
            this.SolutionInfo_CRLimit.Name = "SolutionInfo_CRLimit";
            this.SolutionInfo_CRLimit.Size = new System.Drawing.Size(136, 25);
            this.SolutionInfo_CRLimit.TabIndex = 7;
            // 
            // SolutionInfo_TargetName
            // 
            this.SolutionInfo_TargetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_TargetName.Location = new System.Drawing.Point(82, 177);
            this.SolutionInfo_TargetName.Name = "SolutionInfo_TargetName";
            this.SolutionInfo_TargetName.Size = new System.Drawing.Size(136, 25);
            this.SolutionInfo_TargetName.TabIndex = 7;
            // 
            // SolutionInfo_PlanNames
            // 
            this.SolutionInfo_PlanNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionInfo_PlanNames.Location = new System.Drawing.Point(82, 208);
            this.SolutionInfo_PlanNames.Name = "SolutionInfo_PlanNames";
            this.SolutionInfo_PlanNames.Size = new System.Drawing.Size(136, 25);
            this.SolutionInfo_PlanNames.TabIndex = 7;
            // 
            // ahP_Design_Guide1
            // 
            this.ahP_Design_Guide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ahP_Design_Guide1.Location = new System.Drawing.Point(3, 3);
            this.ahP_Design_Guide1.Name = "ahP_Design_Guide1";
            this.ahP_Design_Guide1.Size = new System.Drawing.Size(966, 641);
            this.ahP_Design_Guide1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 704);
            this.Controls.Add(this.View_tabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
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
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
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
        private AHP_Design_Guide ahP_Design_Guide1;
        private System.Windows.Forms.ToolStripMenuItem Option_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forDevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ForDev_Open;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SolutionInfo_PlanNames;
        private System.Windows.Forms.TextBox SolutionInfo_TargetName;
        private System.Windows.Forms.TextBox SolutionInfo_CRLimit;
        private System.Windows.Forms.TextBox SolutionInfo_TotalLayers;
        private System.Windows.Forms.TextBox SolutionInfo_BeginColumn;
        private System.Windows.Forms.TextBox SolutionInfo_DataFilePath;
        private System.Windows.Forms.TextBox SolutionInfo_SolutionName;
    }
}

