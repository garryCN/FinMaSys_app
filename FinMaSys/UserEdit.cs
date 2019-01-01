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
    public partial class UserEdit : Form
    {
        public UserEdit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            string Constr = null;
            switch (this.Text)
            {
                default:
                    Constr = @"SELECT distinct [userGroupName]  FROM [tb_Usergroup]";
                    break;
                case "用户修改":  //判断窗体
                    txtUserID.Enabled = false;                    
                    txtUserID.Text = CommonClass.Select_UserID;
                    txtUserName.Text = CommonClass.Select_User;
                    Constr = @"SELECT distinct [userGroupName]  FROM [tb_Usergroup]";
                    break;
                case "客商修改":
                    txtUserID.Enabled = false;
                    label1.Text = "客商编码";
                    txtUserID.Text =CommonClass.Select_RePersonID;
                    label2.Text = "客商名称";
                    label3.Text = "客商类型";
                    txtUserName.Text =CommonClass.Select_RePesonName;
                    Constr = @"SELECT distinct rePersonType  FROM [tb_Contr_RePerson]";
                    break;
                case "科室修改":
                    txtUserID.Enabled = false;
                    label1.Text = "科室编码";
                    txtUserID.Text = CommonClass.Select_DeptID;
                    label2.Text = "科室名称";
                    label3.Text = "科室属性";
                    txtUserName.Text = CommonClass.Select_DeptName;
                    Constr = @"SELECT distinct deptProp  FROM [tb_Departments]";
                    break;
                case "合同类型修改":
                    txtUserID.Enabled = false;
                    label1.Text = "合同类型编码";
                    txtUserID.Text = CommonClass.Select_ContrSmallTypeID;
                    label2.Text = "合同小类名称";                    
                    txtUserName.Text = CommonClass.Select_ContrSmallTypeName;
                    label3.Text = "合同大类名称";
                    Constr = @"select distinct(contrBigTypeName) from dbo.tb_Contr_BigType";
                    break;
            }
       
                   
            //下拉菜单内容添加
           
            try
            {
                DataBase dataBase = new DataBase();
                dataBase.ConStr = Constr;
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count ; i++)
                    {
                        cbUserGroup.Items.Add(dt.Rows[i][0].ToString());                     
                    }

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
            
          
        
        }

        private void txtUserID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            txtUserID_KeyUp(null, e);
        }

        private void cbUserGroup_KeyUp(object sender, KeyEventArgs e)
        {
            txtUserID_KeyUp(null, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                default:
                    break;
                case "用户新增":
                    try
                    {
                        UserEditErrProv.Clear();
                        if (string.IsNullOrEmpty(txtUserID.Text.Trim()))
                        {
                            UserEditErrProv.SetError(txtUserID, "用户工号不得为空！");
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                            {
                                UserEditErrProv.SetError(txtUserName, "姓名不得为空!");
                                return;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(cbUserGroup.Text.Trim()))
                                {
                                    UserEditErrProv.SetError(cbUserGroup, "用户分组不得为空！");
                                    return;
                                }
                                else
                                {
                                    DataBase dataBase = new DataBase();
                                    dataBase.ConStr = "select * from tb_Users where userid='" + txtUserID.Text.Trim() + "' ";
                                    DataTable dt = dataBase.GetDataTable();
                                    if (dt.Rows.Count != 0)
                                    {
                                        MessageBox.Show("该用户已存在！", "用户重复提示");
                                    }
                                    else
                                    {
                                        dataBase.Cmd = "INSERT INTO  tb_Users  (userGroupID,userID,StatusID,userName,passWord) select top 1 userGroupID ,'" + txtUserID.Text.Trim() + "',2,'" + txtUserName.Text.Trim() + "','888' from tb_Usergroup where userGroupName ='" + cbUserGroup.Text.Trim() + "'";
                                        dataBase.DataExcute("Insert");
                                        DialogResult ynFlag;
                                        ynFlag = MessageBox.Show("已添加成功，是否继续？", "保存提示", MessageBoxButtons.YesNo);
                                        if (ynFlag == DialogResult.Yes)
                                        {
                                            txtUserID.Text = "";
                                            txtUserName.Text = "";
                                            cbUserGroup.Text = "";
                                            txtUserID.Focus();
                                        }
                                        else
                                        {
                                            this.Close();
                                        }
                                    }
                                }

                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误提示");
                        throw ex;
                    }
                    break;
                case "用户修改":
                    try
                    {
                        if (string.IsNullOrEmpty(cbUserGroup.Text.Trim()))
                        {
                            UserEditErrProv.SetError(cbUserGroup, "用户组为必选项！");
                            return;
                        }
                        else
                        {
                            DataBase dataBase = new DataBase();
                            dataBase.Cmd = "UPDATE tb_Users SET username='" + txtUserName.Text.Trim() + "', [userGroupID] =(SELECT top 1 userGroupID  FROM tb_Usergroup  where userGroupName='" + cbUserGroup.Text.Trim() + "' )  WHERE userid='" + txtUserID.Text.Trim() + "'";
                            dataBase.DataExcute("Update");
                            MessageBox.Show("已修改成功!", "修改提示");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误提示");
                        throw ex;
                    }
                    break;
                case "客商修改":
                    try
                    {
                        if (string.IsNullOrEmpty(cbUserGroup.Text.Trim()))
                        {
                            UserEditErrProv.Clear();
                            UserEditErrProv.SetError(cbUserGroup, "客商类型为必选项！");
                            return;
                        }
                        else
                        {
                            DataBase dataBase = new DataBase();
                            dataBase.Cmd = "UPDATE tb_Contr_RePerson SET rePersonName='" + txtUserName.Text.Trim() + "', [rePersonType] ='" + cbUserGroup.Text.Trim() + "'   WHERE repersid='" + txtUserID.Text.Trim() + "'";
                            dataBase.DataExcute("Update");
                            MessageBox.Show("已修改成功!", "修改提示");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误提示");
                        throw ex;
                    }
                    break;
                case "科室修改":
                    try
                    {
                        if (string.IsNullOrEmpty(cbUserGroup.Text.Trim()))
                        {
                            UserEditErrProv.Clear();
                            UserEditErrProv.SetError(cbUserGroup, "科室类型为必选项！");
                            return;
                        }
                        else
                        {
                            DataBase dataBase = new DataBase();
                            dataBase.Cmd = "UPDATE tb_Departments SET deptName='" + txtUserName.Text.Trim() + "', [deptProp] ='" + cbUserGroup.Text.Trim() + "'   WHERE deptID='" + txtUserID.Text.Trim() + "'";
                            dataBase.DataExcute("Update");
                            MessageBox.Show("已修改成功!", "修改提示");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误提示");
                        throw ex;
                    }
                    break;
                case "合同类型修改":
                    try
                    {
                        if (string.IsNullOrEmpty(cbUserGroup.Text.Trim()))
                        {
                            UserEditErrProv.Clear();
                            UserEditErrProv.SetError(cbUserGroup, "合同大类型为必选项！");
                            return;
                        }
                        else
                        {
                            DataBase dataBase = new DataBase();
                            dataBase.Cmd = "UPDATE [tb_Contr_SmallType] SET [contrSmallTypeName]='" + txtUserName.Text.Trim() + "', [contrBigTypeID] =(select top 1 contrBigTypeID from tb_Contr_BigType where contrBigTypeName='" + cbUserGroup.Text.Trim() + "')   WHERE contrSmallTypeID='" + txtUserID.Text.Trim() + "'";
                            dataBase.DataExcute("Update");
                            MessageBox.Show("已修改成功!", "修改提示");
                            this.Close();
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误提示");
                        throw ex;
                    }
                    break;

            }          
          
             
            

        }
    }
}
