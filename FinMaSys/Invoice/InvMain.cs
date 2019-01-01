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

namespace FinMaSys.Invoice
{
    public partial class InvMain : Form
    {
        public InvMain()
        {
            InitializeComponent();
        }

        private void InvMain_Load(object sender, EventArgs e)
        {
            rbKPDate.Checked = true;
            DataBase db = new DataBase();
            db.ConStr = "select * from [V_InviQuery]";
            DataTable dt = db.GetDataTable();
            if (dt.Rows.Count>0)
            {
                dgvInviMain.DataSource = dt;
            }

        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPageSize_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InvScanInput invScanInput = new InvScanInput();
            invScanInput.ShowDialog();
        }
    }
}
