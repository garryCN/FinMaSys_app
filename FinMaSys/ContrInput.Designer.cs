namespace FinMaSys
{
    partial class ContrInput
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContrInput));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.gbContrInfo = new System.Windows.Forms.GroupBox();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.qrCodeImg = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.lblQrcode = new System.Windows.Forms.Label();
            this.btnContrTerm = new System.Windows.Forms.Button();
            this.btnContrFile = new System.Windows.Forms.Button();
            this.rtbDemo = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbContrStatusID = new System.Windows.Forms.ComboBox();
            this.cbContrSmallType = new System.Windows.Forms.ComboBox();
            this.cbContrBigType = new System.Windows.Forms.ComboBox();
            this.cbDeptName = new System.Windows.Forms.ComboBox();
            this.dtpContrSignDate = new System.Windows.Forms.DateTimePicker();
            this.cbContrPayMethod = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbRePersID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblContrID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContrTerm = new System.Windows.Forms.TextBox();
            this.txtContrName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrAmount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtContrSubject = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvContrInfo = new System.Windows.Forms.DataGridView();
            this.epContrInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.txtQueryContent = new System.Windows.Forms.TextBox();
            this.dtpQueryDate = new System.Windows.Forms.DateTimePicker();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.gbContrInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContrInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNew,
            this.tsbQuery,
            this.tsbImport,
            this.tsbDel,
            this.tsbSave,
            this.tsbCancel,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1363, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "取消";
            // 
            // tsbAddNew
            // 
            this.tsbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddNew.Image")));
            this.tsbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNew.Name = "tsbAddNew";
            this.tsbAddNew.Size = new System.Drawing.Size(70, 54);
            this.tsbAddNew.Text = "新增";
            this.tsbAddNew.Click += new System.EventHandler(this.tsbAddNew_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(70, 54);
            this.tsbQuery.Text = "查询";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(70, 54);
            this.tsbImport.Text = "导入";
            // 
            // tsbDel
            // 
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(70, 54);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(70, 54);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(70, 54);
            this.tsbCancel.Text = "取消";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // gbContrInfo
            // 
            this.gbContrInfo.Controls.Add(this.cbUserName);
            this.gbContrInfo.Controls.Add(this.qrCodeImg);
            this.gbContrInfo.Controls.Add(this.lblQrcode);
            this.gbContrInfo.Controls.Add(this.btnContrTerm);
            this.gbContrInfo.Controls.Add(this.btnContrFile);
            this.gbContrInfo.Controls.Add(this.rtbDemo);
            this.gbContrInfo.Controls.Add(this.label18);
            this.gbContrInfo.Controls.Add(this.label19);
            this.gbContrInfo.Controls.Add(this.label17);
            this.gbContrInfo.Controls.Add(this.cbContrStatusID);
            this.gbContrInfo.Controls.Add(this.cbContrSmallType);
            this.gbContrInfo.Controls.Add(this.cbContrBigType);
            this.gbContrInfo.Controls.Add(this.cbDeptName);
            this.gbContrInfo.Controls.Add(this.dtpContrSignDate);
            this.gbContrInfo.Controls.Add(this.cbContrPayMethod);
            this.gbContrInfo.Controls.Add(this.label14);
            this.gbContrInfo.Controls.Add(this.cbRePersID);
            this.gbContrInfo.Controls.Add(this.label1);
            this.gbContrInfo.Controls.Add(this.label13);
            this.gbContrInfo.Controls.Add(this.lblContrID);
            this.gbContrInfo.Controls.Add(this.label3);
            this.gbContrInfo.Controls.Add(this.label12);
            this.gbContrInfo.Controls.Add(this.txtContrTerm);
            this.gbContrInfo.Controls.Add(this.txtContrName);
            this.gbContrInfo.Controls.Add(this.label4);
            this.gbContrInfo.Controls.Add(this.txtContrAmount);
            this.gbContrInfo.Controls.Add(this.label21);
            this.gbContrInfo.Controls.Add(this.txtContrSubject);
            this.gbContrInfo.Controls.Add(this.label10);
            this.gbContrInfo.Controls.Add(this.label20);
            this.gbContrInfo.Controls.Add(this.label5);
            this.gbContrInfo.Controls.Add(this.label6);
            this.gbContrInfo.Controls.Add(this.label7);
            this.gbContrInfo.Controls.Add(this.label9);
            this.gbContrInfo.Controls.Add(this.label8);
            this.gbContrInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbContrInfo.Location = new System.Drawing.Point(3, 59);
            this.gbContrInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbContrInfo.Name = "gbContrInfo";
            this.gbContrInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbContrInfo.Size = new System.Drawing.Size(1360, 412);
            this.gbContrInfo.TabIndex = 1;
            this.gbContrInfo.TabStop = false;
            // 
            // cbUserName
            // 
            this.cbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Location = new System.Drawing.Point(890, 169);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(121, 26);
            this.cbUserName.TabIndex = 65;
            this.cbUserName.Click += new System.EventHandler(this.cbUserName_Click);
            // 
            // qrCodeImg
            // 
            this.qrCodeImg.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrCodeImg.Image = ((System.Drawing.Image)(resources.GetObject("qrCodeImg.Image")));
            this.qrCodeImg.Location = new System.Drawing.Point(1173, 268);
            this.qrCodeImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qrCodeImg.Name = "qrCodeImg";
            this.qrCodeImg.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrCodeImg.Size = new System.Drawing.Size(122, 113);
            this.qrCodeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrCodeImg.TabIndex = 64;
            this.qrCodeImg.TabStop = false;
            this.qrCodeImg.Text = "尚未生成合同编码";
            this.qrCodeImg.UseWaitCursor = true;
            // 
            // lblQrcode
            // 
            this.lblQrcode.AutoSize = true;
            this.lblQrcode.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQrcode.Location = new System.Drawing.Point(1186, 385);
            this.lblQrcode.Name = "lblQrcode";
            this.lblQrcode.Size = new System.Drawing.Size(99, 19);
            this.lblQrcode.TabIndex = 63;
            this.lblQrcode.Text = "尚未生成编码";
            // 
            // btnContrTerm
            // 
            this.btnContrTerm.AutoSize = true;
            this.btnContrTerm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnContrTerm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnContrTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrTerm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnContrTerm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContrTerm.Location = new System.Drawing.Point(109, 219);
            this.btnContrTerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContrTerm.Name = "btnContrTerm";
            this.btnContrTerm.Size = new System.Drawing.Size(169, 37);
            this.btnContrTerm.TabIndex = 13;
            this.btnContrTerm.TabStop = false;
            this.btnContrTerm.Text = "上传会签单";
            this.btnContrTerm.UseVisualStyleBackColor = false;
            this.btnContrTerm.Click += new System.EventHandler(this.btnContrTerm_Click);
            this.btnContrTerm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnContrTerm_KeyUp);
            // 
            // btnContrFile
            // 
            this.btnContrFile.AutoSize = true;
            this.btnContrFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnContrFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnContrFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnContrFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContrFile.Location = new System.Drawing.Point(408, 219);
            this.btnContrFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContrFile.Name = "btnContrFile";
            this.btnContrFile.Size = new System.Drawing.Size(150, 37);
            this.btnContrFile.TabIndex = 15;
            this.btnContrFile.Text = "上传合同扫描件";
            this.btnContrFile.UseVisualStyleBackColor = false;
            this.btnContrFile.Click += new System.EventHandler(this.btnContrFile_Click);
            this.btnContrFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnContrFile_KeyUp);
            // 
            // rtbDemo
            // 
            this.rtbDemo.ForeColor = System.Drawing.Color.Gray;
            this.rtbDemo.Location = new System.Drawing.Point(109, 268);
            this.rtbDemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDemo.Name = "rtbDemo";
            this.rtbDemo.Size = new System.Drawing.Size(1030, 120);
            this.rtbDemo.TabIndex = 16;
            this.rtbDemo.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 18);
            this.label18.TabIndex = 52;
            this.label18.Text = "合同会签";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 282);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 18);
            this.label19.TabIndex = 50;
            this.label19.Text = "备注";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(322, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 18);
            this.label17.TabIndex = 51;
            this.label17.Text = "合同上传";
            // 
            // cbContrStatusID
            // 
            this.cbContrStatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContrStatusID.FormattingEnabled = true;
            this.cbContrStatusID.Location = new System.Drawing.Point(1126, 168);
            this.cbContrStatusID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbContrStatusID.Name = "cbContrStatusID";
            this.cbContrStatusID.Size = new System.Drawing.Size(192, 26);
            this.cbContrStatusID.TabIndex = 11;
            this.cbContrStatusID.Click += new System.EventHandler(this.cbContrStatusID_Click);
            this.cbContrStatusID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbContrStatusID_KeyUp);
            // 
            // cbContrSmallType
            // 
            this.cbContrSmallType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContrSmallType.FormattingEnabled = true;
            this.cbContrSmallType.Location = new System.Drawing.Point(695, 168);
            this.cbContrSmallType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbContrSmallType.Name = "cbContrSmallType";
            this.cbContrSmallType.Size = new System.Drawing.Size(96, 26);
            this.cbContrSmallType.TabIndex = 9;
            this.cbContrSmallType.Click += new System.EventHandler(this.cbContrSmallType_Click);
            this.cbContrSmallType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbContrSmallType_KeyUp);
            // 
            // cbContrBigType
            // 
            this.cbContrBigType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContrBigType.FormattingEnabled = true;
            this.cbContrBigType.Location = new System.Drawing.Point(498, 167);
            this.cbContrBigType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbContrBigType.Name = "cbContrBigType";
            this.cbContrBigType.Size = new System.Drawing.Size(104, 26);
            this.cbContrBigType.TabIndex = 8;
            this.cbContrBigType.Click += new System.EventHandler(this.cbContrBigType_Click);
            this.cbContrBigType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbContrBigType_KeyUp);
            // 
            // cbDeptName
            // 
            this.cbDeptName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeptName.FormattingEnabled = true;
            this.cbDeptName.Location = new System.Drawing.Point(1127, 102);
            this.cbDeptName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDeptName.Name = "cbDeptName";
            this.cbDeptName.Size = new System.Drawing.Size(191, 26);
            this.cbDeptName.TabIndex = 6;
            this.cbDeptName.Click += new System.EventHandler(this.cbDeptName_Click);
            this.cbDeptName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbDeptName_KeyUp);
            // 
            // dtpContrSignDate
            // 
            this.dtpContrSignDate.Location = new System.Drawing.Point(828, 101);
            this.dtpContrSignDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpContrSignDate.Name = "dtpContrSignDate";
            this.dtpContrSignDate.Size = new System.Drawing.Size(174, 28);
            this.dtpContrSignDate.TabIndex = 5;
            this.dtpContrSignDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpContrSignDate_KeyUp);
            // 
            // cbContrPayMethod
            // 
            this.cbContrPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContrPayMethod.FormattingEnabled = true;
            this.cbContrPayMethod.Items.AddRange(new object[] {
            "一次性付全款",
            "分期付款(按月支付)",
            "分期付款(按年支付)"});
            this.cbContrPayMethod.Location = new System.Drawing.Point(561, 102);
            this.cbContrPayMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbContrPayMethod.Name = "cbContrPayMethod";
            this.cbContrPayMethod.Size = new System.Drawing.Size(172, 26);
            this.cbContrPayMethod.TabIndex = 4;
            this.cbContrPayMethod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbContrPayMethod_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1040, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 48;
            this.label14.Text = "合同状态";
            // 
            // cbRePersID
            // 
            this.cbRePersID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRePersID.FormattingEnabled = true;
            this.cbRePersID.Location = new System.Drawing.Point(122, 102);
            this.cbRePersID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRePersID.Name = "cbRePersID";
            this.cbRePersID.Size = new System.Drawing.Size(349, 26);
            this.cbRePersID.TabIndex = 3;
            this.cbRePersID.Click += new System.EventHandler(this.cbRePersID_Click);
            this.cbRePersID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbRePersID_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "合同编码";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(822, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 47;
            this.label13.Text = "经办人";
            // 
            // lblContrID
            // 
            this.lblContrID.AutoSize = true;
            this.lblContrID.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContrID.ForeColor = System.Drawing.Color.Red;
            this.lblContrID.Location = new System.Drawing.Point(110, 43);
            this.lblContrID.Name = "lblContrID";
            this.lblContrID.Size = new System.Drawing.Size(30, 20);
            this.lblContrID.TabIndex = 33;
            this.lblContrID.Text = "无";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "合同名称";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(609, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 46;
            this.label12.Text = "合同小类";
            // 
            // txtContrTerm
            // 
            this.txtContrTerm.Location = new System.Drawing.Point(109, 167);
            this.txtContrTerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrTerm.Name = "txtContrTerm";
            this.txtContrTerm.Size = new System.Drawing.Size(289, 28);
            this.txtContrTerm.TabIndex = 7;
            this.txtContrTerm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContrTerm_KeyUp);
            // 
            // txtContrName
            // 
            this.txtContrName.Location = new System.Drawing.Point(322, 40);
            this.txtContrName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrName.Name = "txtContrName";
            this.txtContrName.Size = new System.Drawing.Size(327, 28);
            this.txtContrName.TabIndex = 0;
            this.txtContrName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContrName_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "合同标的";
            // 
            // txtContrAmount
            // 
            this.txtContrAmount.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContrAmount.Location = new System.Drawing.Point(1163, 38);
            this.txtContrAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrAmount.Name = "txtContrAmount";
            this.txtContrAmount.Size = new System.Drawing.Size(146, 33);
            this.txtContrAmount.TabIndex = 2;
            this.txtContrAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContrAmount_KeyUp);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(413, 172);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 18);
            this.label21.TabIndex = 45;
            this.label21.Text = "合同大类";
            // 
            // txtContrSubject
            // 
            this.txtContrSubject.Location = new System.Drawing.Point(745, 40);
            this.txtContrSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrSubject.Name = "txtContrSubject";
            this.txtContrSubject.Size = new System.Drawing.Size(313, 28);
            this.txtContrSubject.TabIndex = 1;
            this.txtContrSubject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContrSubject_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "合同期限";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1308, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 18);
            this.label20.TabIndex = 39;
            this.label20.Text = "元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1081, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "合同金额";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "合同相对方";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "付款方式";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1040, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 43;
            this.label9.Text = "经办科室";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(739, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "签订日期";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvContrInfo);
            this.groupBox2.Location = new System.Drawing.Point(0, 485);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1372, 315);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "合同列表";
            // 
            // dgvContrInfo
            // 
            this.dgvContrInfo.AllowUserToAddRows = false;
            this.dgvContrInfo.AllowUserToDeleteRows = false;
            this.dgvContrInfo.AllowUserToOrderColumns = true;
            this.dgvContrInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContrInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvContrInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvContrInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrInfo.Location = new System.Drawing.Point(20, 28);
            this.dgvContrInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvContrInfo.Name = "dgvContrInfo";
            this.dgvContrInfo.ReadOnly = true;
            this.dgvContrInfo.RowTemplate.Height = 27;
            this.dgvContrInfo.Size = new System.Drawing.Size(1343, 274);
            this.dgvContrInfo.TabIndex = 1;
            this.dgvContrInfo.Click += new System.EventHandler(this.dgvContrInfo_Click);
            // 
            // epContrInfo
            // 
            this.epContrInfo.ContainerControl = this;
            // 
            // cbCondition
            // 
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "合同编码",
            "合同名称",
            "合同相对方",
            "合同标的",
            "签订日期大于",
            "签订日期小于",
            "付款方式",
            "合同大类",
            "合同小类",
            "经办人",
            "合同状态"});
            this.cbCondition.Location = new System.Drawing.Point(654, 12);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(274, 26);
            this.cbCondition.TabIndex = 3;
            this.cbCondition.Visible = false;
            this.cbCondition.TextChanged += new System.EventHandler(this.cbCondition_TextChanged);
            // 
            // txtQueryContent
            // 
            this.txtQueryContent.Location = new System.Drawing.Point(975, 12);
            this.txtQueryContent.Name = "txtQueryContent";
            this.txtQueryContent.Size = new System.Drawing.Size(313, 28);
            this.txtQueryContent.TabIndex = 4;
            this.txtQueryContent.Visible = false;
            this.txtQueryContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQueryContent_KeyUp);
            // 
            // dtpQueryDate
            // 
            this.dtpQueryDate.Location = new System.Drawing.Point(975, 12);
            this.dtpQueryDate.Name = "dtpQueryDate";
            this.dtpQueryDate.Size = new System.Drawing.Size(313, 28);
            this.dtpQueryDate.TabIndex = 5;
            this.dtpQueryDate.Visible = false;
            this.dtpQueryDate.ValueChanged += new System.EventHandler(this.dtpQueryDate_ValueChanged);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Enabled = false;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(70, 54);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // ContrInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1368, 816);
            this.Controls.Add(this.dtpQueryDate);
            this.Controls.Add(this.txtQueryContent);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbContrInfo);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContrInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合同录入";
            this.Load += new System.EventHandler(this.ContrInput_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbContrInfo.ResumeLayout(false);
            this.gbContrInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContrInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddNew;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.GroupBox gbContrInfo;
        private System.Windows.Forms.Button btnContrTerm;
        private System.Windows.Forms.Button btnContrFile;
        private System.Windows.Forms.RichTextBox rtbDemo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbContrStatusID;
        private System.Windows.Forms.ComboBox cbContrSmallType;
        private System.Windows.Forms.ComboBox cbContrBigType;
        private System.Windows.Forms.ComboBox cbDeptName;
        private System.Windows.Forms.DateTimePicker dtpContrSignDate;
        private System.Windows.Forms.ComboBox cbContrPayMethod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbRePersID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblContrID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContrTerm;
        private System.Windows.Forms.TextBox txtContrName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContrAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtContrSubject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvContrInfo;
        private System.Windows.Forms.Label lblQrcode;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrCodeImg;
        private System.Windows.Forms.ErrorProvider epContrInfo;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.TextBox txtQueryContent;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.DateTimePicker dtpQueryDate;
        private System.Windows.Forms.ToolStripButton tsbPrint;
    }
}