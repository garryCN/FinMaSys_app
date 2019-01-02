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
    public partial class ContrRePerson : Form
    {
        public ContrRePerson()
        {
            InitializeComponent();
        }

        private string RePersonID,RePersonName, RePersonType,Flag;

        private void ContrRePerson_Load(object sender, EventArgs e)
        {
            txtRePersonName.Enabled = false;
            cbRePersonType.Enabled = false;
            tsbDel.Enabled = false;
            tsbEdit.Enabled = false;
            btnOK.Enabled = false;
            try
            {
	            DataBase dataBase = new DataBase();
                dataBase.ConStr = "select repersid '编码',repersontype '类型',repersonname '名称' ,rePersonOpenBank '开户行',rePersonAccNum '帐号' from tb_contr_RePerson where enableFlag='否'";
                DataTable db = dataBase.GetDataTable();
                if (db.Rows.Count > 0)
                {
                    dgvRePerson.DataSource = db;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }



        private void tsbNew_Click(object sender, EventArgs e)
        {
            txtRePersonName.Enabled = true;
            cbRePersonType.Enabled = true;
            btnOK.Enabled = true;
            txtRePersonName.Text="";
            cbRePersonType.Text= "";
            Flag = "AddNew";
            btnOK.Text = "保存";
            tsbNew.Enabled = false;
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = "select max(RePersID)+1 from  tb_Contr_RePerson";
                DataTable db = dataBase.GetDataTable();
                if (db.Rows.Count>0)
                {
                    RePersonID =db.Rows[0][0].ToString();                  
                }
                else
                {
                    RePersonID = "1";
                }
                lblRePersonID.Text = RePersonID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
           
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            UserEdit RePersonEdit = new UserEdit();
            RePersonEdit.Text = "客商修改";           
            int i = dgvRePerson.CurrentRow.Index;
            CommonClass.Select_RePersonID = dgvRePerson.Rows[i].Cells[0].Value.ToString();
            CommonClass.Select_RePersonType = dgvRePerson.Rows[i].Cells[1].Value.ToString();
            CommonClass.Select_RePesonName = dgvRePerson.Rows[i].Cells[2].Value.ToString();
            CommonClass.Select_OpenBank = dgvRePerson.Rows[i].Cells[3].Value.ToString();
            CommonClass.Select_tbAccNum = dgvRePerson.Rows[i].Cells[4].Value.ToString();
            RePersonEdit.Show();
        }

        private void dgvRePerson_Click(object sender, EventArgs e)
        {
            tsbDel.Enabled = true;
            tsbEdit.Enabled = true;
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            int i = dgvRePerson.CurrentRow.Index;
            string rePersonID= dgvRePerson.Rows[i].Cells[0].Value.ToString();
            DataBase dataBase = new DataBase();
            dataBase.Cmd = "update tb_Contr_RePerson set enableFlag='是' where RePersID='"+ rePersonID +"'";
            dataBase.DataExcute("Update");
        }

        private void dgvRePerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CommonClass.FlagWinform=="发票录入")
            {
                int i = dgvRePerson.CurrentRow.Index;
                CommonClass.Select_RePersonID = dgvRePerson.Rows[i].Cells[0].Value.ToString();
                CommonClass.Select_RePesonName = dgvRePerson.Rows[i].Cells[2].Value.ToString();
                this.Close();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            ContrRePerson_Load(null, null);
            lblRePersonID.Text = "";
            tsbNew.Enabled = true;

        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            txtRePersonName.Enabled = true;
            cbRePersonType.Enabled = true;
            Flag = "Query";
            btnOK.Text = "查询";
            btnOK.Enabled = true;
            txtRePersonName.Text = "";
            cbRePersonType.Text = "";
            lblRePersonID.Text = "";
            tsbQuery.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCondition = null;
            RePersonName = txtRePersonName.Text.Trim();
            RePersonType = cbRePersonType.Text.Trim();
            switch (Flag)
            {
                default:
                    break;
                case "AddNew":
                    if (string.IsNullOrEmpty(txtRePersonName.Text.Trim()))
                    {
                        MessageBox.Show("客商名称不得为空！","软件提示");
                        txtRePersonName.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cbRePersonType.Text.Trim()))
                        {
                            MessageBox.Show("客商类型不得为空！", "软件提示");
                            cbRePersonType.Focus();
                        }
                        else
                        {
                            string strRePersonName = txtRePersonName.Text.Trim();
                            string strRePersonType = cbRePersonType.Text.Trim();
                            string strOpenBank= tbOpenBank.Text.Trim();
                            string strAccNum= tbAccNum.Text.Trim();
                            DataBase dataBase = new DataBase();
                            dataBase.ConStr =string.Format(@"select * from [tb_Contr_RePerson] where rePersonName='{0}' and [enableFlag]='否'", strRePersonName);
                            DataTable dt = dataBase.GetDataTable();                            
                            if (dt.Rows.Count>0)
                           {
                                MessageBox.Show("该客商已存在，请核实！", "保存失败");
                            } 
                           else
                           {
                                dataBase.Cmd = "INSERT INTO tb_Contr_RePerson (rePersonType,rePersonName,enableFlag,rePersonOpenBank,rePersonAccNum) values('" + strRePersonType + "','" + strRePersonName + "','否','" + strOpenBank + "','" + strAccNum + "')";
                                dataBase.DataExcute("Insert");
                                MessageBox.Show("保存成功!", "保存提示");
                                btnOK.Enabled = false;
                                txtRePersonName.Text = "";
                                cbRePersonType.Text = "";
                                tbAccNum.Text = "";
                                tbOpenBank.Text = "";
                                txtRePersonName.Enabled = false;
                                cbRePersonType.Enabled = false;
                            }
                        }
                    }

                    break;
                case "Query":
                    
                    if (!string.IsNullOrEmpty(txtRePersonName.Text.Trim()) && !string.IsNullOrEmpty(cbRePersonType.Text.Trim()))
                    {
                        strCondition = "repersontype = '" + RePersonType + "' and repersonname like'%" + RePersonName + "%'";
                        tsbQuery.Enabled = true;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtRePersonName.Text.Trim()) && string.IsNullOrEmpty(cbRePersonType.Text.Trim()))
                        {
                            MessageBox.Show("客商名和类型不得同时为空！");
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtRePersonName.Text.Trim()))
                            {
                                if (!string.IsNullOrEmpty(cbRePersonType.Text.Trim()))
                                {
                                    strCondition = "repersontype = '" + RePersonType + "'";
                                }
                            }
                           else
                            {
                                    strCondition = "repersonname like'%" + RePersonName + "%'";                                                            
                            }
                            
                        }
                    }
                    try
                    {
                        DataBase dataBase = new DataBase();
                        dataBase.ConStr = "select repersid '编码',repersontype '类型',repersonname '名称' ,rePersonOpenBank '开户行',rePersonAccNum '帐号'  from tb_contr_RePerson  where " + strCondition+ "and enableFlag='否'";
                        dgvRePerson.DataSource = dataBase.GetDataTable();
                        
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "软件提示");
                        throw ex;
                    }
                    break;
            }
        }

    }
}
