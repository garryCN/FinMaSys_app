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
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private string Flag = null;
        private string DeptID = null;
        private void dgvDept_Click(object sender, EventArgs e)
        {
            tsbDel.Enabled = true;
            tsbEdit.Enabled = true;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            Departments_Load(null, null);
            lblDeptID.Text = "";
            tsbNew.Enabled = true;
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            txtDeptName.Enabled = true;
            cbDeptType.Enabled = true;
            Flag = "Query";
            btnOK.Text = "查询";
            btnOK.Enabled = true;
            txtDeptName.Text = "";
            cbDeptType.Text = "";
            lblDeptID.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCondition = null;
            string strDeptName = txtDeptName.Text.Trim();
            string strDeptType = cbDeptType.Text.Trim();
            switch (Flag)
            {
                default:
                    break;
                case "AddNew":
                    if (string.IsNullOrEmpty(txtDeptName.Text.Trim()))
                    {
                        MessageBox.Show("科室名称不得为空！", "软件提示");
                        txtDeptName.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cbDeptType.Text.Trim()))
                        {
                            MessageBox.Show("科室属性不得为空！", "软件提示");
                            cbDeptType.Focus();
                        }
                        else
                        {
                            DataBase dataBase = new DataBase();
                            dataBase.Cmd = "INSERT INTO [tb_Departments] ([deptProp],[deptName],enableFlag) values('" + strDeptType + "','" + strDeptName + "','否')";
                            dataBase.DataExcute("Insert");
                            MessageBox.Show("保存成功!", "保存提示");
                            btnOK.Enabled = false;
                            txtDeptName.Text = "";
                            cbDeptType.Text = "";
                            txtDeptName.Enabled = false;
                            cbDeptType.Enabled = false;
                        }
                    }
                    break;
                case "Query":

                    if (!string.IsNullOrEmpty(txtDeptName.Text.Trim()) && !string.IsNullOrEmpty(cbDeptType.Text.Trim()))
                    {
                        strCondition = "deptProp = '" + strDeptType + "' and deptName like'%" + strDeptName + "%'";
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtDeptName.Text.Trim()) && string.IsNullOrEmpty(cbDeptType.Text.Trim()))
                        {
                            MessageBox.Show("科室名和属性不得同时为空！");
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtDeptName.Text.Trim()))
                            {
                                if (!string.IsNullOrEmpty(cbDeptType.Text.Trim()))
                                {
                                    strCondition = "deptProp = '" + strDeptType + "'";
                                }
                            }
                            else
                            {
                                strCondition = "deptName like'%" + strDeptName + "%'";
                            }

                        }
                    }
                    try
                    {
                        DataBase dataBase = new DataBase();
                        dataBase.ConStr = "SELECT [deptID] '编码',[deptName] '科室名称',[deptProp] '科室属性'    FROM [tb_Departments] where " + strCondition +"and enableFlag='否'";
                        dgvDept.DataSource = dataBase.GetDataTable();

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "软件提示");
                        throw ex;
                    }
                    break;
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            UserEdit DeptEdit = new UserEdit();
            DeptEdit.Text = "科室修改";
            int i = dgvDept.CurrentRow.Index;
            CommonClass.Select_DeptID = dgvDept.Rows[i].Cells[0].Value.ToString();
            CommonClass.Select_DeptName = dgvDept.Rows[i].Cells[1].Value.ToString();
            DeptEdit.Show();
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            txtDeptName.Enabled = false;
            cbDeptType.Enabled = false;
            tsbDel.Enabled = false;
            tsbEdit.Enabled = false;
            btnOK.Enabled = false;
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = "SELECT [deptID] '编码',[deptName] '科室名称',[deptProp] '科室属性'    FROM [tb_Departments] where enableFlag='否'";
                DataTable db = dataBase.GetDataTable();
                if (db.Rows.Count > 0)
                {
                    dgvDept.DataSource = db;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            txtDeptName.Enabled = true;
            cbDeptType.Enabled = true;
            btnOK.Enabled = true;
            txtDeptName.Text = "";
            cbDeptType.Text = "";
            Flag = "AddNew";
            btnOK.Text = "保存";
            tsbNew.Enabled = false;
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = "select max(deptID)+1 from  tb_Departments";
                DataTable db = dataBase.GetDataTable();
                if (db.Rows.Count > 0)
                {
                    DeptID = db.Rows[0][0].ToString();
                }
                else
                {
                    DeptID = "1";
                }
                lblDeptID.Text = DeptID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }

        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            int i = dgvDept.CurrentRow.Index;
            string strDeptID = dgvDept.Rows[i].Cells[0].Value.ToString();
            DataBase dataBase = new DataBase();
            dataBase.Cmd = "update tb_Departments set enableFlag='是' where deptID='" + strDeptID + "'";
            dataBase.DataExcute("Update");
        }
    }
}
