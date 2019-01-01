
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

namespace FinMaSys
{
    public partial class PowerGroup : Form
    {

        public PowerGroup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerGroup));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tvOperator = new System.Windows.Forms.TreeView();
            this.tvMoudles = new System.Windows.Forms.TreeView();
            this.dgvPower = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPower)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(79, 28);
            this.tsbSave.Text = " 保存";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(74, 28);
            this.tsbExit.Text = "退出";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.52234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.47766F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel1.Controls.Add(this.tvOperator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tvMoudles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPower, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 460);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tvOperator
            // 
            this.tvOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOperator.Location = new System.Drawing.Point(3, 3);
            this.tvOperator.Name = "tvOperator";
            this.tvOperator.Size = new System.Drawing.Size(160, 454);
            this.tvOperator.TabIndex = 0;
            // 
            // tvMoudles
            // 
            this.tvMoudles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMoudles.Location = new System.Drawing.Point(169, 3);
            this.tvMoudles.Name = "tvMoudles";
            this.tvMoudles.Size = new System.Drawing.Size(410, 454);
            this.tvMoudles.TabIndex = 0;
            // 
            // dgvPower
            // 
            this.dgvPower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPower.Location = new System.Drawing.Point(585, 3);
            this.dgvPower.Name = "dgvPower";
            this.dgvPower.RowTemplate.Height = 30;
            this.dgvPower.Size = new System.Drawing.Size(416, 454);
            this.dgvPower.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "操作权限";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "授权";
            this.Column2.Name = "Column2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "open.ico");
            this.imageList1.Images.SetKeyName(1, "close.ico");
            // 
            // PowerGroup
            // 
            this.ClientSize = new System.Drawing.Size(1028, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowerGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作权限";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PowerGroup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PowerGroup_Load(object sender, EventArgs e)
        {
            PowerClass powerClass = new PowerClass();
            //绑定用户树控件
            powerClass.BuildTree(tvOperator, imageList1, "用户", "select userid,username from tb_users where statusid=4 and userid<>'admin'");
            //绑定权限树控件
            powerClass.BuildTree(tvMoudles, imageList1, "功能模块", "select userPowerID,userPowerName from tb_Power");
            //绑定权限设置
            //powerClass.BindCombox();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
