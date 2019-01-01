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

namespace FinMaSys.Contr
{
    public partial class ContrSide : Form
    {
        public ContrSide()
        {
            InitializeComponent();
        }
        private string Flag=null;
        private void txtContrId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                if (string.IsNullOrEmpty(txtContrId.Text.Trim()))
                {
                    MessageBox.Show("主合同编码不得为空！","提示");
                }
                else
                {
                    try
                    {
                        string strSql = @"select * from tb_contr_Information where contrid='"+ txtContrId.Text.Trim() +"'";
                        DataBase dataBase = new DataBase();
                        dataBase.ConStr = strSql;
                        DataTable dt_contr = dataBase.GetDataTable();
                        if (dt_contr.Rows.Count!=0)
                        {
                            btnAddNew.Enabled = true;
                            lblContrName.Text = dt_contr.Rows[0]["contrname"].ToString();
                            //查询数据库并生成补充协议编码
                            strSql = @"SELECT [ContrSideID] '补充协议编码' ,[ContrSideContent] '变更内容',[ContrSideDate] '签订日期',[ContrSubID] '所属合同'   FROM [tb_ContrSide]  where ContrSubID='" + txtContrId.Text.Trim() + "' order by  ContrSideID";
                            dataBase.ConStr = strSql;
                            DataTable dt = dataBase.GetDataTable();
                            if (dt.Rows.Count != 0)
                            {
                                dgvConstrSideView.DataSource = dt;
                                int rowID = dgvConstrSideView.Rows.Count - 1;
                                string ContrSideIdDetail = dgvConstrSideView.Rows[rowID].Cells[0].Value.ToString();
                                lblContrSideID.Text = ContrSideIdDetail.Substring(0, 9) + string.Format("{0:d2}", (Convert.ToInt32(ContrSideIdDetail.Substring(9, 2)) + 1)).ToString();

                            }
                            else
                            {
                                dgvConstrSideView.DataSource = null;
                                lblContrSideID.Text = txtContrId.Text.Trim() + "01";
                            }
                            SendKeys.Send("{TAB}");
                            }                        
                    
                        else
                        {
                            MessageBox.Show("该合同不存在！","提示");
                            txtContrId.SelectAll();
                            dgvConstrSideView.DataSource = null;
                            lblContrSideID.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误提示");
                        throw;
                    }

                }
               
            }
        }

