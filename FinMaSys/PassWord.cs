using FinMaSys.ComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMaSys
{
    public partial class PassWord : Form
    {
        public PassWord()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pdErrProvider.Clear();
            if (txtNewPassword.Text.Trim()!=txtConfirmpassword.Text.Trim())
            {
                pdErrProvider.SetError(txtConfirmpassword,"两次输入密码不一致！");   
            }
            else
            {
                try
                {
                    string userID = CommonClass.Common_UserID;
                    DataBase dataBase = new DataBase();
                    dataBase.ConStr = "select * from tb_users where userid='"+ userID +"' and password = '"+ txtOldPassword.Text.Trim() +"'";
                    DataTable dt= dataBase.GetDataTable();
                    if (dt.Rows.Count!=0)
                    {
                        dataBase.Cmd = "Update tb_users set password='" + txtNewPassword.Text.Trim() + "' where userid='" + userID + "'";
                        dataBase.DataExcute("Update");
                        MessageBox.Show("密码已修改成功！","密码修改提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("您输入的密码错误，请重新输入！");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"错误提示");
                    throw ex;
                }
            }
        }

        private void txtOldPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNewPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue ==13)
            {
            	SendKeys.Send("{TAB}");
            }
        }

        private void txtConfirmpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }

        }
    }
}
