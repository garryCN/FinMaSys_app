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


        private string Flag = null;
        private void ContrInput_Load(object sender, EventArgs e)
        {
            gbContrInfo.Enabled = false;
            tsbDel.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            tsbScanFiles.Enabled = false;
            DataBase dataBase = new DataBase();            
            dataBase.ConStr = "select top 50 [合同编码],[合同名称],[标的],[金额],[合同相对人],[签约单位],[支付方式],[签订日期],[科室],[合同期限],[合同小类],[合同大类],[合同状态],[经办人],[备注],[登记日期] FROM [V_ContrQueryInfo] order by 登记日期 desc";

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
            Flag = "Insert";
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
            }
            txtContrName.Focus();
            lblContrID.Text = contrCode_Tail;
            tsbSave.Enabled = true;
            tsbAddNew.Enabled = false;
            cbContrStatusID.Text = "未执行";
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
            DataBase dataBase = new DataBase();
            string DeptID = null, ReperonID = null, ContrStatusID = null, SmallTypeID = null;
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
                    MessageBox.Show(ex.Message, "错误提示");
                    throw ex;
                }
                        
	            try
	            {
                    if (Flag=="Insert")
                    {
	                    dataBase.Cmd = "INSERT INTO [tb_Contr_Information] ([contrID],[contrExecStatusID],[deptID],[RePersID],[TermComp],[contrStatusID],[contrSmallTypeID],[contrName],[contrSubject],[contrAmount],[contrPayMethod],[contrSignDate],[contrTerm],[contrDoPerson],[contrEnrollDate],[contrDemo]) VALUES('" + lblContrID.Text.Trim() + "','1','" + DeptID + "','" + ReperonID + "','"+cbTermCom.Text.Trim()+"','" + ContrStatusID + "','" + SmallTypeID + "','" + txtContrName.Text.Trim() + "','" + txtContrSubject.Text.Trim() + "'," + double.Parse(txtContrAmount.Text.Trim()) + " ,'" + cbContrPayMethod.Text.Trim() + "','" + dtpContrSignDate.Value.ToShortDateString() + "','" + txtContrTerm.Text.Trim() + "','" + cbUserName.Text.Trim() + "','" + DateTime.Now.ToLocalTime() + "','" + rtbDemo.Text.Trim() + "')";
	                    dataBase.DataExcute("Insert");
                    }
                    if (Flag=="Edit")
                    {
                    dataBase.Cmd = "update  [tb_Contr_Information] set  contrExecStatusID='1', deptID='" + DeptID + "',RePersID='" + ReperonID + "',TermComp='"+cbTermCom.Text.Trim()+"',contrStatusID='" + ContrStatusID + "',contrSmallTypeID='" + SmallTypeID + "',contrName='" + txtContrName.Text.Trim() + "',contrSubject='" + txtContrSubject.Text.Trim() + "',contrAmount=" + double.Parse(txtContrAmount.Text.Trim()) + " ,contrPayMethod='" + cbContrPayMethod.Text.Trim() + "',contrSignDate='" + dtpContrSignDate.Value.ToShortDateString() + "',contrTerm='" + txtContrTerm.Text.Trim() + "',contrDoPerson='" + cbUserName.Text.Trim() + "',contrEnrollDate='" + DateTime.Now.ToLocalTime() + "',contrDemo='" + rtbDemo.Text.Trim() + "' where contrID = '" + lblContrID.Text.Trim() + "'";
                    dataBase.DataExcute("Update");                       
                    }
                //20181009 增加合同执行状态自动变更为执行。
                DialogResult judgeFlag = MessageBox.Show("是否变更合同状态为已执行？", "变更提示", MessageBoxButtons.YesNo);
                if (judgeFlag == DialogResult.Yes)
                {
                    string strUserID = CommonClass.Common_UserID;
                    string strContrID = lblContrID.Text.Trim();
                    dataBase.ConStr = "select * from tb_ContrVerify where contrid='" + strContrID + "'";
                    DataTable dt2 = dataBase.GetDataTable();
                    if (dt2.Rows.Count < 1)
                    {
                        dataBase.Cmd = "insert into tb_ContrVerify (userID,verifyDate,contrID) values('" + strUserID + "','" + DateTime.Now.ToLocalTime() + "','" + strContrID + "')";
                        dataBase.DataExcute("Insert");
                        dataBase.Cmd = "update tb_contr_information set contrstatusID='2' where contrID='" + strContrID + "'";
                        dataBase.DataExcute("Update");
                    }
                    else
                    {
                        MessageBox.Show("该合同已审核！", "提示");
                    }
                }

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
                        cbUserName.Items.Add(dt.Rows[i][0].ToString());                      
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
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "select * from tb_Filetable where contrID='"+lblContrID.Text.Trim()+ "' and demo='合同会签表'";
            DataTable dt = dataBase.GetDataTable();
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("该合同会签表已上传，请联系管理员进行删除！", "提示");
                return;
            }
            else
            {
                UploadForm uploadForm = new UploadForm();
                uploadForm.ShowDialog();                
            }
        }

        private void btnContrFile_Click(object sender, EventArgs e)
        {
            CommonClass.ContrID = lblContrID.Text.Trim();
            CommonClass.FlagDemo = "合同扫描件";
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "select * from tb_Filetable where contrID='" + lblContrID.Text.Trim() + "'  and demo='合同扫描件'";
            DataTable dt = dataBase.GetDataTable();
            if (dt.Rows.Count>0)
            {
               string flag =MessageBox.Show("该合同扫描件已存在，是否重新上传？","提示",MessageBoxButtons.YesNo).ToString();
                if (flag=="No")
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
            btnContrFile.Enabled = false;
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            cbCondition.Visible = true;
            cbCondition.Focus();
            txtQueryContent.Visible = true;
            tsbCancel.Enabled = true;
            tsbAddNew.Enabled = false;
            tsbImport.Enabled = false;
        }
        
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            ContrInput_Load(null, null);
            tsbAddNew.Enabled = true;
            tsbQuery.Enabled = true;
            tsbImport.Enabled = true;
            tsbPrint.Enabled = false;
            tsbScanFiles.Enabled = false;   
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
            string strContrID = dgvContrInfo.Rows[i].Cells[0].Value.ToString();
            string yesOrNo = MessageBox.Show(string.Format("确定要删除{0}合同信息？",strContrID),"提示",MessageBoxButtons.YesNo).ToString();
            if (yesOrNo=="Yes")
            {
                try
                {
                    DataBase dataBase = new DataBase();
                    dataBase.ConStr = "select * from tb_Contr_Information where contrid='" + strContrID + "'and [contrStatusID]=1";
                    DataTable dt1 = dataBase.GetDataTable();
                    if (dt1.Rows.Count > 0)
                    {
                        dataBase.Cmd = "DELETE FROM [tb_Contr_Information] where [contrID]='" + strContrID + "'";
                        dataBase.DataExcute("Delete");
                        dataBase.ConStr = "select * from [tb_FileTable] where contrID='" + strContrID + "'";
                        DataTable dt2 = dataBase.GetDataTable();
                        if (dt2.Rows.Count > 0)
                        {
                            dataBase.Cmd = "DELETE FROM [tb_FileTable] where [contrID]='" + strContrID + "'";
                            dataBase.DataExcute("Delete");
                        }
                        MessageBox.Show(string.Format("合同号为{0}的信息已删除！", strContrID), "提示");
                        ContrInput_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("该合同存在执行数据，无法删除！", "提示");
                        return;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示");
                    throw ex;
                }
            }

        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            int i = dgvContrInfo.CurrentCell.RowIndex;
            CommonClass.ContrID =dgvContrInfo.Rows[i].Cells[0].Value.ToString();            
            QueryPrintForm queryPrintForm = new QueryPrintForm();
            queryPrintForm.ShowDialog();
        }

        private void txtContrAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断输入的是否为数字、回车、删除键
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8 )
            {
                if (e.KeyChar=='.')
                {
                	e.Handled = false;
                } 
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Flag = "Edit";
            int i = dgvContrInfo.CurrentCell.RowIndex;
            if (dgvContrInfo.Rows[i].Cells[12].Value.ToString()=="未执行")
            {
                gbContrInfo.Enabled = true;
                lblContrID.Text = dgvContrInfo.Rows[i].Cells[0].Value.ToString();
	            txtContrName.Text = dgvContrInfo.Rows[i].Cells[1].Value.ToString();
	            txtContrSubject.Text= dgvContrInfo.Rows[i].Cells[2].Value.ToString();
	            txtContrAmount.Text = dgvContrInfo.Rows[i].Cells[3].Value.ToString();
                cbRePersID.Text = dgvContrInfo.Rows[i].Cells[4].Value.ToString();
                cbTermCom.Text= dgvContrInfo.Rows[i].Cells[5].Value.ToString();
                cbContrPayMethod.Text = dgvContrInfo.Rows[i].Cells[6].Value.ToString();
                dtpContrSignDate.Value= Convert.ToDateTime(dgvContrInfo.Rows[i].Cells[7].Value.ToString());
                cbDeptName.Text = dgvContrInfo.Rows[i].Cells[8].Value.ToString();
                cbContrSmallType.Text = dgvContrInfo.Rows[i].Cells[10].Value.ToString();
                cbContrBigType.Text = dgvContrInfo.Rows[i].Cells[11].Value.ToString();
                cbContrStatusID.Enabled = true;
                cbContrStatusID.Text = dgvContrInfo.Rows[i].Cells[12].Value.ToString();
                cbUserName.Text = dgvContrInfo.Rows[i].Cells[13].Value.ToString();
                rtbDemo.Text= dgvContrInfo.Rows[i].Cells[14].Value.ToString();
                txtContrTerm.Text= dgvContrInfo.Rows[i].Cells[9].Value.ToString();
                if (!string.IsNullOrEmpty(txtContrTerm.Text.Trim()))
                {
                    string[] strArray = dgvContrInfo.Rows[i].Cells[9].Value.ToString().Split('～');
                    dtpFromDate.Value = Convert.ToDateTime(strArray[0]);
	                dtpToDate.Value = Convert.ToDateTime(strArray[1]);
                }
                tsbEdit.Enabled = false;
                tsbAddNew.Enabled = false;
                tsbQuery.Enabled = false;
                tsbSave.Enabled = true;
                tsbImport.Enabled = false;
                tsbDel.Enabled = false;
                tsbCancel.Enabled = true;
                tsbPrint.Enabled = false;
            }
            else
            {
                MessageBox.Show("该合同已执行，不得修改！","提示");
            }

        }
        
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
             txtContrTerm.Text = dtpFromDate.Value.ToShortDateString().ToString()+"～" + dtpToDate.Value.ToShortDateString().ToString();
        }

        private void lblAddReperson_Click(object sender, EventArgs e)
        {
            ContrRePerson contrRePerson = new ContrRePerson();
            contrRePerson.ShowDialog();
        }

        private void lblAddBigType_Click(object sender, EventArgs e)
        {
            ContrType contrType = new ContrType();
            contrType.ShowDialog();
        }

        private void lblAddDept_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.ShowDialog();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
           txtContrTerm.Text = dtpFromDate.Value.ToShortDateString().ToString() + "～" + dtpToDate.Value.ToShortDateString().ToString();
        }

        private void dgvContrInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tsbDel.Enabled = true;
            tsbPrint.Enabled = true;
            tsbEdit.Enabled = true;
            tsbAddNew.Enabled = false;
            tsbQuery.Enabled = false;
            tsbImport.Enabled = false;
            tsbCancel.Enabled = true;
            tsbScanFiles.Enabled = true;
        }

        private void tsbScanFiles_Click(object sender, EventArgs e)
        {
            int i = dgvContrInfo.CurrentCell.RowIndex;
            CommonClass.ContrID = dgvContrInfo.Rows[i].Cells[0].Value.ToString();
            ContrDo contrDo = new ContrDo();
            CommonClass.FlagWinform = "ContrInput";
            contrDo.ShowDialog();

        }

        
    }
}
