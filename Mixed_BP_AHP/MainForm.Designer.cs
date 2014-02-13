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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.ahP_Design_Guide1 = new Mixed_BP_AHP.AHP_Design_Guide();
            this.forDevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForDev_Open = new System.Windows.Forms.ToolStripMenuItem();
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
            this.BPAHP_tabControl.Size = new System.Drawing.Size(573, 613);
            this.BPAHP_tabControl.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(565, 584);
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
            this.AHP_tabControl.Size = new System.Drawing.Size(597, 613);
            this.AHP_tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(589, 584);
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
            this.splitContainer1.Size = new System.Drawing.Size(1199, 639);
            this.splitContainer1.SplitterDistance = 605;
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
            this.groupBox2.Size = new System.Drawing.Size(605, 639);
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
            this.groupBox3.Size = new System.Drawing.Size(581, 639);
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
            this.View_tabControl.Location = new System.Drawing.Point(0, 28);
            this.View_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.View_tabControl.Name = "View_tabControl";
            this.View_tabControl.SelectedIndex = 0;
            this.View_tabControl.Size = new System.Drawing.Size(1215, 676);
            this.View_tabControl.TabIndex = 11;
            // 
            // Design_Page
            // 
            this.Design_Page.Controls.Add(this.ahP_Design_Guide1);
            this.Design_Page.Location = new System.Drawing.Point(4, 25);
            this.Design_Page.Name = "Design_Page";
            this.Design_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Design_Page.Size = new System.Drawing.Size(1207, 647);
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
            this.DataView_Page.Size = new System.Drawing.Size(1207, 647);
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
            this.ResultView_Page.Size = new System.Drawing.Size(1207, 647);
            this.ResultView_Page.TabIndex = 1;
            this.ResultView_Page.Text = "结果视图";
            this.ResultView_Page.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(4, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1199, 639);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ahP_Design_Guide1
            // 
            this.ahP_Design_Guide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ahP_Design_Guide1.Location = new System.Drawing.Point(3, 3);
            this.ahP_Design_Guide1.Name = "ahP_Design_Guide1";
            this.ahP_Design_Guide1.Size = new System.Drawing.Size(1201, 641);
            this.ahP_Design_Guide1.TabIndex = 0;
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
            this.ForDev_Open.Size = new System.Drawing.Size(152, 24);
            this.ForDev_Open.Text = "Open";
            this.ForDev_Open.Click += new System.EventHandler(this.ForDev_Open_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 704);
            this.Controls.Add(this.View_tabControl);
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
    }
}

