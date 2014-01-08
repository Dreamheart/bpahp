namespace Mixed_BP_AHP
{
    partial class AHP_Design_Step2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_NodeName = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入目标层节点名称，多个节点间以\',\'分隔";
            // 
            // Textbox_NodeName
            // 
            this.Textbox_NodeName.Location = new System.Drawing.Point(29, 152);
            this.Textbox_NodeName.Name = "Textbox_NodeName";
            this.Textbox_NodeName.Size = new System.Drawing.Size(247, 25);
            this.Textbox_NodeName.TabIndex = 1;
            this.Textbox_NodeName.Text = "理想度";
            this.Textbox_NodeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(130, 39);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(64, 20);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Title";
            // 
            // AHP_Design_Step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.Textbox_NodeName);
            this.Controls.Add(this.label1);
            this.Name = "AHP_Design_Step2";
            this.Size = new System.Drawing.Size(324, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_NodeName;
        private System.Windows.Forms.Label label_Title;
    }
}
