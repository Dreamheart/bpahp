namespace Mixed_BP_AHP
{
    partial class AHP_Design_Step1
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
            this.Textbox_LayerCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Textbox_LayerCount
            // 
            this.Textbox_LayerCount.Location = new System.Drawing.Point(94, 121);
            this.Textbox_LayerCount.Name = "Textbox_LayerCount";
            this.Textbox_LayerCount.Size = new System.Drawing.Size(100, 25);
            this.Textbox_LayerCount.TabIndex = 4;
            this.Textbox_LayerCount.Text = "1,3,2";
            this.Textbox_LayerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "结构";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入AHP结构，如三层结构，准则层为3条准则，方案层有2个方案，可以输入“1,3,2”";
            // 
            // AHP_Design_Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Textbox_LayerCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AHP_Design_Step1";
            this.Size = new System.Drawing.Size(320, 197);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbox_LayerCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
