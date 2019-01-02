using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinMaSys.ComClass;

namespace FinMaSys.Invoice
{
    public partial class InvScanInput : Form
    {
        public InvScanInput()
        {
            InitializeComponent();
        }
        private string saleCompID = null;//销售方单位ID
        private void InvScanInput_Load(object sender, EventArgs e)
        {
            this.Height = panel1.Height + panel2.Height+40;

            cbBuyComp.SelectedIndex = 0;
            DataBase db = new DataBase();
            db.ConStr = "select InviTypeName from tb_InviType";
            DataTable dt = db.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                cbBInvType.Items.Add(dt.Rows[0][0].ToString());
                cbBInvType.SelectedIndex = 0;

            }
            tbQrcode.Select();
        }

        private  int  CkEmpty() //错误检查
        {
            
            if (cbBuyComp.Text == "")
            {
                MessageBox.Show("购买单位不得为空，请重新选择！");
                cbBuyComp.Focus();
                return 0;
            }
            if (cbBInvType.Text == "")
            {
                MessageBox.Show("发票类型不得为空，请重新选择！");
                cbBInvType.Focus();
                return 0;          
            }
            if (tBTax.Text == "")
            {
                MessageBox.Show("发票税率不得为空，请重新输入！");
                tBTax.Focus();
                return 0;
            }
            if (tbInvNum.Text == "")
            {
                MessageBox.Show("发票号码不得为空，请重新输入！");
                tbInvNum.Focus();
                return 0;

            }
            if (tbInvCode.Text == "")
            {
                MessageBox.Show("发票代码不得为空，请重新输入！");
                tbInvCode.Focus();
                return 0;

            }
            if (tbInvCkCode.Text == "")
            {
                MessageBox.Show("发票校验码不得为空，请重新输入！");
                tbInvCkCode.Focus();
                return 0;

            }
            if (tbInvDate.Text == "")
            {
                MessageBox.Show("发票开票日期不得为空，请重新输入！");
                tbInvDate.Focus();
                return 0;
            }
            if (tbAmount.Text == "")
            {
                MessageBox.Show("发票金额不得为空，请重新输入！");
                tbAmount.Focus();
                return 0;
            }
            if (InvTaxAmount.Text == "")
            {
                MessageBox.Show("发票税额不得为空，请重新输入！");
                InvTaxAmount.Focus();
                return 0;
            }
            
            if (tbTotalTax.Text == "")
            {
                MessageBox.Show("发票含税额不得为空，请重新输入！");
                tbTotalTax.Focus();
                return 0;
            }
            if (tbAbstract.Text == "")
            {
                MessageBox.Show("摘要不得为空，请重新输入！");
                tbAbstract.Focus();
                return 0;
            }
            
           if (tbDepart.Text == "")
            {
                MessageBox.Show("科室不得为空，请重新输入！");
                tbDepart.Focus();
                return 0;
            }
            if (tbTemo.Enabled && tbTemo.Text == "")
            {
                MessageBox.Show("科室分摊情况不得为空，请重新输入！");
                tbTemo.Focus();
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string InvNum =tbInvNum.Text.Trim() ;//发票号码
            string InvCode=tbInvCode.Text.Trim();//发票代码
            string InvCkCode=tbInvCkCode.Text.Trim();//校验码
            string InvDate =tbInvDate.Text.Trim() ;//开票日期
            string Amount = tbAmount.Text.Trim() ;//金额
            string TaxAmount = InvTaxAmount.Text.Trim();//税额
            string TotalTax=tbTotalTax.Text.Trim();//价税合计
            string BInvType=cbBInvType.Text.Trim();//发票类型
            string InvTypeId = null;//发票类型编号
            string BuyComp = cbBuyComp.Text.Trim();//采购单位名称
            string BuyCompId = null; //采购单位编号
            string Abstract = tbAbstract.Text.Trim();//摘要
            string dePatrment = CommonClass.Select_DeptID;//部门ID
            string userId = CommonClass.Common_UserID;
            string strTemo = tbTemo.Text.Trim();//分摊备注
            string strBillNum = tbBillNum.Text.Trim();//报账单号
            if (saleCompID != null)
            {
                DataBase db = new DataBase();
                db.ConStr = string.Format("select id from tb_InviType where InviTypeName ='{0}'", BInvType);
                DataTable dt = db.GetDataTable();
                if (dt.Rows.Count > 0)
                {
                    InvTypeId = dt.Rows[0][0].ToString();

                }
                db.ConStr = string.Format("select id from Rs_termcomp  where CompName ='{0}'", BuyComp);
                DataTable dt2 = db.GetDataTable();
                if (dt.Rows.Count > 0)
                {
                    BuyCompId = dt2.Rows[0][0].ToString();

                }
                db.ConStr = string.Format("select * from tb_InviInfo where InviNum='{0}'", InvNum);
                DataTable dt3 = db.GetDataTable();
                if (dt3.Rows.Count > 0)
                {
                    MessageBox.Show(string.Format("发票{0}已存在，请勿重复录入！", InvNum));
                }
                else
                {
                    if (CkEmpty() == 1)
                    {
                        #region 1、存入数据库
                            string dtLocal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            db.Cmd = string.Format("INSERT INTO [tb_InviInfo] " +
                            "([InviNum],[InviCode],[InviCkCode],[InviDate],[InviAmount],[InviTax],[InviTotalAmount],[InviComSale],[InviComBuy],[InviType],[InviAbstract],[DepartmentId],[InviNowDate],[UserId],[InviTemo],[BillNum])" +
                            "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')",
                            InvNum, InvCode, InvCkCode, InvDate, Amount, TaxAmount, TotalTax, saleCompID, BuyCompId, InvTypeId, Abstract, dePatrment, dtLocal, userId, strTemo, strBillNum);
                            db.DataExcute("Insert");
                            MessageBox.Show(string.Format("发票号{0}保存成功", InvNum));
                        #endregion

                        #region 2、清空控件
                            tbInvNum.Text = "";
                            tbInvCode.Text = "";
                            tbInvCkCode.Text = "";
                            tbInvDate.Text = "";
                            tbAmount.Text = "";
                            InvTaxAmount.Text = "";
                            tbTotalTax.Text = "";
                            tbQrcode.Text = "";
                            tbQrcode.Focus();
                        #endregion

                        #region 3、存入表格展示
                        int index = this.dgvInviView.Rows.Add();
                        this.dgvInviView.Rows[index].Cells[0].Value = Abstract; //摘要
                        this.dgvInviView.Rows[index].Cells[1].Value = CommonClass.Select_DeptName; //科室
                        this.dgvInviView.Rows[index].Cells[2].Value = InvNum;//发票号
                        this.dgvInviView.Rows[index].Cells[3].Value = InvDate;//开票日期
                        this.dgvInviView.Rows[index].Cells[4].Value = Amount;//金额
                        this.dgvInviView.Rows[index].Cells[5].Value = TaxAmount;//税
                        this.dgvInviView.Rows[index].Cells[6].Value = TotalTax;//价税合计
                        this.dgvInviView.Rows[index].Cells[7].Value = tbSaleComp.Text;//销售单位
                        dgvInviView.Update();

                        #endregion
                        #region 4、表格内数量、金额统计
                        if (dgvInviView.Rows.Count>0)
                        {
                            CommonClass commonClass = new CommonClass();
                            lblTotalAmount.Text= commonClass.qiuhe(dgvInviView, "价税合计").ToString();
                            lblQuantity.Text = (dgvInviView.Rows.Count-1).ToString();
                        }
                        #endregion

                    
                    }
                }


            }
            else
            {
                MessageBox.Show("请先在系统内增加或查找该销售方相关信息！");
                tbSaleComp.Focus();
            }

        }

        private void tbQrcode_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyValue == 13)
            {
                btnRead_Click(null,null);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string inviType=cbBInvType.Text.Trim();
            //读取发票类型
            DataBase db = new DataBase();
            db.ConStr = string.Format("select id from tb_InviType where invitypename='{0}' ", inviType);
            DataTable dt = db.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                inviType = dt.Rows[0][0].ToString();
            }
            double taxRate = Double.Parse(tBTax.Text.Trim()) / 100.0;
            InvProcess invProcess = new InvProcess();
            invProcess.InvoiceProcess(tbQrcode.Text.Trim(), inviType);
            tbInvNum.Text = InvProcess.InvNum;
            tbInvCode.Text = InvProcess.InvCode;
            tbInvCkCode.Text = InvProcess.InvCkCode;
            tbInvDate.Text = InvProcess.InvDate;
            tbAmount.Text = InvProcess.Amount;
            double tax = Math.Round(Double.Parse(tbAmount.Text.Trim()) * taxRate, 2);
            InvTaxAmount.Text = tax.ToString();
            tbTotalTax.Text = (tax + Double.Parse(tbAmount.Text.Trim())).ToString();          

        }

        private void tBTax_TextChanged(object sender, EventArgs e)
        {
            if (tbQrcode.Text.Trim()!="")
            {
                btnRead_Click(null, null);
            }
            

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            tbQrcode.SelectAll();
            CkEmpty();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            tbSaleComp.Text="";
            tbOpenBank.Text = "";
            tbAccNum.Text = "";
            tbDepart.Text = "";
            tbAbstract.Text = "";
        }

        private void cbBInvType_DropDown(object sender, EventArgs e)
        {
            cbBInvType.Items.Clear();
            DataBase db = new DataBase();
            db.ConStr = "select InviTypeName from tb_InviType";
            DataTable dt = db.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbBInvType.Items.Add(dt.Rows[i][0].ToString());
                }

            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            CommonClass.FlagWinform = "发票录入";
            ContrRePerson cre = new ContrRePerson();
            cre.ShowDialog();
            tbSaleComp.Text = CommonClass.Select_RePesonName;
            DataBase db = new DataBase();
            db.ConStr = string.Format("select RePersID '编号',rePersonName '供应商名称',rePersonOpenBank '开户行',rePersonAccNum '帐号' from tb_Contr_RePerson where rePersonName = '{0}' ", tbSaleComp.Text.Trim());
            DataTable dt = db.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                tbOpenBank.Text = dt.Rows[0][2].ToString();
                tbAccNum.Text = dt.Rows[0][3].ToString();
                saleCompID = dt.Rows[0][0].ToString();
                if (tbOpenBank.Text == "")
                {
                    tbOpenBank.Text = "请点击添加单位开户行！";
                }
                if (tbAccNum.Text == "")
                {
                    tbAccNum.Text = "请点击添加单位银行帐号！";
                }
            }
            else
            {
                tbSaleComp.Text = "系统内无此单位，请点击添加！";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContrRePerson cre = new ContrRePerson();
            cre.ShowDialog();
        }

        private void cbBuyComp_DropDown(object sender, EventArgs e)
        {
            cbBuyComp.Items.Clear();
            DataBase db = new DataBase();
            db.ConStr = "select CompName from Rs_termcomp";
            DataTable dt = db.GetDataTable();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbBuyComp.Items.Add(dt.Rows[i][0].ToString());
                }

            }
        }



        private void btnAdd2_Click(object sender, EventArgs e)
        {
            CommonClass.FlagWinform = "发票录入";
            Departments dpt = new Departments();
            dpt.ShowDialog();            
            tbDepart.Text = CommonClass.Select_DeptName;
            string deptId=  CommonClass.Select_DeptID;
            if (tbDepart.Text.Trim() == "全院公用")
            {
                tbTemo.Enabled = true;
            }
            else
            {
                tbTemo.Enabled = false;

            }

        }

        private void btnEmptyDgv_Click(object sender, EventArgs e)
        {
            dgvInviView.DataSource = null;
        }

        private void InvTaxAmount_TextChanged(object sender, EventArgs e)
        {
            if (InvTaxAmount.Text.Trim()!="" && tbAmount.Text.Trim()!="")
            {
                double tax = double.Parse(InvTaxAmount.Text.Trim());
                tbTotalTax.Text = (tax + Double.Parse(tbAmount.Text.Trim())).ToString();
            }


        }

        private void tbTemo_TextChanged(object sender, EventArgs e)
        {
            tbAbstract.Text = CommonClass.Select_DeptName+ "(科室分摊)";
        }
    }
}
