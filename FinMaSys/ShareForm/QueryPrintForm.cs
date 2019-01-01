using FinMaSys.ComClass;
using FinMaSys.ShareForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinMaSys
{
    public partial class QueryPrintForm : Form
    {
        public QueryPrintForm()
        {
            InitializeComponent();
        }

      
        private void rbContrFile_Click(object sender, EventArgs e)
        {
            tsbPrintSetup.Enabled = false;
            tsbPageSetup.Enabled = false;
            qrCodeGC.Visible = false;
        }

        private void tsbPrintSetup_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd1;
            printDialog.ShowDialog();
        }

        private void tsbPageSetup_Click(object sender, EventArgs e)
        {
            PrintSet printSet = new PrintSet();
            printSet.ShowDialog();
        }



        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (rbContrFile.Checked)
            {
                CommonClass common = new CommonClass();
                string strContrID = CommonClass.ContrID;
                string strSql = "select fileContent,fileName from [tb_FileTable]  WHERE	contrID='" + strContrID + "' AND demo='合同扫描件'";
                common.DwOpen(strContrID, strSql);
                this.Close();
            }
            if (rbContrQrcode.Checked)
            {
                pd1.Print();
                this.Close();
            }
        }

        private void rbContrQrcode_Click(object sender, EventArgs e)
        {
            tsbPrintSetup.Enabled = true;
            tsbPageSetup.Enabled = true;
            qrCodeGC.Visible = true;
        }

        private void QueryPrintForm_Load(object sender, EventArgs e)
        {
            if (rbContrQrcode.Checked)
            {
                qrCodeGC.Text = CommonClass.ContrID;
                qrCodeGC.Visible = true;
                label1.Text = CommonClass.ContrID;
            }
        }

        private void pd1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float strX, strY;
            CommonClass commonClass = new CommonClass();
            try
            {
                if (File.Exists("FinMaSys.ini"))
                {
                    Font drawFont = new Font("宋体", 6);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);
                    strX = float.Parse(commonClass.IniReadValue("X", "XPosition", Application.StartupPath + @"\FinMaSys.ini"));
                    strY = float.Parse(commonClass.IniReadValue("Y", "YPosition", Application.StartupPath + @"\FinMaSys.ini"));
                    Bitmap bitmap = new Bitmap(qrCodeGC.Width, qrCodeGC.Height);//创建位图对象
                    qrCodeGC.DrawToBitmap(bitmap, new Rectangle(0, 0, qrCodeGC.Width, qrCodeGC.Height));
                    e.Graphics.DrawImage(bitmap, strX, strY);//绘制图像
                    e.Graphics.DrawString(label1.Text,drawFont,drawBrush,label1.Width-strX, qrCodeGC.Height-15);

                }
            }

            catch (Exception ee)//捕获异常
            {
                MessageBox.Show(ee.Message);//弹出消息对话框
            }
        }
}
}
