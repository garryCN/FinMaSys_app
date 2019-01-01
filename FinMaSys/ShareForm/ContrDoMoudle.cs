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

namespace FinMaSys.ShareForm
{
    public partial class ContrDoMoudle : Form
    {
        public ContrDoMoudle()
        {
            InitializeComponent();
        }

        private void ContrDoMoudle_Load(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                default:          
                    break;
                case "合同收付款维护":
                    label1.Text = "合同编号:";
                    lblContrID.Text =CommonClass.ContrID;
                    label3.Text = "收（付）款金额:";                    
                    break;
                case "合同收付款修改":
                    label1.Text = "编号:";
                    lblContrID.Text = CommonClass.IdShare;
                    label3.Text = "收（付）款金额:";
                    cbContrExecStatus.Items.Add(CommonClass.StateContr);
                    cbContrExecStatus.SelectedIndex = 0;
                    dtpDate.Value = CommonClass.DateAdd;
                    txtPayAmount.Text = CommonClass.SumJe;
                    txtTemo.Text = CommonClass.Demo;
                    break;
                case "合同入账维护":
                    label1.Text = "合同编号:";
                    lblContrID.Text = CommonClass.ContrID;
                    label3.Text = "凭证号(年-月-凭证号#):";
                    label5.Visible = false;
                    txtTemo.Visible = false;
                    break;
                case "合同入账修改":
                    label1.Text = "编号:";
                    lblContrID.Text = CommonClass.IdShare;
                    cbContrExecStatus.Items.Add(CommonClass.StateContr);
                    cbContrExecStatus.SelectedIndex = 0;
                    label3.Text = "凭证号(年-月-凭证号#):";
                    dtpDate.Value = CommonClass.DateAdd;
                    txtPayAmount.Text = CommonClass.Demo;
                    label5.Visible = false;
                    txtTemo.Visible = false;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            if (string.IsNullOrEmpty(cbContrExecStatus.Text.Trim()) || string.IsNullOrEmpty(txtPayAmount.Text.Trim()))
            {
                switch (this.Text)
                {
                    default:
                        break;
                    case "合同收付款维护":
                        MessageBox.Show("合同执行状态或付款金额不得为空！", "提示");
                        break;
                    case "合同收付款修改":
                        MessageBox.Show("合同执行状态或付款金额不得为空！", "提示");
                        break;
                    case "合同入账维护":
                        MessageBox.Show("合同执行状态或凭证号不得为空！", "提示");
                        break;
                    case "合同入账修改":
                        MessageBox.Show("合同执行状态或凭证号不得为空！", "提示");
                        break;
                }
            }
            else
            {

                {
                    try
                    {
                        string strUserID = CommonClass.Common_UserID;
                        string strContrExecStatus = null;
                        dataBase.ConStr = "select [contrExecStatusID] from [tb_Contr_Exec_Status] where [contrExecStatusName]='" + cbContrExecStatus.Text.Trim() + "'";
                        DataTable dt = dataBase.GetDataTable();
                        if (dt.Rows.Count > 0)
                        {
                            strContrExecStatus = dt.Rows[0][0].ToString();
                        }
                        switch (this.Text)
                        {
                            default:
                                break;
                            case "合同收付款维护":
                                if (string.IsNullOrEmpty(txtPayAmount.Text.Trim()))
                                {
                                    MessageBox.Show("金额不得为空！", "错误提示");
                                    return;

                                }
                                else
                                {
                                    dataBase.Cmd = "Insert into tb_Contr_Account (contrID,UserID,contrPayDate,contrExecAmount,contrExecStatus,contrTemo) values('" + lblContrID.Text.Trim() + "','" + strUserID + "','" + dtpDate.Value.ToLocalTime() + "'," + double.Parse(txtPayAmount.Text.Trim()) + ",'" + strContrExecStatus + "','" + txtTemo.Text.Trim() + "')";
                                    dataBase.DataExcute("Insert");
                                }
                                break;
                            case "合同收付款修改":
                                if (string.IsNullOrEmpty(txtPayAmount.Text.Trim()))
                                {
                                    MessageBox.Show("金额不得为空！", "错误提示");
                                    return;

                                }
                                else
                                {
                                    dataBase.Cmd =string.Format("update tb_Contr_Account set contrID='{0}',UserID='{1}',contrPayDate='{2}',contrExecAmount={3},contrExecStatus='{4}',contrTemo='{5}' where contrDoID='{6}'", CommonClass.ContrID,strUserID , dtpDate.Value.ToLocalTime() , double.Parse(txtPayAmount.Text.Trim()) , strContrExecStatus , txtTemo.Text.Trim(), lblContrID.Text.Trim());
                                    dataBase.DataExcute("Update");
                                }
                                break;
                            case "合同入账维护":
                                if (!string.IsNullOrEmpty(txtPayAmount.Text.Trim()))
                                {
                                    dataBase.Cmd = "Insert into tb_Contr_AccVou (contrID,UserID,contrVou,contrVoucher,contrExecStatus) values('" + lblContrID.Text.Trim() + "','" + strUserID + "','" + dtpDate.Value.ToLocalTime() + "','" + txtPayAmount.Text.Trim() + "','"+ strContrExecStatus + "')";
                                    dataBase.DataExcute("Insert");
                                }
                                else
                                {
                                    MessageBox.Show("凭证号不得为空！", "错误提示");
                                    return;
                                }
                                break;
                            case "合同入账修改":
                                if (!string.IsNullOrEmpty(txtPayAmount.Text.Trim()))
                                {
                                    dataBase.Cmd = string.Format("update tb_Contr_AccVou set contrID='{0}',UserID='{1}',contrVou='{2}',contrVoucher='{3}',contrExecStatus='{4}' where contrVouID={5}",CommonClass.ContrID , strUserID , dtpDate.Value.ToLocalTime(),txtPayAmount.Text.Trim(),strContrExecStatus, lblContrID.Text.Trim());
                                    dataBase.DataExcute("Update");
                                }
                                else
                                {
                                    MessageBox.Show("凭证号不得为空！", "错误提示");
                                    return;
                                }
                                break;
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误提示");
                        throw ex;
                    }
                    this.Close();
                }
            }
   
        }

        private void cbContrExecStatus_DropDown(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.ConStr = "select [contrExecStatusName]  FROM [tb_Contr_Exec_Status] where contrExecStatusName<>'未付款' ";
            DataTable dt = dataBase.GetDataTable();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    cbContrExecStatus.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cbContrExecStatus.Items.Add(dt.Rows[i][0]).ToString();
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
        }
    }
}
