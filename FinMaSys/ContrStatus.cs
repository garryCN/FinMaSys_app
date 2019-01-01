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
    public partial class ContrStatus : Form
    {
        public ContrStatus()
        {
            InitializeComponent();
        }

        private void ContrStatus_Load(object sender, EventArgs e)
        {
            try
            {
	            DataBase dataBase = new DataBase();
	            dataBase.ConStr = "SELECT contrStatusID '编码', contrStatusName '合同状态' FROM dbo.tb_Contr_Status";
	            DataTable dt = dataBase.GetDataTable();
	            if (dt.Rows.Count>0)
	            {
	                dgvContrStatus.DataSource = dt;
	            }
	            dataBase.ConStr = "SELECT contrexecstatusid '编码',contrExecStatusName '执行状态' FROM  [tb_Contr_Exec_Status]";
                DataTable dt2 = dataBase.GetDataTable();
	            if (dt.Rows.Count>0)
	            {
	                dgvContrExcStatus.DataSource = dt2;
	
	            }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }

        private void btnStatusSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStatus.Text.Trim()))
            {
                MessageBox.Show("合同状态不得为空，请谨慎填写！");
                return;
            }
            else
            {
                DataBase dataBase = new DataBase();
                dataBase.Cmd = "insert into tb_Contr_Status (contrStatusName) values('"+ txtStatus.Text.Trim()+"')";
                dataBase.DataExcute("Insert");
                MessageBox.Show("合同状态添加成功!", "提示");
                txtStatus.Text = "";
                ContrStatus_Load(null,null);
            }
        }

        private void btnExecStatusSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExecStatus.Text.Trim()))
            {
                MessageBox.Show("合同执行状态不得为空，请谨慎填写！");
                return;
            }
            else
            {
                DataBase dataBase = new DataBase();
                dataBase.Cmd = "insert into [tb_Contr_Exec_Status] (contrExecStatusName) values('" + txtExecStatus.Text.Trim() + "')";
                dataBase.DataExcute("Insert");
                MessageBox.Show("合同执行状态添加成功!", "提示");
                txtExecStatus.Text = "";
                ContrStatus_Load(null, null);
            }
        }
    }
}
