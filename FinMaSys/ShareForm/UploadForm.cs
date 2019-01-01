using FinMaSys.ComClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace FinMaSys
{
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF文件(*pdf)|*.pdf";
            openFileDialog.Multiselect = false;//只能选一个文件
            //开始选择
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    //选择文件的路径传给textBox
                    txtFilePath.Text = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"错误提示");
                    throw ex;
                }
            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilePath.Text.Trim()))
            {
                try
                {
                    string filePath = txtFilePath.Text.Trim();
                    //实例化FS文件流对象
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    //实例化二进制读取对象
                    BinaryReader BReader = new BinaryReader(fs);
                    //读取二进制文件
                    Byte[] byData = BReader.ReadBytes((int)fs.Length);
                    fs.Close();
                    string strQuery = "select * from tb_Filetable where contrID='"+CommonClass.ContrID+" '";
                    DataBase dataBase = new DataBase();
                    dataBase.ConStr = strQuery;
                    DataTable dt = dataBase.GetDataTable();
                    string strDoParms = null;
                    if (dt.Rows.Count>0)
                    {
                        //数据库更新命令
                        strDoParms = "update tb_Filetable  set fileContent=@file where contrid='" + CommonClass.ContrID + "'" ;

                    }
                    else
                    {
                        //数据库插入命令
                        strDoParms = "insert into tb_Filetable (fileName,fileContent,contrID,demo) values('" + Path.GetFileName(filePath) + "',@file,'" + CommonClass.ContrID + "','" + CommonClass.FlagDemo + "')";
                    }
                    dataBase.Con.Close();
                    SqlCommand sqlcmd = new SqlCommand(strDoParms, dataBase.Con);
                    //添加SQL语句参数
                    sqlcmd.Parameters.Add("@file", SqlDbType.Image).Value = byData;
                    dataBase.Con.Open();
                    sqlcmd.ExecuteNonQuery();
                    dataBase.Con.Close();
                    MessageBox.Show(string.Format("{0}:{1}已上传到数据库！", CommonClass.FlagDemo, Path.GetFileName(filePath)), "成功提示");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示");
                    throw ex;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("请点击浏览按钮，选择需要上传的文件！", "提示");
                txtFilePath.Focus();
            }


        }
    }
}