        private void ContrSide_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = false;
            txtContrSideContent.Enabled = false;
            dtpSideDate.Enabled = false;
            btnUpload.Enabled = false;
            btnDel.Enabled = false;            
            btnCancel.Enabled = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            CommonClass.ContrID =lblContrSideID.Text.Trim();
            CommonClass.FlagDemo = "补充协议扫描件";
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "select * from tb_Filetable where contrID='" + lblContrSideID.Text.Trim() + "'  and demo='补充协议扫描件'";
            DataTable dt = dataBase.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                string flag = MessageBox.Show("该补充协议已存在，是否重新上传？", "提示", MessageBoxButtons.YesNo).ToString();
                if (flag == "No")
                {
                    return;
                }
                else
                {
                    uploadFiles();
                }

            }
            else
            {
                uploadFiles();
            }

        }

        private void uploadFiles()
        {
            UploadForm uploadForm = new UploadForm();
            uploadForm.ShowDialog();
            btnUpload.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrId.Text.Trim()) || string.IsNullOrEmpty(txtContrSideContent.Text.Trim()))
            {
                MessageBox.Show("合同编码或变更内容不得为空！","错误提示");                
            }
            else
            {
                try
                {
                    DataBase dataBase = new DataBase();
                    string strSql = null;
                    if (Flag=="AddNew")
                    {
                        strSql = "insert into tb_contrside (contrsideid,contrsubid,contrsidecontent,contrsidedate)  values('" + lblContrSideID.Text.Trim() + "','" + txtContrId.Text.Trim() + "','" + txtContrSideContent.Text.Trim() + "','" + dtpSideDate.Value.ToShortDateString() + "')";
                        dataBase.Cmd = strSql;
                        dataBase.DataExcute("Insert");
                    }
                   if(Flag=="Edit")
                    {
                        strSql = "update  tb_contrside  set contrsidecontent='" + txtContrSideContent.Text.Trim()+ "',contrsidedate='" + dtpSideDate.Value.ToShortDateString() + "' where contrsideid='" + lblContrSideID.Text.Trim() +"'";
                        dataBase.Cmd = strSql;
                        dataBase.DataExcute("Update");

                    }
                    strSql = @"SELECT [ContrSideID] '补充协议编码' ,[ContrSideContent] '变更内容',[ContrSideDate] '签订日期',[ContrSubID] '所属合同'   FROM [tb_ContrSide]  where ContrSubID='" + txtContrId.Text.Trim() + "' order by  ContrSideID";
                    dataBase.ConStr = strSql;
                    DataTable dt = dataBase.GetDataTable();
                    if (dt.Rows.Count != 0)
                    {
                        dgvConstrSideView.DataSource = dt;
                    }
                    string flagJudge = MessageBox.Show("数据保存成功,是否继续录入？", "提示", MessageBoxButtons.YesNo).ToString();
                    if (flagJudge == "Yes")
                    {
                        txtContrId.Text = "";
                        txtContrSideContent.Text = "";
                    }
                    else
                    {
                        btnOK.Enabled = false;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示");
                    throw ex;
                }
            }
 
        }

        private void dgvConstrSideView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ContrSide_Load(null, null);
            btnEdit.Enabled = true;
            btnAddNew.Enabled = false;
            btnCancel.Enabled = true;
            btnDel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Flag = "Edit";
            btnOK.Enabled = true;
            txtContrSideContent.Enabled = true;
            btnUpload.Enabled = true;
            dtpSideDate.Enabled = true;
            int i = dgvConstrSideView.CurrentCell.RowIndex;
            txtContrId.Text = dgvConstrSideView.Rows[i].Cells[3].Value.ToString();
            //禁止修改主合同编码
            txtContrId.Enabled = false;
            lblContrSideID.Text = dgvConstrSideView.Rows[i].Cells[0].Value.ToString();
            txtContrSideContent.Text = dgvConstrSideView.Rows[i].Cells[1].Value.ToString();
            dtpSideDate.Value = Convert.ToDateTime(dgvConstrSideView.Rows[i].Cells[2].Value.ToString());
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtContrSideContent.Enabled = true;
            dtpSideDate.Enabled = true;
            btnUpload.Enabled = true;
            btnOK.Enabled = true;
            btnAddNew.Enabled = false;
            btnCancel.Enabled = true;
            Flag = "AddNew";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ContrSide_Load(null, null);
            btnAddNew.Enabled = true;      
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int i = dgvConstrSideView.CurrentCell.RowIndex;
            string contrSideCode = dgvConstrSideView.Rows[i].Cells[0].Value.ToString();
            string flag = MessageBox.Show(string.Format("确认要删除编号为{0}的合同？", contrSideCode),"提示",MessageBoxButtons.YesNo).ToString();
            if (flag == "Yes")
            {

                try
                {
                    DataBase dataBase = new DataBase();
                    dataBase.Cmd = "delete from tb_contrside where ContrSideID='" + contrSideCode + "'";
                    dataBase.DataExcute("Delete");
                    dataBase.Cmd = "delete from tb_FileTable where contrid='" + contrSideCode + "'";
                    dataBase.DataExcute("Delete");
                    string strSql = @"SELECT [ContrSideID] '补充协议编码' ,[ContrSideContent] '变更内容',[ContrSideDate] '签订日期',[ContrSubID] '所属合同'   FROM [tb_ContrSide]  where ContrSubID='" + txtContrId.Text.Trim() + "' order by  ContrSideID";
                    dataBase.ConStr = strSql;
                    DataTable dt = dataBase.GetDataTable();
                    if (dt.Rows.Count != 0)
                    {
                        dgvConstrSideView.DataSource = dt;
                    }
                    else
                    {
                        dgvConstrSideView.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示");
                    throw;
                } 
            }
        }
    }
    }

