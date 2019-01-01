using FinMaSys.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMaSys.ShareForm
{
    public partial class PrintSet : Form
    {
        public PrintSet()
        {
            InitializeComponent();
        }

        private void PrintSet_Load(object sender, EventArgs e)
        {
            CommonClass commonClass = new CommonClass();
            if (File.Exists(Application.StartupPath + @"\FinMaSys.ini"))
            {
                txtXPosition.Text = commonClass.IniReadValue("X", "XPosition", Application.StartupPath + @"\FinMaSys.ini");
                txtYPosition.Text = commonClass.IniReadValue("Y", "YPosition", Application.StartupPath + @"\FinMaSys.ini");

            }
        }

        private void btnSaveSet_Click(object sender, EventArgs e)
        {
            CommonClass common = new CommonClass();
            common.IniWriteValue("X", "XPosition", txtXPosition.Text.Trim(), Application.StartupPath + @"\FinMaSys.ini");
            common.IniWriteValue("Y", "YPosition", txtYPosition.Text.Trim(), Application.StartupPath + @"\FinMaSys.ini");
            MessageBox.Show("设置成功！", "提示");
            this.Close();
        }
    }
}
