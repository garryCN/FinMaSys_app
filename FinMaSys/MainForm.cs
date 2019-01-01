using FinMaSys.Assist;
using FinMaSys.ComClass;
using FinMaSys.Contr;
using FinMaSys.Invoice;
using FinMaSys.ShareForm;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 系统菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);        
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0); //告诉程序所有线程执行完毕，关闭。
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
            tlStripCurrentUsr.Text = "当前用户为:"+CommonClass.Common_UserID+" "+CommonClass.Common_User;
            timer1.Start();

            DataBase dataBase = new DataBase();
            dataBase.ConStr = "select [userGroupID]   FROM [tb_Users] where userid='"+ CommonClass.Common_UserID + "'";
            DataTable dt = dataBase.GetDataTable();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    CommonClass.Common_UserGroupID = dt.Rows[0][0].ToString();
                    GetPowers(CommonClass.Common_UserGroupID); //权限设置
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw;
            }

        }
        #region  权限管理
        private void GetPowers(string UserGroup)
        {
            UserGroup = CommonClass.Common_UserGroupID;
            switch (UserGroup)
            {
                default:
                    break;
                case "2": //合同录入员
                    用户管理ToolStripMenuItem.Enabled = false;
                    权限管理ToolStripMenuItem.Enabled = false;
                    参数设置ToolStripMenuItem.Enabled = false;
                    数据备份ToolStripMenuItem.Enabled = false;
                    登陆日志ToolStripMenuItem.Enabled = false;
                    合同审核ToolStripMenuItem.Enabled = false;
                    break;
                case "3": //审核人
                    用户管理ToolStripMenuItem.Enabled = false;
                    权限管理ToolStripMenuItem.Enabled = false;
                    参数设置ToolStripMenuItem.Enabled = false;
                    数据备份ToolStripMenuItem.Enabled = false;
                    登陆日志ToolStripMenuItem.Enabled = false;
                    客商管理ToolStripMenuItem.Enabled = false;
                    科室管理ToolStripMenuItem.Enabled = false;
                    分类设置ToolStripMenuItem.Enabled = false;
                    状态设置ToolStripMenuItem.Enabled = false;
                    合同录入ToolStripMenuItem.Enabled = false;
                    合同归档ToolStripMenuItem.Enabled = false;
                    break;
                case "4": //会计
                    用户管理ToolStripMenuItem.Enabled = false;
                    权限管理ToolStripMenuItem.Enabled = false;
                    参数设置ToolStripMenuItem.Enabled = false;
                    数据备份ToolStripMenuItem.Enabled = false;
                    登陆日志ToolStripMenuItem.Enabled = false;
                    分类设置ToolStripMenuItem.Enabled = false;
                    状态设置ToolStripMenuItem.Enabled = false;
                    合同录入ToolStripMenuItem.Enabled = false;
                    合同归档ToolStripMenuItem.Enabled = false;

                    break;
                case "5": //出纳
                    用户管理ToolStripMenuItem.Enabled = false;
                    权限管理ToolStripMenuItem.Enabled = false;
                    参数设置ToolStripMenuItem.Enabled = false;
                    数据备份ToolStripMenuItem.Enabled = false;
                    登陆日志ToolStripMenuItem.Enabled = false;
                    分类设置ToolStripMenuItem.Enabled = false;
                    状态设置ToolStripMenuItem.Enabled = false;
                    合同录入ToolStripMenuItem.Enabled = false;
                    合同归档ToolStripMenuItem.Enabled = false;
                    break;
                case "6": //合同管理员
                    用户管理ToolStripMenuItem.Enabled = false;
                    权限管理ToolStripMenuItem.Enabled = false;
                    参数设置ToolStripMenuItem.Enabled = false;
                    数据备份ToolStripMenuItem.Enabled = false;
                    登陆日志ToolStripMenuItem.Enabled = false;
                    break;

            }
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tlStripCurrentTime.Text = "现在时间：" + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassWord passWord = new PassWord();
            passWord.ShowDialog();
        }

        private void 系统管理ToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {



        }

        private void 合同录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrInput contrInput = new ContrInput();
            contrInput.ShowDialog();
        }

        private void 客商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrRePerson contrRePerson = new ContrRePerson();
            contrRePerson.ShowDialog();
        }

        private void 科室管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments department  = new Departments();         
            department.Show();
        }

        private void 分类设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrType contrType = new ContrType();
            contrType.Show();
        }

        private void 状态设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrStatus contrStatus = new ContrStatus();
            contrStatus.Show();
        }

        private void 合同审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClass.FlagWinform = "";
            ContrDo contrDo = new ContrDo();
            contrDo.ShowDialog();
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerGroup powerGroup = new PowerGroup();
            powerGroup.ShowDialog();
        }

        private void 参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parameter parameter = new Parameter();
            parameter.ShowDialog();
        }

        private void 单位管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrRePerson company = new ContrRePerson();
            company.Text = "单位管理";
            company.ShowDialog();
        }

        private void 基础信息导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportFrm importFrm = new ImportFrm();
            importFrm.Show();
        }

        private void 用户切换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            
        }

        private void 补充协议管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrSide contrSide = new ContrSide();
            contrSide.ShowDialog();
        }

        private void 发票录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMain invMain = new InvMain();
            invMain.Show();
        }

        private void 条形码生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeBar code = new CodeBar();
            code.Show();
        }
    }
}
