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
    public partial class ContrType : Form
    {
        public ContrType()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();

        private void btnAddBigNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBigType.Text.Trim()))
            {
                MessageBox.Show("大类不得为空！");
                txtBigType.Focus();
                return;
            }
            else
            {
                try
                {
                    dataBase.ConStr = "select * from tb_Contr_BigType where contrBigTypeName='"+txtBigType.Text.Trim()+"'";
                    DataTable dt = dataBase.GetDataTable();
                    
                    if (dt.Rows.Count>0)
                    {
                        MessageBox.Show(string.Format("{0}已存在，请重新输入！",txtBigType.Text.Trim()),"错误提示");
                        txtBigType.Text = "";
                    } 
                    else
                    {
                        dataBase.Cmd = "insert [tb_Contr_BigType] ([contrBigTypeName]) values('" + txtBigType.Text.Trim() + "')";
                        dataBase.DataExcute("Insert");
                        txtBigType.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示");
                    throw ex;
                }
            }
        }

        private void cmsContr_Opened(object sender, EventArgs e)
        {
            修改ToolStripMenuItem.Enabled = true;
            禁用ToolStripMenuItem.Enabled = true;
        }

        


        private void btnAddSmallNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbContrBigType.Text.Trim()))
            {
                if (string.IsNullOrEmpty(txtSmallType.Text.Trim()))
                {
                    MessageBox.Show("合同小类名称不得为空！", "错误提示");
                    txtSmallType.Focus();
                    return;
                }
                else
                {
                    string bigStyle = cbContrBigType.Text.Trim();
                    string smallStyle = txtSmallType.Text.Trim();
                    dataBase.ConStr = "select * from [V_ContrTypes] where [contrBigTypeName]='"+ bigStyle + "' and [contrSmallTypeName]='"+ smallStyle + "'";
                    DataTable dt = dataBase.GetDataTable();
                    if (dt.Rows.Count>0)
                    {
                        MessageBox.Show(string.Format("{0}已存在，请重新输入！",smallStyle),"错误提示");
                    } 
                    else
                    {
                        dataBase.Cmd = "insert into [tb_Contr_SmallType] (contrBigTypeID,contrSmallTypeName,disAble) (select [contrBigTypeID],'" + smallStyle + "','否'  from tb_Contr_BigType where contrBigTypeName='" + bigStyle + "') ";
                        dataBase.DataExcute("Insert");
                        MessageBox.Show("合同小类添加成功！", "提示");
                        txtSmallType.Text = "";
                        cbContrBigType.Text = "";
                        ContrType_Load(null, null);
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择合同大类！", "提示");
                cbContrBigType.Focus();
                return;
            }
        }

        private void ContrType_Load(object sender, EventArgs e)
        {
            dataBase.ConStr = "select contrBigTypeName from [tb_Contr_BigType]";
            DataTable dt = dataBase.GetDataTable();
            if (dt.Rows.Count != 0)
            {
                try
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cbContrBigType.Items.Add(dt.Rows[i][0].ToString());
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示");
                    throw ex;
                }


            }
            dataBase.ConStr = "SELECT contrSmallTypeID '小类编码', contrSmallTypeName '小类名称', contrBigTypeName  '大类名称' FROM [V_ContrTypes]";
            DataTable dt2 = dataBase.GetDataTable();
            try
            {
	             if (dt2.Rows.Count>0)
                 {
                   dgvContrType.DataSource = dt2;
                 }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }

        private void cbContrBigType_Click(object sender, EventArgs e)
        {
            cbContrBigType.Items.Clear();
            ContrType_Load(null, null);
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserEdit contrTypeEdit = new UserEdit();
            contrTypeEdit.Text = "合同类型修改";
            int i = dgvContrType.CurrentRow.Index;
            CommonClass.Select_ContrSmallTypeID = dgvContrType.Rows[i].Cells[0].Value.ToString();
            CommonClass.Select_ContrSmallTypeName = dgvContrType.Rows[i].Cells[1].Value.ToString();
            contrTypeEdit.Show();            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ContrType_Load(null, null);
        }

        private void 禁用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvContrType.CurrentRow.Index;
            string ContrSmallTypeID = dgvContrType.Rows[i].Cells[0].Value.ToString();
            dataBase.Cmd = "UPDATE [tb_Contr_SmallType]    SET [disAble] = '是'    WHERE contrSmallTypeID='"+ ContrSmallTypeID + "'";
            dataBase.DataExcute("Update");
            ContrType_Load(null, null);
        }
    }
}
