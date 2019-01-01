
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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
	            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
	                        {
	                            Users_Load(null,null);
	                        }
	                        else
	                        {
	                            string strUserId = txtUser.Text.Trim();
	                            DataBase dataBase = new DataBase();
	                            dataBase.ConStr = "select * from v_UserInfo where 工号='"+ strUserId + "' ";
	                            DataTable dt = dataBase.GetDataTable();
	                            if (dt.Rows.Count!=0)
	                            {
	                                dgUserList.DataSource = dt;
	                            }
	                            else
	                            {
	                                MessageBox.Show("查无此人！","查询提示");
                                    txtUser.Text = "";
	                            }
	
	                        }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }

        private void TxtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                BtnQuery_Click(null,null);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            string conStr = "select * from v_UserInfo"; //查询用户视图（用户信息表、用户分组表、用户状态表联合查询）
            dataBase.ConStr = conStr;
            dgUserList.DataSource = dataBase.GetDataTable();

        }

        private void 禁用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgUserList.CurrentRow.Index;
            try
            {
                string userID = dgUserList.Rows[i].Cells[1].Value.ToString();
                DataBase dataBase = new DataBase();
                dataBase.Cmd = "UPDATE tb_Users SET [StatusID] =3  where  userid='" + userID + "'";
                dataBase.DataExcute("Update");
                MessageBox.Show("该用户已被禁用", "禁用提示");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserEdit userAdd = new UserEdit();
            userAdd.Text = "用户新增";
            userAdd.Show();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i =dgUserList.CurrentRow.Index;
            CommonClass.Select_UserID = dgUserList.Rows[i].Cells[1].Value.ToString();
            CommonClass.Select_User= dgUserList.Rows[i].Cells[2].Value.ToString();
            UserEdit userEdit = new UserEdit();
            userEdit.Text = "用户修改";
            userEdit.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Users_Load(null, null);
        }

        private void 恢复默认密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgUserList.CurrentRow.Index;
            try
            {
            	string userID= dgUserList.Rows[i].Cells[1].Value.ToString();
                DataBase dataBase = new DataBase();
                dataBase.Cmd = "UPDATE tb_Users SET [password] ='888'  where  userid='" + userID + "'";
                dataBase.DataExcute("Update");
                MessageBox.Show("密码已恢复为888","密码修改提示");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
            
        }

        private void cmsUserEdit_Opened(object sender, EventArgs e)
        {
            int i = dgUserList.CurrentRow.Index;
            string flag = dgUserList.Rows[i].Cells[4].Value.ToString();
            if (flag=="正常")
            {
            	禁用ToolStripMenuItem.Visible = true;
                解锁toolStripMenuItem.Visible = false;
            } 
            else
            {
                禁用ToolStripMenuItem.Visible = false;
                解锁toolStripMenuItem.Visible = true;
            }
        }

        private void 解锁toolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgUserList.CurrentRow.Index;
            try
            {
                string userID = dgUserList.Rows[i].Cells[1].Value.ToString();
                DataBase dataBase = new DataBase();
                dataBase.Cmd = "UPDATE tb_Users SET [StatusID] =2  where  userid='" + userID + "'";
                dataBase.DataExcute("Update");
                MessageBox.Show("该用户已解锁", "解锁提示");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }
    }
}
