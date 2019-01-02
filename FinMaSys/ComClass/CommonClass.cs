using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;
namespace FinMaSys.ComClass
{
     class CommonClass
    {
        //当前登录用户及登录ID
        private static string common_User, common_UserID;
        //当前登录用户所属组ID
        private static string common_UserGroupID;
        //选中的用户及用户ID
        private static string select_User, select_UserID;
        //选中的合同相对人ID及合同相对人名称、开户行、帐号、类型
        private static string select_RePersonID, select_RePesonName;
        private static string select_OpenBank, select_tbAccNum;
        private static string select_RePersonType;
        //

        //选中的科室ID及科室名称
        private static string select_DeptID, select_DeptName;
        //选中的合同小类ID和大类ID
        private static string select_ContrSmallTypeID, select_ContrSmallTypeName;
        //合同ID
        private static string contrID;
        //共用标识
        private static string flagDemo;
        //用户禁用、用户启用标识
        private static string flagUser;
        private static string disFlagUser;
        //窗体名称
        private static string flagWinform;
        //共享编码
        private static string idShare;
        //合同状态、金额、备注、日期
        private static string stateContr;
        private static string sumJe;
        private static string demo;
        private static DateTime dateAdd;
   
       
        public static string Common_User { get => common_User; set => common_User = value; }
        public static string Common_UserID { get => common_UserID; set => common_UserID = value; }
        public static string Select_User { get => select_User; set => select_User = value; }
        public static string Select_UserID { get => select_UserID; set => select_UserID = value; }
   
        public static string Select_RePesonName { get => select_RePesonName; set => select_RePesonName = value; }
        public static string Select_RePersonID { get => select_RePersonID; set => select_RePersonID = value; }
        public static string Select_DeptID { get => select_DeptID; set => select_DeptID = value; }
        public static string Select_DeptName { get => select_DeptName; set => select_DeptName = value; }
        public static string Select_ContrSmallTypeID { get => select_ContrSmallTypeID; set => select_ContrSmallTypeID = value; }
        public static string Select_ContrSmallTypeName { get => select_ContrSmallTypeName; set => select_ContrSmallTypeName = value; }
        public static string ContrID { get => contrID; set => contrID = value; }
        public static string FlagDemo { get => flagDemo; set => flagDemo = value; }
        public static string Common_UserGroupID { get => common_UserGroupID; set => common_UserGroupID = value; }
        public static string FlagUser { get => flagUser; set => flagUser = value; }
        public static string DisFlagUser { get => disFlagUser; set => disFlagUser = value; }
        public static string FlagWinform { get => flagWinform; set => flagWinform = value; }
        public static string IdShare { get => idShare; set => idShare = value; }
        public static string StateContr { get => stateContr; set => stateContr = value; }
        public static string SumJe { get => sumJe; set => sumJe = value; }
        public static string Demo { get => demo; set => demo = value; }
        public static DateTime DateAdd { get => dateAdd; set => dateAdd = value; }
        public static string Select_OpenBank { get => select_OpenBank; set => select_OpenBank = value; }
        public static string Select_tbAccNum { get => select_tbAccNum; set => select_tbAccNum = value; }
        public static string Select_RePersonType { get => select_RePersonType; set => select_RePersonType = value; }





