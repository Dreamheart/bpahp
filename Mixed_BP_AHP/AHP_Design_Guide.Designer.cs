namespace Mixed_BP_AHP
{
    partial class AHP_Design_Guide
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_next = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.Step2 = new Mixed_BP_AHP.AHP_Design_Step2();
            this.Step1 = new Mixed_BP_AHP.AHP_Design_Step1();
            this.uC_Tree1 = new Mixed_BP_AHP.UC_Tree();
            this.SuspendLayout();
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(263, 298);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "下一步";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_back
            // 
            this.button_back.Enabled = false;
            this.button_back.Location = new System.Drawing.Point(55, 298);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "上一步";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Step2
            // 
            this.Step2.Location = new System.Drawing.Point(37, 23);
            this.Step2.Name = "Step2";
            this.Step2.Size = new System.Drawing.Size(324, 253);
            this.Step2.TabIndex = 7;
            this.Step2.Visible = false;
            // 
            // Step1
            // 
            this.Step1.Location = new System.Drawing.Point(37, 34);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(320, 197);
            this.Step1.TabIndex = 6;
            // 
            // uC_Tree1
            // 
            this.uC_Tree1.Location = new System.Drawing.Point(367, 23);
            this.uC_Tree1.Name = "uC_Tree1";
            this.uC_Tree1.Size = new System.Drawing.Size(624, 378);
            this.uC_Tree1.TabIndex = 5;
            // 
            // AHP_Design_Guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Step2);
            this.Controls.Add(this.Step1);
            this.Controls.Add(this.uC_Tree1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_next);
            this.Name = "AHP_Design_Guide";
            this.Size = new System.Drawing.Size(1009, 418);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_back;
        private UC_Tree uC_Tree1;
        private AHP_Design_Step1 Step1;
        private AHP_Design_Step2 Step2;
    }
}
