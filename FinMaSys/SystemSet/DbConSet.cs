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

namespace FinMaSys
{
    public partial class DbConSet : Form
    {
        public DbConSet()
        {
            InitializeComponent();
        }

        private void btnSaveSet_Click(object sender, EventArgs e)
        {
            CommonClass commonClass = new CommonClass();
            commonClass.IniWriteValue("Database", "ServerAddr", txtServAddr.Text.Trim(), Application.StartupPath + @"\FinMaSys.ini");
            commonClass.IniWriteValue("Database", "LoginName", txtLoginName.Text.Trim(),Application.StartupPath + @"\FinMaSys.ini");
            commonClass.IniWriteValue("Database", "Pswd", txtPassword.Text.Trim(), Application.StartupPath + @"\FinMaSys.ini");
            Close();
        }

        private void DbConSet_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\FinMaSys.ini"))
            {
	            CommonClass commonClass = new CommonClass();
                txtServAddr.Text= commonClass.IniReadValue("Database", "ServerAddr", Application.StartupPath + @"\FinMaSys.ini");
                txtLoginName.Text=commonClass.IniReadValue("Database", "LoginName", Application.StartupPath + @"\FinMaSys.ini");
                txtPassword.Text=commonClass.IniReadValue("Database", "Pswd", Application.StartupPath + @"\FinMaSys.ini");
            }

        }
    }
}
