using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinMaSys.Invoice
{
    class InvProcess
    {
        #region 公共变量部分
        private static string invNum;//发票号
        private static string invCode;//发票代码
        private static string invCkCode;//校验码
        private static string invDate;//开票日期
        private static string amount;//开票金额
        private static string invTaxAmount;//税额

        public static string InvNum { get => invNum; set => invNum = value; }
        public static string InvCode { get => invCode; set => invCode = value; }
        public static string InvCkCode { get => invCkCode; set => invCkCode = value; }
        public static string InvDate { get => invDate; set => invDate = value; }
        public static string Amount { get => amount; set => amount = value; }
        public static string InvTaxAmount { get => invTaxAmount; set => invTaxAmount = value; }


        #endregion



        #region 公共函数

        //发票二维码取值
        public void InvoiceProcess(string InvQrcode, string InvType)
        {
            InvCode = null;
            InvNum = null;
            Amount = null;
            InvDate = null;
            InvCkCode = null;
            string[] InvQrcodes = InvQrcode.Split(new char[] { '，' }); ;
         
            if (InvQrcodes.Length < 7 )
            {
                InvQrcodes = InvQrcode.Split(new char[] { ',' }); ;

            }
            MessageBox.Show(InvQrcodes.Length.ToString());
                    try
                    {
                        switch (InvType)
                        {
                            case "1": //增值税普通发票、电子发票
                                InvCode = InvQrcodes[2];
                                InvNum = InvQrcodes[3];
                                Amount = InvQrcodes[4];
                                InvDate = InvQrcodes[5];
                                InvCkCode = InvQrcodes[6];
                                break;
                            case "2"://增值税专用发票
                                InvCode = InvQrcodes[2];
                                InvNum = InvQrcodes[3];
                                Amount = InvQrcodes[4];
                                InvDate = InvQrcodes[5];
                                InvCkCode = "空";
                                break;

                            default:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("暂时不支持该类型发票，请选择手工录入！");
                        InvCode = "";
                        InvNum = "";
                        Amount = "";
                        InvDate = "";
                        InvCkCode = "";
            }
                
            


            //foreach (var item in InvQrcodes)
            //{
            //    MessageBox.Show(item);
            //}
      
      

        }
            #endregion
        
    }
}
