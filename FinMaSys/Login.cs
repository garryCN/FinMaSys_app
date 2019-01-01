
using FinMaSys.ComClass;
using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinMaSys
{
    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region 判断用户名、密码是否为空,连接数据库验证用户名密码是否正确
            this.UserErrProvider.Clear();
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                try
                {
                    UserErrProvider.SetError(txtUserName,"工号不得为空！");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"错误提示");
                    throw ex;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtUserPassword.Text.Trim()))
                {
                    try
                    {
                        UserErrProvider.SetError(txtUserPassword, "用户密码不得为空！");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "软件提示");
                        throw ex;
                    }
                }
                else
                {
                   string ConStr = "select * from tb_Users where userID= '" + txtUserName.Text.Trim() + "' and password like '" + @txtUserPassword.Text + "'";
                    try
                    {
                        DataBase dataBase = new DataBase();
                        dataBase.ConStr = ConStr;
                        DataTable dt = dataBase.GetDataTable();
                        if (dt.Rows.Count!=0)                        
                        {
                            #region 读取用户名存储为常量进行传递
                            CommonClass.Common_UserID = txtUserName.Text.Trim();
                            CommonClass.Common_User = dt.Rows[0][4].ToString();
                            #endregion
                            #region 记住用户名
                            try
                            {
                                if (cbxRemName.Checked)
                                {
                                    RegistryKey registry = Registry.CurrentUser.CreateSubKey("FinMaSys"); //CreateSubKey建立或读取现有基项下的一级子项
                                    registry.SetValue("UserName", txtUserName.Text.Trim());
                                    registry.Close();
                                }
                                else
                                {
                                    RegistryKey registry = Registry.CurrentUser.CreateSubKey("FinMaSys");
                                    string[] strValueName = registry.GetValueNames();
                                    foreach (var item in strValueName)
                                    {
                                        if (item != null)
                                        {
                                            registry.DeleteValue(item);
                                        }
                                    }
                                    registry.Close();
                                }
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show(ex.Message, "软件提示");
                                throw ex;
                            }
                            #endregion


                            if (Convert.ToInt32(dt.Rows[0][3].ToString())==CommonClass.UserStatusJudg("锁定"))
                            {
                                MessageBox.Show("您已被锁定，请联系管理员解锁！","提示");
                                return;
                            } 
                            else
                            {
	                            this.Hide();
	                            MainForm mainForm = new MainForm();
	                            mainForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("您的用户名或密码输入错误！", "软件提示");
                            txtUserName.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "软件提示");
                        throw ex;
                    }
                }
            }
            
            #endregion
           
        }
        //重置
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserPassword.Text.Trim()))
            {
            	lblPssShowHide.Visible = false; //遮罩控件显示
            }
            else
            {
                lblPssShowHide.Visible = true; //遮罩控件隐藏
            }


        }
        #region 扩展功能
       /// <summary>
        /// 密码遮罩功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPssShowHide_Click(object sender, EventArgs e)
        {
        
            if (lblPssShowHide.Text == "查看密码")
            {
                txtUserPassword.PasswordChar = (char)0;
                lblPssShowHide.Text = "隐藏密码";
            }
            else
            {
                txtUserPassword.PasswordChar = '*';
                lblPssShowHide.Text = "查看密码";
            }
            
        }
       

        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            #region 读取注册表中存储的用户名
            RegistryKey registry = Registry.CurrentUser.CreateSubKey("FinMaSys");
            foreach (var item in registry.GetValueNames())
            {
                if (item!=null)
                {
                    txtUserName.Text = registry.GetValue("UserName").ToString();
                    cbxRemName.Checked = true; //记住用户名选项打勾
                }
            }
            #endregion

        }

        private void lblServerSet_Click(object sender, EventArgs e)
        {
            DbConSet dbConSet = new DbConSet();
            dbConSet.ShowDialog();
        }

        private void txtUserPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                btnLogin_Click(null, null);                
            }
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
