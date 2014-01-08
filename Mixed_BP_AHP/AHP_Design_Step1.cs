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
    public partial class AHP_Design_Step1 : UserControl
    {
        public AHP_Design_Step1()
        {
            InitializeComponent();
        }

        public int[] GetValue()
        {
            string stringInput = this.Textbox_LayerCount.Text;
            string[] stringValues = stringInput.Split(',');
            int[] values = new int[stringValues.Length];
            int i = 0;
            foreach (string item in stringValues)
            {
                values[i++] = Convert.ToInt32(item);
            }

            return values;
        }
    }
}
