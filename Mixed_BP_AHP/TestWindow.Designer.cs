namespace Mixed_BP_AHP
{
    partial class TestWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.uC_Tree1 = new Mixed_BP_AHP.UC_Tree();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uC_Tree1
            // 
            this.uC_Tree1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_Tree1.Location = new System.Drawing.Point(256, 130);
            this.uC_Tree1.Name = "uC_Tree1";
            this.uC_Tree1.Size = new System.Drawing.Size(323, 236);
            this.uC_Tree1.TabIndex = 0;
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(591, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_Tree1);
            this.Name = "TestWindow";
            this.Text = "TestWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Tree uC_Tree1;
        private System.Windows.Forms.Button button1;
    }
}