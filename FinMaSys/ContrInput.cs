using FinMaSys.ComClass;
using System;
using System.Data;
using System.Windows.Forms;

namespace FinMaSys
{
    public partial class ContrInput : Form
    {
        public ContrInput()
        {
            InitializeComponent();
        }


        
        private void ContrInput_Load(object sender, EventArgs e)
        {
            gbContrInfo.Enabled = false;
            tsbDel.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "SELECT [编号],[合同编码],[合同名称],[标的],[金额],[合同相对人],[支付方式],[签订日期],[科室],[合同期限],[合同小类],[合同大类],[合同状态],[备注],[登记日期] FROM [V_ContrQueryInfo]";

            try
            {
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count > 0)
                {
                    dgvContrInfo.DataSource = dt;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            gbContrInfo.Enabled = true;
            tsbCancel.Enabled = true;
           
            string contrCode_Tail = null;
            DataBase dataBase = new DataBase();
            if (cbCondition.Visible)
            {
	            cbCondition.Visible = false;
	            txtQueryContent.Visible = false;
            }
            dataBase.ConStr = "select contrID FROM dbo.tb_Contr_Information WHERE LEFT(CONVERT(VARCHAR(10),contrEnrollDate,112),6)=LEFT(CONVERT(VARCHAR(10),GETDATE(),112),6) ";
            DataTable dt = dataBase.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                dataBase.ConStr = "select max(contrID) FROM dbo.tb_Contr_Information WHERE LEFT(CONVERT(VARCHAR(10),contrEnrollDate,112),6)=LEFT(CONVERT(VARCHAR(10),GETDATE(),112),6)";
                DataTable dt2 = dataBase.GetDataTable();
                contrCode_Tail =  (Convert.ToInt32(dt2.Rows[0][0])+1).ToString();               

            }
            else
            {
                contrCode_Tail = DateTime.Now.ToString("yyyyMM") + "001";
                //MessageBox.Show(contrCode_Tail);
            }
            txtContrName.Focus();
            lblContrID.Text = contrCode_Tail;
            qrCodeImg.Text = contrCode_Tail;
            lblQrcode.Text = contrCode_Tail;
            tsbSave.Enabled = true;
            tsbAddNew.Enabled = false;

            tsbQuery.Enabled = false;
            tsbImport.Enabled = false;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            #region 填写控制 
            epContrInfo.Clear();
            if (string.IsNullOrEmpty(txtContrName.Text.Trim()))
            {
                epContrInfo.SetError(txtContrName, "合同名称不得为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtContrSubject.Text.Trim()))
            {
                epContrInfo.SetError(txtContrSubject,"合同标的不得为空!");
                return;
            }
            if (string.IsNullOrEmpty(txtContrAmount.Text.Trim()))
            {
                epContrInfo.SetError(txtContrAmount,"合同金额不得为空，可按合同期限折算！");
                return;
            }
            if (string.IsNullOrEmpty(cbRePersID.Text.Trim()))
            {
                epContrInfo.SetError(cbRePersID,"合同相对方为必填项！");
                return;
            }
            if (string.IsNullOrEmpty(cbContrPayMethod.Text.Trim()))
            {
                epContrInfo.SetError(cbContrPayMethod, "请选择付款方式！");
                return;
            }
            if (string.IsNullOrEmpty(cbDeptName.Text.Trim()))
            {
                epContrInfo.SetError(cbDeptName, "请选择经办科室！");
                return;
            }
            if (string.IsNullOrEmpty(txtContrTerm.Text.Trim()))
            {
                epContrInfo.SetError(txtContrTerm, "合同期限为必填项！");
                return;
            }
            if (string.IsNullOrEmpty(cbContrBigType.Text.Trim()))
            {
                epContrInfo.SetError(cbContrBigType, "合同大类为必选项！");
                return;
            }
            if (string.IsNullOrEmpty(cbContrSmallType.Text.Trim()))
            {
                epContrInfo.SetError(cbContrSmallType, "合同小类为必选项！");
                return;
            }
            if (string.IsNullOrEmpty(cbContrStatusID.Text.Trim()))
            {
                epContrInfo.SetError(cbContrStatusID, "合同状态为必选项！");
                return;
            }
            #endregion
            #region 保存到数据库
            string DeptID=null, ReperonID=null, ContrStatusID = null, SmallTypeID = null;
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = "SELECT  tb_Contr_RePerson.RePersID, tb_Departments.deptID, tb_Contr_Status.contrStatusID, tb_Contr_SmallType.contrSmallTypeID FROM tb_Departments CROSS JOIN   tb_Contr_RePerson CROSS JOIN  tb_Contr_Status CROSS JOIN    tb_Contr_SmallType WHERE(tb_Departments.deptName = '" + cbDeptName.Text.Trim() + "') AND(tb_Departments.enableFlag = '否') AND  (tb_Contr_RePerson.rePersonName = '" + cbRePersID.Text.Trim() + "') AND(tb_Contr_RePerson.enableFlag = '否') AND  (tb_Contr_Status.contrStatusName = '" + cbContrStatusID.Text.Trim() + "') AND(tb_Contr_SmallType.contrSmallTypeName = '" + cbContrSmallType.Text.Trim() + "') AND (tb_Contr_SmallType.disAble = '否')";                
                DataTable dt = dataBase.GetDataTable();
                try
                {
                    if (dt.Rows.Count > 0)
                    {
	                    ReperonID = dt.Rows[0][0].ToString();
	                    DeptID = dt.Rows[0][1].ToString();
	                    ContrStatusID = dt.Rows[0][2].ToString();
	                    SmallTypeID = dt.Rows[0][3].ToString();
	                }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message,"错误提示");
                    throw ex;
                }
                dataBase.Cmd = "INSERT INTO [tb_Contr_Information] ([contrID],[contrExecStatusID],[deptID],[RePersID],[contrStatusID],[contrSmallTypeID],[contrName],[contrSubject],[contrAmount],[contrPayMethod],[contrSignDate],[contrTerm],[contrEnrollDate],[contrDemo]) VALUES('" + lblContrID.Text.Trim() + "','1','" + DeptID + "','"+ ReperonID + "','"+ ContrStatusID + "','"+ SmallTypeID + "','"+ txtContrName.Text.Trim()+ "','"+ txtContrSubject.Text.Trim()+ "',"+ Decimal.Parse(txtContrAmount.Text.Trim())+ " ,'"+ cbContrPayMethod.Text.Trim()+ "','"+ dtpContrSignDate.Value.ToShortDateString()+ "','"+ txtContrTerm.Text.Trim()+ "','"+DateTime.Now.ToLocalTime()+"','"+ rtbDemo.Text.Trim()+ "')";
                dataBase.DataExcute("Insert");
                MessageBox.Show("合同信息保存成功！","提示");
                ContrInput_Load(null, null);
                tsbAddNew.Enabled = true;
                tsbQuery.Enabled = true;
                tsbImport.Enabled = true;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
            #endregion
        }

        private void txtContrName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtContrSubject_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtContrAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbRePersID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbContrPayMethod_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpContrSignDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbDeptName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtContrTerm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbContrBigType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbContrSmallType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbContrStatusID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtContrTermTable_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnContrTerm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtContrFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnContrFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbRePersID_Click(object sender, EventArgs e)
        {
            cbRePersID.Items.Clear();
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = "SELECT [rePersonName]  FROM [tb_Contr_RePerson] WHERE [enableFlag]='否' ";
	            DataTable dt = dataBase.GetDataTable();
	            if (dt.Rows.Count>0)
	            {
	                for (int i = 0; i < dt.Rows.Count; i++)
	                {
	                    cbRePersID.Items.Add(dt.Rows[i][0].ToString());
	                }
	                
	            }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }
        
        private void cbDeptName_Click(object sender, EventArgs e)
        {
            cbDeptName.Items.Clear();
            DataBase dataBase = new DataBase();
            dataBase.ConStr = @"SELECT [deptName] FROM [dbo].[tb_Departments] WHERE  [enableFlag]='否'";
            DataTable dt = dataBase.GetDataTable();
            try
            {
	            if (dt.Rows.Count>0)
	            {
	                for (int i = 0; i < dt.Rows.Count; i++)
	                {
	                    cbDeptName.Items.Add(dt.Rows[i][0].ToString());
	                }
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
            epContrInfo.Clear();
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "SELECT  contrBigTypeName  FROM [tb_Contr_BigType]";
            DataTable dt = dataBase.GetDataTable();
            try
            {
                if (dt.Rows.Count>0)
	            {
	                for (int i = 0; i < dt.Rows.Count; i++)
	                {
	                    cbContrBigType.Items.Add(dt.Rows[i][0].ToString());
	                }
	            }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void cbContrSmallType_Click(object sender, EventArgs e)
        {
            cbContrSmallType.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(cbContrBigType.Text.Trim()))
                {
                    epContrInfo.Clear();
                    epContrInfo.SetError(cbContrBigType,"合同大类型必须选择！");
                    return;
                }
                else
                {
                    DataBase dataBase = new DataBase();
                    dataBase.ConStr = "SELECT   contrSmallTypeName FROM [tb_Contr_SmallType] WHERE contrBigTypeID=(SELECT contrBigTypeID FROM dbo.tb_Contr_BigType WHERE contrBigTypeName='"+cbContrBigType.Text.Trim() +"')";
                    DataTable dt = dataBase.GetDataTable();
                    if (dt.Rows.Count>0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cbContrSmallType.Items.Add(dt.Rows[i][0].ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void cbUserName_Click(object sender, EventArgs e)
        {
            cbUserName.Items.Clear();
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = "SELECT userName FROM dbo.tb_Users";
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count>0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //for (int j = 0; j < dt.Columns.Count; j++)
                        //{
                            
                            cbUserName.Items.Add(dt.Rows[i][0].ToString());

                        //}
                    }
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void cbContrStatusID_Click(object sender, EventArgs e)
        {
            cbContrStatusID.Items.Clear();
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = "SELECT contrStatusName FROM [tb_Contr_Status]";
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count>0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cbContrStatusID.Items.Add(dt.Rows[i][0].ToString());
                    }
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
        }

        private void btnContrTerm_Click(object sender, EventArgs e)
        {
            CommonClass.ContrID = lblContrID.Text.Trim();
            CommonClass.FlagDemo = "合同会签表";
            UploadForm uploadForm = new UploadForm();
            uploadForm.ShowDialog();
            btnContrTerm.Enabled = false;
        }

        private void btnContrFile_Click(object sender, EventArgs e)
        {
            CommonClass.ContrID = lblContrID.Text.Trim();
            CommonClass.FlagDemo = "合同扫描件";
            UploadForm uploadForm = new UploadForm();
            uploadForm.ShowDialog();
            btnContrFile.Enabled = false;
           
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            cbCondition.Visible = true;
            txtQueryContent.Visible = true;
            tsbCancel.Enabled = true;
            tsbAddNew.Enabled = false;
            tsbImport.Enabled = false;
        }

        private void dgvContrInfo_Click(object sender, EventArgs e)
        {
            tsbDel.Enabled = true;
            tsbPrint.Enabled = true;
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            ContrInput_Load(null, null);
            tsbAddNew.Enabled = true;
            tsbQuery.Enabled = true;
            tsbImport.Enabled = true;
            if (cbCondition.Visible)
            {
                cbCondition.Visible = false;
                txtQueryContent.Visible = false;
                cbCondition.Text = "";
                txtQueryContent.Text = "";
            }
        }

        private void cbCondition_TextChanged(object sender, EventArgs e)
        {
            if (cbCondition.Text.Trim() == "签订日期小于" || cbCondition.Text.Trim() == "签订日期大于")
            {
                dtpQueryDate.Visible = true;
                txtQueryContent.Visible = false;
            }
            else
            {
                dtpQueryDate.Visible = false;
                txtQueryContent.Visible = true;
                txtQueryContent.Focus();
                txtQueryContent.Text = "";
            }

        }

        private void txtQueryContent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                DataBase dataBase = new DataBase();
                string strQuery = cbCondition.Text.Trim();
                string strContent = txtQueryContent.Text.Trim();
                switch (strQuery)
                {
                    default:
                        break;
                    case "合同编码":
                        
                        dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 合同编码='"+ strContent + "'";
                        break;
                    case "合同名称":
                        
                        dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 合同名称 like'%" + strContent + "%'";
                        break;
                    case "合同相对方":
                       
                        dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 合同相对人 like'%" + strContent + "%'";
                        break;
                    case "合同标的":
                        
                        dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 标的 like'%" + strContent + "%'";
                        break;

                    case "付款方式":
                        
                        dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 支付方式 like'%" + strContent + "%'";
                        break;
                    case "合同大类":
                      
                        dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 合同大类 like'%" + strContent + "%'";
                        break;
                    case "合同小类":
                      
                        dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 合同小类 like'%" + strContent + "%'";
                        break;
                        //增加用户后解锁此条代码（包括合同信息视图查询）
                        //case "经办人":
                        
                    //    dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 经办人 like'%" + strContent + "%'";
                    //    break;
                    case "合同状态":
                        
                        dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 合同状态 like'%" + strContent + "%'";
                        break;               

                }
                try
                {
                    DataTable dt = dataBase.GetDataTable();
                    if (dt.Rows.Count>0)
                    {
                        dgvContrInfo.DataSource = dt;
                    }
                    else
                    {
                        dgvContrInfo.DataSource = null;
                        MessageBox.Show("查不到该条合同信息！","提示");
                        cbCondition.Focus();                   
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"错误提示");
                    throw ex;
                }
            }
        }

        private void dtpQueryDate_ValueChanged(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            switch (cbCondition.Text.Trim())
            {
                default:
                    break;
                case "签订日期大于":

                    dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 签订日期 >'" + dtpQueryDate.Value.ToShortDateString() + "'";
                    break;
                case "签订日期小于":

                    dataBase.ConStr = "select * from  [dbo].[V_ContrQueryInfo] where 签订日期 <'" + dtpQueryDate.Value.ToShortDateString() + "'";
                    break;
            }
            DataTable dt = dataBase.GetDataTable();
            if (dt.Rows.Count>0)
            {
                dgvContrInfo.DataSource = dt;
            }
            else
            {
                dgvContrInfo.DataSource = null;
                MessageBox.Show("未查到该信息！","提示");
            }
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            int i = dgvContrInfo.CurrentRow.Index;
            string strContrID = dgvContrInfo.Rows[i].Cells[1].Value.ToString();
            try
            {
	            DataBase dataBase = new DataBase();
                dataBase.ConStr = "select * from tb_Contr_Information where contrid='" + strContrID + "'and [contrStatusID]=1";
                DataTable dt1 = dataBase.GetDataTable();
	            if (dt1.Rows.Count>0)
                {
	                dataBase.Cmd = "DELETE FROM [tb_Contr_Information] where [contrID]='"+ strContrID + "'";
		            dataBase.DataExcute("Delete");
		            dataBase.ConStr = "select * from [tb_FileTable] where contrID='" + strContrID + "'";
		            DataTable dt2 = dataBase.GetDataTable();
		           if (dt2.Rows.Count>0)
		           {
		                dataBase.Cmd = "DELETE FROM [tb_FileTable] where [contrID]='" + strContrID + "'";
		                dataBase.DataExcute("Delete");
		           }
		            MessageBox.Show(string.Format("合同号为{0}的信息已删除！", strContrID), "提示");
		            ContrInput_Load(null, null);
                } 
                else
                {
                    MessageBox.Show("该合同存在执行数据，无法删除！","提示");
                    return;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            QueryPrintForm queryPrintForm = new QueryPrintForm();
            queryPrintForm.ShowDialog();
        }
    }
}
