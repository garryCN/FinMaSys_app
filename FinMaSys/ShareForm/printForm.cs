using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMaSys.ShareForm
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }
        StringReader lineReader = null; //StringReader 解析：打开一个文本文件以读取指定范围的字符，或基于现有的流创建一个读取器
        private void pd1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;//获得绘图对象
            float linesPerPage = 0;//页面的行号
            float yPosition = 0;//字符串的纵坐标
            int count = 0;//行计数器
            float leftMargin = 0;//左边距
            float topMargin = 1;//上边距
            string line = "";//行字符串
            Font printFont = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));//当前的打印字体
            SolidBrush myBrush = new SolidBrush(Color.Black); //画笔定义
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(g); //每页可打印行数
            //逐行循环打印一页
            while (count<linesPerPage&&((line=lineReader.ReadLine())!=null))
            ////行计数器 <页面的行数(总行数) && 要打印的字符串 = 文本文件读取的字符串（IO流）
            {
                yPosition = topMargin + (count * printFont.GetHeight(g));
                g.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                //字符串,字体格式,笔刷(颜色), x坐标   ,y坐标   ,文本的格式化特性
                count++;

            }
            /*
            * 注意：使用本段代码前,要在该窗体的类中定义lineReader对象，即StringReader类：StringReader lineReader = null;            
            * 如果本页打印完成而line不为空，说明还有没完成的页面，这将触发下一次的打印事件。在下一次的打印中lineReader会自动读取上次没有打印完的内容，因为lineReader是这个打印方法外的类的成员，它可以记录当前读取的位置
            */

        }

        private void tsbPrintSet_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd1;
            printDialog.ShowDialog();
        }

        private void tsbPageSet_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.Document = pd1;
            pageSetupDialog.ShowDialog();
        }

        private void tsbPrintView_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd1;
            lineReader = new StringReader("");
            printPreviewDialog.ShowDialog();
        }
    }
}
