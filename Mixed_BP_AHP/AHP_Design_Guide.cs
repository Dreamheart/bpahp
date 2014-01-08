using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mixed_BP_AHP
{
    public partial class AHP_Design_Guide : UserControl
    {
        private int curStep = 0;
        private int[] structure = null;

        public AHP_Design_Guide()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.curStep -= 1;
            if (curStep == 0)
            {
                this.button_back.Enabled = false;
            }
            if (curStep <this.structure.Length+1)
            {
                this.button_next.Enabled = true;
            }

            ChangeStepPanel(this.curStep);
            PreviewAHPTree_Remove(this.curStep);
        }

        private void PreviewAHPTree_Remove(int p)
        {
            if (p >=1 && p<=this.structure.Length+1)
            {
                this.uC_Tree1.ClearLevel(p);
                this.uC_Tree1.RefreshGraphic();
            }
            
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.curStep += 1;
            if (curStep == 1)
            {
                this.button_back.Enabled = true;

                this.structure = Step1.GetValue();

                
            }

            if (this.curStep >= this.structure.Length+1)
            {
                this.curStep = this.structure.Length+1;
                this.button_next.Enabled = false;
            }

            PreviewAHPTree(this.curStep);
            ChangeStepPanel(this.curStep);
        }

        private void PreviewAHPTree(int step)
        {
            if (step == 1)
            {
                this.uC_Tree1.Init(this.structure.Length);
            }
            else if (step <= this.structure.Length+1)
            {
                string[] names = Step2.GetValue();
                for (int i = 0; i < names.Length; i++)
                {
                    this.uC_Tree1.AddNode(names[i], step - 2); 
                }

                this.uC_Tree1.RefreshGraphic();
            }
        }

        private void ChangeStepPanel(int curStep)
        {
            Step1.Visible = false;
            Step2.Visible = false;

            if (curStep == 0)
            {
                Step1.Visible = true;
            }
            else if (curStep <= this.structure.Length)
            {
                Step2.Visible = true;
                if (curStep == 1)
                {
                    Step2.SetTitle("目标层");
                    Step2.SetText("理想度");
                }
                else if (curStep == this.structure.Length)
                {
                    Step2.SetTitle("方案层");
                    Step2.SetText("Job1,Job2");
                }
                else
                {
                    Step2.SetTitle(string.Format("准则层{0}",curStep-1));
                    Step2.SetText("薪水高,工作量小,距离近");
                }
            }
        }
    }
}
