using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XMLConfiguration;

namespace Mixed_BP_AHP
{
    public partial class SetupWindow : Form
    {
        public SetupWindow()
        {
            InitializeComponent();
        }

        private void SetupWindow_Load(object sender, EventArgs e)
        {
            this.Param_TB_CRRange.Text = XMLConfigurationTool.GetConfigItem("Global_CRRange", "0.1");
            this.Debug_TB_Structure.Text = XMLConfigurationTool.GetConfigItem("Debug_Structure","1,3,2");
        }

        private void Button_SaveOption_Click(object sender, EventArgs e)
        {
            //全局参数的保存
            XMLConfigurationTool.SetConfigItem("Global_CRRange", this.Param_TB_CRRange.Text);
            //调试参数的保存
            XMLConfigurationTool.SetConfigItem("Debug_Structure", this.Debug_TB_Structure.Text);
            this.Close();
        }

        private void Button_CancelOption_Click(object sender, EventArgs e)
        {
            //关闭窗口不保存修改
            this.Close();
        }
    }
}
