namespace FinMaSys.Contr
{
    partial class ContrSide
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
            this.dgvConstrSideView = new System.Windows.Forms.DataGridView();
            this.dtpSideDate = new System.Windows.Forms.DateTimePicker();
            this.txtContrId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrSideContent = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContrSideID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblContrName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstrSideView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConstrSideView
            // 
            this.dgvConstrSideView.AllowUserToAddRows = false;
            this.dgvConstrSideView.AllowUserToDeleteRows = false;
            this.dgvConstrSideView.AllowUserToOrderColumns = true;
            this.dgvConstrSideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConstrSideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConstrSideView.Location = new System.Drawing.Point(15, 30);
            this.dgvConstrSideView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConstrSideView.MultiSelect = false;
            this.dgvConstrSideView.Name = "dgvConstrSideView";
            this.dgvConstrSideView.ReadOnly = true;
            this.dgvConstrSideView.RowTemplate.Height = 23;
            this.dgvConstrSideView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConstrSideView.Size = new System.Drawing.Size(1125, 506);
            this.dgvConstrSideView.TabIndex = 3;
            this.dgvConstrSideView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConstrSideView_CellClick);
            // 
            // dtpSideDate
            // 
            this.dtpSideDate.Location = new System.Drawing.Point(164, 348);
            this.dtpSideDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpSideDate.Name = "dtpSideDate";
            this.dtpSideDate.Size = new System.Drawing.Size(199, 28);
            this.dtpSideDate.TabIndex = 2;
            // 
            // txtContrId
            // 
            this.txtContrId.Location = new System.Drawing.Point(164, 34);
            this.txtContrId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrId.Name = "txtContrId";
            this.txtContrId.Size = new System.Drawing.Size(403, 28);
            this.txtContrId.TabIndex = 0;
            this.txtContrId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrId_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "主合同编号";
            // 
            // txtContrSideContent
            // 
            this.txtContrSideContent.Location = new System.Drawing.Point(164, 168);
            this.txtContrSideContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrSideContent.Multiline = true;
            this.txtContrSideContent.Name = "txtContrSideContent";
            this.txtContrSideContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContrSideContent.Size = new System.Drawing.Size(403, 144);
            this.txtContrSideContent.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(164, 416);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(405, 34);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "上传补充协议";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "变更内容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "签定日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "点击上传";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "补充协议编码";
            // 
            // lblContrSideID
            // 
            this.lblContrSideID.AutoSize = true;
            this.lblContrSideID.Location = new System.Drawing.Point(160, 129);
            this.lblContrSideID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrSideID.Name = "lblContrSideID";
            this.lblContrSideID.Size = new System.Drawing.Size(0, 18);
            this.lblContrSideID.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContrId);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.dtpSideDate);
            this.groupBox1.Controls.Add(this.txtContrSideContent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblContrName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblContrSideID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 567);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息维护";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(21, 501);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(112, 34);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "新增";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 501);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(141, 501);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(261, 501);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 34);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(501, 501);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvConstrSideView);
            this.groupBox2.Location = new System.Drawing.Point(704, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1152, 567);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果显示";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "主合同名称";
            // 
            // lblContrName
            // 
            this.lblContrName.AutoSize = true;
            this.lblContrName.Location = new System.Drawing.Point(161, 85);
            this.lblContrName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrName.Name = "lblContrName";
            this.lblContrName.Size = new System.Drawing.Size(0, 18);
            this.lblContrName.TabIndex = 4;
            // 
            // ContrSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContrSide";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "补充协议管理";
            this.Load += new System.EventHandler(this.ContrSide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstrSideView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConstrSideView;
        private System.Windows.Forms.DateTimePicker dtpSideDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtContrId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrSideContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContrSideID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblContrName;
        private System.Windows.Forms.Label label6;
    }
}