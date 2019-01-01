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
    public partial class Parameter : Form
    {
        public Parameter()
        {
            InitializeComponent();
        }

        private void cbUserAble_DropDown(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "SELECT [StatusID]   FROM tb_UsersStatus where [UsersStatus]='正常'";
            try
            {
	            DataTable dt = dataBase.GetDataTable();
	            if (dt.Rows.Count>0)
	            {
                    cbUserAble.Items.Clear();
	                cbUserAble.Items.Add(dt.Rows[0][0].ToString());
	            }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }

        private void cbUserDiss_DropDown(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "SELECT [StatusID]   FROM tb_UsersStatus where [UsersStatus]='锁定'";
            try
            {
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count > 0)
                {
                    cbUserDiss.Items.Clear();
                    cbUserDiss.Items.Add(dt.Rows[0][0].ToString());
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CommonClass commonClass = new CommonClass();
            commonClass.IniWriteValue("UserStatus","Normal",cbUserAble.Text.Trim(),Application.StartupPath+@"\FinMaSys.ini");
            commonClass.IniWriteValue("UserStatus", "DisAble", cbUserDiss.Text.Trim(), Application.StartupPath + @"\FinMaSys.ini");
            commonClass.IniWriteValue("UserCompany", "coName",txtCoName.Text.Trim(), Application.StartupPath + @"\FinMaSys.ini");
            btnSave.Enabled = false;
            cbUserAble.Enabled = false;
            cbUserDiss.Enabled = false;
            txtCoName.Enabled = false;
        }

        private void Parameter_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\FinMaSys.ini"))
            {
                CommonClass commonClass = new CommonClass();
                cbUserAble.Text = commonClass.IniReadValue("UserStatus", "Normal", Application.StartupPath + @"\FinMaSys.ini");
                cbUserDiss.Text = commonClass.IniReadValue("UserStatus", "DisAble", Application.StartupPath + @"\FinMaSys.ini");
                txtCoName.Text = commonClass.IniReadValue("UserCompany", "coName", Application.StartupPath + @"\FinMaSys.ini");
                if (!string.IsNullOrEmpty(cbUserAble.Text))
                {
                    cbUserAble.Enabled = false;

                }
                if (!string.IsNullOrEmpty(txtCoName.Text.Trim()))
                {
                   txtCoName.Enabled = false;
                }
                if (!string.IsNullOrEmpty(cbUserDiss.Text))
                {
                    cbUserDiss.Enabled = false;

                }
                if (!string.IsNullOrEmpty(cbUserAble.Text)&& !string.IsNullOrEmpty(txtCoName.Text.Trim())&& !string.IsNullOrEmpty(cbUserDiss.Text))
                {
                    cbUserAble.Enabled = false;
                    txtCoName.Enabled = false;
                    cbUserDiss.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
            else
            {
                btnSave.Enabled = true;
                cbUserAble.Enabled = true;
                cbUserDiss.Enabled = true;
                txtCoName.Enabled = true;
            }
        }
    }
}
    
