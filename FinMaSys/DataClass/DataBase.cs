using FinMaSys.ComClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinMaSys
{

    class DataBase
    {
        private string dataAddress;
        private string conStr;
        SqlConnection con = null;
        string cmd = null;
        string param = null;
        Byte[] byData = null;
        public DataBase( )

        {
            try
            {
                CommonClass commonClass = new CommonClass();
                string ServerAddr = commonClass.IniReadValue("Database", "ServerAddr", Application.StartupPath + @"\FinMaSys.ini");
                string LoginName = commonClass.IniReadValue("Database", "LoginName", Application.StartupPath + @"\FinMaSys.ini");
                string strPassword = commonClass.IniReadValue("Database", "Pswd", Application.StartupPath + @"\FinMaSys.ini");
                dataAddress = @"Data Source="+ ServerAddr + ";Initial Catalog=db_Finmasys; Persist Security Info = True;User ID=" + LoginName + ";Password="+ strPassword;               
                 Con = new SqlConnection(DataAddress);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }
            
        }
        public DataTable GetDataTable()
        {
            try
            {
                if (Con.State==ConnectionState.Closed)
                {
                    Con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(ConStr, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示");
                throw ex;
            }

        }
        public void DataExcute(string excuteFlag)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            switch (excuteFlag)
            {
            
                default:
                    break;
                case "Insert":
                        sda.InsertCommand = new SqlCommand(Cmd, Con);
                        sda.InsertCommand.ExecuteNonQuery();
                    break;
                case "Update":
                    sda.UpdateCommand = new SqlCommand(Cmd,Con);
                    sda.UpdateCommand.ExecuteNonQuery();
                    break;
                case "Delete":
                    sda.DeleteCommand = new SqlCommand(Cmd,Con);
                    sda.DeleteCommand.ExecuteNonQuery() ;
                    break;
            }
        }



        public string DataAddress { get => dataAddress; set => dataAddress = value; }
        public string ConStr { get => conStr; set => conStr = value; }
        public SqlConnection Con { get => con; set => con = value; }
        public string Cmd { get => cmd; set => cmd = value; }
        public byte[] ByData { get => byData; set => byData = value; }
        public string Param { get => param; set => param = value; }
    }
      
    }

