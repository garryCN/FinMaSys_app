namespace FinMaSys
{
    partial class ContrRePerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContrRePerson));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRePersonID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRePersonName = new System.Windows.Forms.TextBox();
            this.cbRePersonType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAccNum = new System.Windows.Forms.TextBox();
            this.tbOpenBank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRePerson = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbEdit,
            this.tsbDel,
            this.tsbQuery,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1030, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(70, 28);
            this.tsbNew.Text = "增加";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(70, 28);
            this.tsbEdit.Text = "修改";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(70, 28);
            this.tsbDel.Text = "封存";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(70, 28);
            this.tsbQuery.Text = "查询";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(70, 28);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "客商编码";
            // 
            // lblRePersonID
            // 
            this.lblRePersonID.AutoSize = true;
            this.lblRePersonID.BackColor = System.Drawing.SystemColors.Control;
            this.lblRePersonID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRePersonID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRePersonID.ForeColor = System.Drawing.Color.Red;
            this.lblRePersonID.Location = new System.Drawing.Point(71, 68);
            this.lblRePersonID.Name = "lblRePersonID";
            this.lblRePersonID.Size = new System.Drawing.Size(28, 31);
            this.lblRePersonID.TabIndex = 2;
            this.lblRePersonID.Text = "  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "客商名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "客商类型";
            // 
            // txtRePersonName
            // 
            this.txtRePersonName.Location = new System.Drawing.Point(260, 43);
            this.txtRePersonName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRePersonName.Name = "txtRePersonName";
            this.txtRePersonName.Size = new System.Drawing.Size(295, 28);
            this.txtRePersonName.TabIndex = 5;
            // 
            // cbRePersonType
            // 
            this.cbRePersonType.FormattingEnabled = true;
            this.cbRePersonType.Items.AddRange(new object[] {
            "供应商",
            "客户"});
            this.cbRePersonType.Location = new System.Drawing.Point(646, 43);
            this.cbRePersonType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRePersonType.Name = "cbRePersonType";
            this.cbRePersonType.Size = new System.Drawing.Size(259, 26);
            this.cbRePersonType.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbRePersonType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbAccNum);
            this.panel1.Controls.Add(this.tbOpenBank);
            this.panel1.Controls.Add(this.txtRePersonName);
            this.panel1.Controls.Add(this.lblRePersonID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 150);
            this.panel1.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(934, 88);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 44);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "帐号";
            // 
            // tbAccNum
            // 
            this.tbAccNum.Location = new System.Drawing.Point(646, 92);
            this.tbAccNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAccNum.Name = "tbAccNum";
            this.tbAccNum.Size = new System.Drawing.Size(259, 28);
            this.tbAccNum.TabIndex = 5;
            // 
            // tbOpenBank
            // 
            this.tbOpenBank.Location = new System.Drawing.Point(261, 92);
            this.tbOpenBank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOpenBank.Name = "tbOpenBank";
            this.tbOpenBank.Size = new System.Drawing.Size(295, 28);
            this.tbOpenBank.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "开户行";
            // 
            // dgvRePerson
            // 
            this.dgvRePerson.AllowUserToAddRows = false;
            this.dgvRePerson.AllowUserToDeleteRows = false;
            this.dgvRePerson.AllowUserToOrderColumns = true;
            this.dgvRePerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRePerson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRePerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRePerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRePerson.Location = new System.Drawing.Point(0, 181);
            this.dgvRePerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRePerson.Name = "dgvRePerson";
            this.dgvRePerson.ReadOnly = true;
            this.dgvRePerson.RowTemplate.Height = 27;
            this.dgvRePerson.Size = new System.Drawing.Size(1030, 492);
            this.dgvRePerson.TabIndex = 8;
            this.dgvRePerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRePerson_CellDoubleClick);
            this.dgvRePerson.Click += new System.EventHandler(this.dgvRePerson_Click);
            // 
            // ContrRePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 673);
            this.Controls.Add(this.dgvRePerson);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContrRePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客商管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ContrRePerson_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRePerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRePersonID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRePersonName;
        private System.Windows.Forms.ComboBox cbRePersonType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRePerson;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAccNum;
        private System.Windows.Forms.TextBox tbOpenBank;
        private System.Windows.Forms.Label label2;
    }
}