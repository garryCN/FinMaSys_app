using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMaSys.ComClass
{
    class PowerClass
    {
        DataBase dataBase = new DataBase();
        public PowerClass()
        {
        }
        ///<summary>
        ///TreeView控件绑定到数据源
        /// </summary>
        /// <param name="tv">TreeView控件</param>
        /// <param name="imageList">ImageList控件</param>
        ///<param name="rootName">根节点的文本属性值</param> 
        ///<param name="strTable">要绑定的数据表</param>
        ///<param name="strCode">数据表的代码列</param>
        ///<param name="strName">数据表的名称列</param>
        public void BuildTree(TreeView tv, ImageList imgList, string rootName, string strSql)
        {
            
            dataBase.ConStr = strSql;
            DataTable dt = dataBase.GetDataTable();
            tv.Nodes.Clear();
            tv.ImageList = imgList;
            //创建根节点
            TreeNode rootNode = new TreeNode();
            rootNode.Text = rootName;
            rootNode.SelectedImageIndex = 0;
            rootNode.ImageIndex = 1;
            try
            {
                if (dt.Rows.Count>0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        //创建子节点
                       TreeNode childNode = new TreeNode();
                        childNode.Tag = row[0];
                        childNode.Text = row[1].ToString();
                        childNode.ImageIndex = 1;
                        childNode.SelectedImageIndex = 0;
                        rootNode.Nodes.Add(childNode);
                    }
                    tv.Nodes.Add(rootNode);
                    tv.ExpandAll();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// ComboBox或DataGridViewComboBoxColumn绑定到数据源
        /// </summary>
        /// <param name="obj">要绑定数据源的控件</param>
        /// <param name="strValueColumn">ValueMember属性要绑定的列名称</param>
        /// <param name="strTextColumn">DisplayMember属性要绑定的列名称</param>
        /// <param name="strSql">SQL查询语句</param>
        /// <param name="strTable">数据表的名称</param>
        public void BindCombox(object obj,string strValueColumn,string strTextColumn,string strSql)
        {
            try
            {
                string strType = obj.GetType().ToString();
                strType = strType.Substring(strType.LastIndexOf(".") + 1);
                //判断控件类型
                dataBase.ConStr = strSql;
                DataTable dt = dataBase.GetDataTable();
                switch (strType)
                {
                    case"ComboBox":
                        ComboBox cbx = (ComboBox)obj;
                        cbx.BeginUpdate();
                        cbx.DataSource = dt;
                        cbx.DisplayMember = strTextColumn;
                        cbx.ValueMember = strValueColumn;
                        cbx.EndUpdate();
                        break;
                    case "DataGridViewComboBoxColumn":
                        DataGridViewComboBoxColumn dgvcbx = (DataGridViewComboBoxColumn)obj;
                        dgvcbx.DataSource = dt;
                        dgvcbx.DisplayMember = strTextColumn;
                        dgvcbx.ValueMember = strValueColumn;
                        break;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
