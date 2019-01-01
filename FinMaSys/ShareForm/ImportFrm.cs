using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMaSys.ShareForm
{
    public partial class ImportFrm : Form
    {
        public ImportFrm()
        {
            InitializeComponent();
        }
        static string strConn = "";
        private void btnBrower_Click(object sender, EventArgs e)
        {
            //清空comboBox中现有的工作表
            cbSheets.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel 文件(*.xls;*.xlsx)|*.xls;*.xlsx";
            ofd.Multiselect = false;
            try
            {
                //选中文件
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //获取选中文件的路径
                    this.txtFilePath.Text = ofd.FileName;
                    //获取文件后缀名 
                    if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".xls")
                    {
                        //如果是07以下（.xls）的版本的Excel文件就使用这条连接字符串
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ofd.FileName + ";Extended Properties=Excel 8.0;";
                    }
                    else
                    {
                        //如果是07以上(.xlsx)的版本的Excel文件就使用这条连接字符串
                        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=" + ofd.FileName + ";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'"; //此連接可以操作.xls與.xlsx文件
                    }
                    if (System.IO.Path.GetExtension(ofd.FileName).ToLower().Contains(".xls"))
                    {
                        //打开Excel的连接，设置连接对象
                        OleDbConnection conn = new OleDbConnection(strConn);
                        conn.Open();
                        DataTable sheetNames = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                        conn.Close();
                        int i = 0;
                        //遍历Excel文件获取Excel工作表，并将所有工作表名称加载到comboBox控件中
                        foreach (DataRow dr in sheetNames.Rows)
                        {
                            if (i == 0)
                            {
                                cbSheets.Text = dr[2].ToString();
                            }
                            //添加工作表名称
                            cbSheets.Items.Add(dr[2]);
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("excel 格式不正确！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入文件时出错,文件可能正被打开\r\n" + ex.Message.ToString(), "提示");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rbHouseInfo.Checked)  //房屋信息
            {

            }
            if (rbRentExpense.Checked) //水电管理费
            {

            }
        }
       
    }
}
