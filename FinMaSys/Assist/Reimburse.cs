using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMaSys.Assist
{
    public partial class Reimburse : Form
    {
        public bool isCompleted=false;
        public Reimburse()
        {
            InitializeComponent();
        }

        private void txtUrlAddr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                string strUrl = txtUrlAddr.Text.Trim();             
                webContent.Navigate(strUrl,false);
              
            }
        }

        private void webContent_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            try
            {
                #region 判断网页是否加载完毕
                if (webContent.ReadyState == WebBrowserReadyState.Complete)
                {
                    isCompleted = true;
                }
                else
                {
                    isCompleted = false;
                 }
                #endregion
                if (isCompleted)
                {

                    //foreach (HtmlElement item in webContent.Document.All)
                    //{
                    //    string str = item.Name;
                    //    if (str=="txtloginid" || str=="txtpwd" || str=="ok")
                    //    {
                    //        switch (str)
                    //        {
                    //            case "txtloginid":item.SetAttribute("value", "2307");
                    //                break;
                    //            case "txtpwd":item.SetAttribute("value", "xiangyu");
                    //                break;
                    //            case "ok":item.InvokeMember("onclick");
                    //                break;
                    //            default:
                    //                break;
                    //        }

                    //    }
                    ////}

                    #region 弹出窗口

                    #endregion
                    isCompleted = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }

        }
    }
}
