using FinMaSys.ComClass;
using FinMaSys.ShareForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMaSys
{
    public partial class ContrDo : Form
    {
        public ContrDo()
        {
            InitializeComponent();
        }

        CommonClass common = new CommonClass();

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strContrID= txtContrID.Text.Trim();
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = "select * from v_ContrQueryDo where contrid='" + strContrID + "'";
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count > 0)
                {
                    lblContrID.Text = dt.Rows[0][0].ToString();
                    lblContrName.Text = dt.Rows[0][1].ToString();
                    lblContrSubject.Text = dt.Rows[0][2].ToString();
                    lblContrAmount.Text = dt.Rows[0][3].ToString();
                    lblContrPay.Text = dt.Rows[0][4].ToString();
                    lblContrRePerson.Text = dt.Rows[0][5].ToString();
                    lblContrUser.Text = dt.Rows[0][6].ToString();
                    lblContrTermDate.Text = dt.Rows[0][7].ToString();
                    lblContrDept.Text = dt.Rows[0][9].ToString();
                    txtDemo.Text = dt.Rows[0][8].ToString();
                    #region 权限设置
                    dataBase.ConStr = "SELECT userGroupID  FROM [tb_Users] where userid='"+CommonClass.Common_UserID+"'";
                    DataTable dt_UserGroupID = dataBase.GetDataTable();
                    if (dt_UserGroupID.Rows.Count>0)
                    {
                        CommonClass.Common_UserGroupID = dt_UserGroupID.Rows[0][0].ToString();
                        switch (CommonClass.Common_UserGroupID)
                        {
                            default:
                                btnVerify.Enabled = true;
                                btnAccou.Enabled = true;
                                btnAccount.Enabled = true;
                                break;
                            case "3": //审核人
                                btnVerify.Enabled = true;
                                break;
                            case "4": //会计
                                btnAccou.Enabled = true;
                                break;
                            case "5": //出纳
                                btnAccount.Enabled = true;
                                break;
                            case "6": //合同管理员
                                btnAccount.Enabled = true;
                                btnAccou.Enabled = true;
                                break;
                        }
                    }
                    #endregion
                    VerifyInput(strContrID);
                    AccountInput(strContrID);
                    AccVouInput(strContrID);
                    btnOpenContr.Enabled = true;
                }
                else
                {
                    MessageBox.Show("查询不到该合同信息！","提示");
                    lblContrID.Text = "";
                    lblContrName.Text = "";
                    lblContrSubject.Text = "";
                    lblContrAmount.Text = "";
                    lblContrPay.Text = "";
                    lblContrRePerson.Text = "";
                    lblContrUser.Text = "";
                    lblContrTermDate.Text = "";
                    lblContrDept.Text = "";
                    txtDemo.Text = "";
                    btnVerify.Enabled = false;
                    btnAccount.Enabled = false;
                    btnAccou.Enabled = false;
                    btnOpenContr.Enabled = false;
                    dgvAccou.DataSource = null;
                    dgvAccount.DataSource = null;
                    dgvVerify.DataSource = null;
                }
                //判断合同有无附件
                dataBase.ConStr = "select * from tb_filetable  WHERE	contrID='"+ strContrID + "' AND demo='合同会签表'";
                DataTable dt_contrTrem = dataBase.GetDataTable();
                if (dt_contrTrem.Rows.Count>0)
                {
                    btnContrTerm.Enabled = true;                   
                }
                else
                {
                    btnContrTerm.Enabled = false;

                }
                dataBase.ConStr = "select * from tb_filetable  WHERE	contrID='" + strContrID + "' AND demo='合同扫描件'";
                DataTable dt_OpenContr = dataBase.GetDataTable();
                if (dt_OpenContr.Rows.Count > 0)
                {
                    btnOpenContr.Enabled = true;
                }
                else
                {
                    btnOpenContr.Enabled = false;
                }
                //判断合同有无补充协议
                dataBase.ConStr = @"SELECT [ContrSideID] '补充协议编码' ,[ContrSideContent] '变更内容',[ContrSideDate] '签订日期'   FROM [tb_ContrSide]  where ContrSubID='" + txtContrID.Text.Trim() + "' order by  ContrSideID";
                DataTable dt_contrSide = dataBase.GetDataTable();
                if (dt_contrSide.Rows.Count>0)
                {
                    dgvContrSider.DataSource = dt_contrSide;
                }
                else
                {
                    dgvContrSider.DataSource = null;
                    btnContrSider.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
            txtContrID.SelectAll();

        }

        private void AccountInput(string strContrID)
        {
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "select * from V_ContrAccount where 合同编号='" + strContrID + "'";
            DataTable dt = dataBase.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                dgvAccount.DataSource = dt;
            }
            else
            {
                dgvAccount.DataSource = null;
            }
        }

        private void VerifyInput(string strContrID)
        {
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "select * from v_contrverify where 合同编号='" + strContrID + "'";
            DataTable dt = dataBase.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                dgvVerify.DataSource = dt;
            }
            else
            {
                dgvVerify.DataSource = null;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            string strUserID = CommonClass.Common_UserID;
            string strContrID = lblContrID.Text.Trim();
            try
            {
                dataBase.ConStr = "select * from tb_ContrVerify where contrid='" + strContrID + "'";
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count < 1)
                {
                    dataBase.Cmd = "insert into tb_ContrVerify (userID,verifyDate,contrID) values('" + strUserID + "','" + DateTime.Now.ToLocalTime() + "','" + strContrID + "')";
                    dataBase.DataExcute("Insert");
                    VerifyInput(strContrID);
                    dataBase.Cmd = "update tb_contr_information set contrstatusID='2' where contrID='"+strContrID+"'";
		            dataBase.DataExcute("Update");
	             }
	            else
	            {
	                MessageBox.Show("该合同已审核！","提示");
	            }
	            btnVerify.Enabled = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }

      

        private void txtContrID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                btnQuery_Click(null,null);
            }
        }

        private void ContrDo_Load(object sender, EventArgs e)
        {
            txtContrID.Select();
            btnContrTerm.Enabled = false;
            btnOpenContr.Enabled = false;
            btnVerify.Enabled = false;
            btnAccount.Enabled = false;
            btnAccou.Enabled = false;
            btnContrSider.Enabled = false;
            btnEditAccount.Enabled = false;
            btnEditAccou.Enabled = false;
            if (CommonClass.FlagWinform== "ContrInput")
            {
                txtContrID.Text = CommonClass.ContrID;
                btnQuery_Click(null, null);
                btnVerify.Enabled = false;
                btnAccount.Enabled = false;
                btnAccou.Enabled = false;
                btnEditAccount.Enabled = false;
                btnEditAccou.Enabled = false;
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
           CommonClass.ContrID = lblContrID.Text.Trim();
           DateTime strPayDate = DateTime.Now.ToLocalTime();
            ContrDoMoudle contrDoMoudle = new ContrDoMoudle();
            contrDoMoudle.Text = "合同收付款维护";
            contrDoMoudle.ShowDialog();
            AccountInput(lblContrID.Text.Trim());
            btnAccount.Enabled = false;
        }

        private void btnAccou_Click(object sender, EventArgs e)
        {
            btnAccou.Enabled = false;
            CommonClass.ContrID = lblContrID.Text.Trim();
            string strContrID = lblContrID.Text.Trim();
            DateTime strPayDate = DateTime.Now.ToLocalTime();
            ContrDoMoudle contrDoMoudle = new ContrDoMoudle();
            contrDoMoudle.Text = "合同入账维护";
            contrDoMoudle.ShowDialog();
            AccVouInput(strContrID);

        }

        private void AccVouInput(string strContrID)
        {
            try
            {
                DataBase dataBase = new DataBase();                
                dataBase.ConStr = "select * from V_ContrAccou where 合同编号='" + strContrID + "'";
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count > 0)
                {
                    dgvAccou.DataSource = dt;
                }
                else
                {
                    dgvAccou.DataSource = null;

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void btnOpenContr_Click(object sender, EventArgs e)
        {
            string strContrID = lblContrID.Text.Trim();
            string strQuerySql = "select fileContent,fileName from [tb_FileTable]  WHERE	contrID='" + strContrID + "' AND demo='合同扫描件' ";
            try
            {
                
               common.DwOpen(strContrID, strQuerySql);
                btnOpenContr.Enabled = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }

     

        private void btnContrTerm_Click(object sender, EventArgs e)
        {
            string strContrID = lblContrID.Text.Trim();
            string strQuerySql = "select fileContent,fileName from [tb_FileTable]  WHERE	contrID='" + strContrID + "' AND demo='合同会签表' ";
            try
            {               
              common.DwOpen(strContrID, strQuerySql);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void ContrDo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + @"\temp"))
            {
            	Directory.Delete(Application.StartupPath + @"\temp",true);
            }
            //foreach (Form f1 in Application.OpenForms)
            //{
            //    if (f1.Name == "合同录入")
            //    {
            //        f1.Activate();
            //        f1.Show();
            //    }
            //}
        }

        private void dgvContrSider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnContrSider.Enabled = true;
        }

        private void btnContrSider_Click(object sender, EventArgs e)
        {
            int i = dgvContrSider.CurrentCell.RowIndex;
            string strContrID = dgvContrSider.Rows[i].Cells[0].Value.ToString();
            string strQuerySql = "select fileContent,fileName from [tb_FileTable]  WHERE	contrID='" + strContrID + "' AND demo='补充协议扫描件' ";
            try
            {
                common.DwOpen(strContrID, strQuerySql);
                btnContrSider.Enabled = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void dgvAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditAccount.Enabled = true;

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            int i = dgvAccount.CurrentCell.RowIndex;
            string strContrID = dgvAccount.Rows[i].Cells[1].Value.ToString();
            CommonClass.ContrID = strContrID;
            CommonClass.IdShare = dgvAccount.Rows[i].Cells[0].Value.ToString();
            CommonClass.StateContr = dgvAccount.Rows[i].Cells[3].Value.ToString();
            CommonClass.DateAdd = Convert.ToDateTime(dgvAccount.Rows[i].Cells[2].Value.ToString());
            CommonClass.SumJe = dgvAccount.Rows[i].Cells[4].Value.ToString();
            CommonClass.Demo = dgvAccount.Rows[i].Cells[6].Value.ToString();
            ContrDoMoudle contrDoMoudle = new ContrDoMoudle();
            contrDoMoudle.Text = "合同收付款修改";
            contrDoMoudle.ShowDialog();
            AccountInput(strContrID);
            btnEditAccount.Enabled = false;
        }

        private void btnEditAccou_Click(object sender, EventArgs e)
        {
            int i = dgvAccou.CurrentCell.RowIndex;
            string strContrID = dgvAccou.Rows[i].Cells[1].Value.ToString();
            CommonClass.ContrID = strContrID;
            CommonClass.IdShare = dgvAccou.Rows[i].Cells[0].Value.ToString();
            CommonClass.StateContr = dgvAccou.Rows[i].Cells[2].Value.ToString();
            CommonClass.DateAdd = Convert.ToDateTime(dgvAccou.Rows[i].Cells[4].Value.ToString());
            CommonClass.Demo = dgvAccou.Rows[i].Cells[3].Value.ToString();
            ContrDoMoudle contrDoMoudle = new ContrDoMoudle();
            contrDoMoudle.Text = "合同入账修改";
            contrDoMoudle.ShowDialog();
            AccVouInput(strContrID);
            btnEditAccou.Enabled = false;
        }

        private void dgvAccou_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditAccou.Enabled = true;
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            
            if (dgvAccount.Rows.Count<1)
            {
                MessageBox.Show("记录为空！");
            }
            else
            {
                CommonClass.ExportExcelWithAspose(dgvAccount, @"D:\收付款记录.xls");
            }    
            
        }

        private void btnExcelExportA_Click(object sender, EventArgs e)
        {
            if (dgvAccou.Rows.Count < 1)
            {
                MessageBox.Show("记录为空！");
            }
            else
            {
                CommonClass.ExportExcelWithAspose(dgvAccou, @"D:\入账记录.xls");
            }

        }
    }
}
