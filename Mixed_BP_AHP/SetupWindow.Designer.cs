namespace Mixed_BP_AHP
{
    partial class SetupWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Debug_TB_Structure = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_SaveOption = new System.Windows.Forms.Button();
            this.Button_CancelOption = new System.Windows.Forms.Button();
            this.Param_TB_CRRange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Param_TB_CRRange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常规";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Debug_TB_Structure);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(8, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "调试";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "AHP结构";
            // 
            // Debug_TB_Structure
            // 
            this.Debug_TB_Structure.Location = new System.Drawing.Point(76, 23);
            this.Debug_TB_Structure.Name = "Debug_TB_Structure";
            this.Debug_TB_Structure.Size = new System.Drawing.Size(100, 25);
            this.Debug_TB_Structure.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_CancelOption);
            this.panel1.Controls.Add(this.Button_SaveOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 50);
            this.panel1.TabIndex = 2;
            // 
            // Button_SaveOption
            // 
            this.Button_SaveOption.Location = new System.Drawing.Point(179, 14);
            this.Button_SaveOption.Name = "Button_SaveOption";
            this.Button_SaveOption.Size = new System.Drawing.Size(75, 23);
            this.Button_SaveOption.TabIndex = 0;
            this.Button_SaveOption.Text = "保存";
            this.Button_SaveOption.UseVisualStyleBackColor = true;
            this.Button_SaveOption.Click += new System.EventHandler(this.Button_SaveOption_Click);
            // 
            // Button_CancelOption
            // 
            this.Button_CancelOption.Location = new System.Drawing.Point(317, 14);
            this.Button_CancelOption.Name = "Button_CancelOption";
            this.Button_CancelOption.Size = new System.Drawing.Size(75, 23);
            this.Button_CancelOption.TabIndex = 1;
            this.Button_CancelOption.Text = "取消";
            this.Button_CancelOption.UseVisualStyleBackColor = true;
            this.Button_CancelOption.Click += new System.EventHandler(this.Button_CancelOption_Click);
            // 
            // Param_TB_CRRange
            // 
            this.Param_TB_CRRange.Location = new System.Drawing.Point(76, 30);
            this.Param_TB_CRRange.Name = "Param_TB_CRRange";
            this.Param_TB_CRRange.Size = new System.Drawing.Size(100, 25);
            this.Param_TB_CRRange.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CR < ?";
            // 
            // SetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupWindow";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SetupWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Debug_TB_Structure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_CancelOption;
        private System.Windows.Forms.Button Button_SaveOption;
        private System.Windows.Forms.TextBox Param_TB_CRRange;
        private System.Windows.Forms.Label label2;
    }
}