        #region "声明文件读写系统变量"
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);
        #endregion
        /// <summary> 
        /// 写入INI文件 
        /// </summary> 
        /// <param name="Section">项目名称(如 [TypeName] )</param> 
        /// <param name="Key">键</param> 
        /// <param name="Value">值</param> 
        public void IniWriteValue(string Section, string Key, string Value, string inipath)
        {
            WritePrivateProfileString(Section, Key, Value, inipath);
        }
        /// <summary> 
        /// 读出INI文件 
        /// </summary> 
        /// <param name="Section">项目名称(如 [TypeName] )</param> 
        /// <param name="Key">键</param> 
        public string IniReadValue(string Section, string Key, string inipath)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, inipath);
            return temp.ToString();
        }
        //EXCEL导出方法
        public static bool ExportExcelWithAspose(DataGridView dgv,  string filepath)
        {
            DataTable dt = new DataTable();
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }

            try
            {
                if (dt == null)
                {
                    MessageBox.Show("数据为空");
                    return false;
                }
                Aspose.Cells.License li = new Aspose.Cells.License();
                li.SetLicense("ASPOSE/License.lic");//破解证书

                Workbook book = new Workbook(); //创建工作簿
                Worksheet sheet = book.Worksheets[0]; //创建工作表
                Cells cells = sheet.Cells; //单元格
                                           //创建样式
                Aspose.Cells.Style style = book.Styles[book.Styles.Add()];
                style.Borders[Aspose.Cells.BorderType.LeftBorder].LineStyle = Aspose.Cells.CellBorderType.Thin; //应用边界线 左边界线 
                style.Borders[Aspose.Cells.BorderType.RightBorder].LineStyle = Aspose.Cells.CellBorderType.Thin; //应用边界线 右边界线 
                style.Borders[Aspose.Cells.BorderType.TopBorder].LineStyle = Aspose.Cells.CellBorderType.Thin; //应用边界线 上边界线 
                style.Borders[Aspose.Cells.BorderType.BottomBorder].LineStyle = Aspose.Cells.CellBorderType.Thin; //应用边界线 下边界线 
                style.HorizontalAlignment = TextAlignmentType.Center; //单元格内容的水平对齐方式文字居中
                style.Font.Name = "宋体"; //字体
                                        //style1.Font.IsBold = true; //设置粗体
                style.Font.Size = 11; //设置字体大小
                                      //style.ForegroundColor = System.Drawing.Color.FromArgb(153, 204, 0); //背景色
                                      //style.Pattern = Aspose.Cells.BackgroundType.Solid; 

                int Colnum = dt.Columns.Count;//表格列数 
                int Rownum = dt.Rows.Count;//表格行数 
                                             //生成行 列名行 
                for (int i = 0; i < Colnum; i++)
                {
                    cells[0, i].PutValue(dt.Columns[i].ColumnName); //添加表头
                    cells[0, i].SetStyle(style); //添加样式
                }
                //生成数据行 
                for (int i = 0; i < Rownum; i++)
                {
                    for (int k = 0; k < Colnum; k++)
                    {
                        cells[1 + i, k].PutValue(dt.Rows[i][k].ToString()); //添加数据
                        cells[1 + i, k].SetStyle(style); //添加样式
                    }
                }
                sheet.AutoFitColumns(); //自适应宽
                book.Save(filepath); //保存
                MessageBox.Show("Excel成功保存到"+filepath);
                GC.Collect();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        //datagridview求和
        public double qiuhe(DataGridView DGV, string leiming)
        {
            double money = 0;
            foreach (DataGridViewRow row in DGV.Rows)
            {
                money += Convert.ToDouble(row.Cells[leiming].Value);//ColMoney是金额列的列名
            }
            return money;
        }
        public void DwOpen(string strContrID, string strQuerySql) //定义文档下载并打开方法
        {
            DataBase dataBase = new DataBase();
            dataBase.ConStr = strQuerySql;
            DataTable dtContr = dataBase.GetDataTable();
            if (dtContr.Rows.Count > 0)
            {
                //二进制文件上限索引（数组数量-1）
                int arrySize = ((byte[])dtContr.Rows[0][0]).GetUpperBound(0);
                //定义文件存储路径
                if (Directory.Exists(Application.StartupPath+@"\temp")==false)
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\temp");
                }
                string filePath = Application.StartupPath+@"\temp\" + dtContr.Rows[0][1].ToString();
                    FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                    //数据库中二进制文件写
                    fs.Write((byte[])dtContr.Rows[0][0], 0, arrySize);
                    fs.Close();
                    System.Diagnostics.Process.Start(filePath);                
            }
            else
            {
                MessageBox.Show("未上传任何附件！","错误提示");
            }
        }
        //自动取用户状态，“正常”、“锁定”
        public static int UserStatusJudg(string flag)
        {
            int statusParamAble = 0;
            int statusParamDissable = 0;
            string sqlUserstatus = "SELECT [StatusID]  FROM  tb_UsersStatus where UsersStatus='正常' union all SELECT[StatusID]  FROM tb_UsersStatus where UsersStatus = '锁定' ";
            DataBase dataBase = new DataBase();
            dataBase.ConStr = sqlUserstatus;
            try
            {
                DataTable dt = dataBase.GetDataTable();
                if (dt.Rows.Count > 0)
                {
                    statusParamAble = Convert.ToInt32(dt.Rows[0][0].ToString());
                    statusParamDissable = Convert.ToInt32(dt.Rows[1][0].ToString());
                    switch (flag)
                    {
                        default:
                            break;
                        case "正常":
                            return statusParamAble;
                        case "锁定":
                            return statusParamDissable;
                    }

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
                throw ex;
            }
            finally
            {
            }
            return 0;
        }      
        
    }

}
