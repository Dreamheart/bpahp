using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mixed_BP_AHP
{
    public partial class TestWindow : Form
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_Tree1.Test();
            uC_Tree1.RefreshGraphic();
        }
    }
}
