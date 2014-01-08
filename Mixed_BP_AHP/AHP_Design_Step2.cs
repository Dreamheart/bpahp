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
    public partial class AHP_Design_Step2 : UserControl
    {
        public AHP_Design_Step2()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            this.label_Title.Text = title;
        }

        public string[] GetValue()
        {
            string stringInput = this.Textbox_NodeName.Text;
            string[] stringValues = stringInput.Split(',');

            return stringValues;
        }

        public void SetText(string newtext)
        {
            this.Textbox_NodeName.Text = newtext;
        }
    }
}
