using Gma.QrCodeNet.Encoding.Windows.Forms;

namespace FinMaSys
{
    partial class QueryPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryPrintForm));
            this.pd1 = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrintSetup = new System.Windows.Forms.ToolStripButton();
            this.tsbPageSetup = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.rbContrQrcode = new System.Windows.Forms.RadioButton();
            this.rbContrFile = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qrCodeGC = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pd1
            // 
            this.pd1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd1_PrintPage);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrintSetup,
            this.tsbPageSetup,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(561, 31);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrintSetup
            // 
            this.tsbPrintSetup.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintSetup.Image")));
            this.tsbPrintSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintSetup.Name = "tsbPrintSetup";
            this.tsbPrintSetup.Size = new System.Drawing.Size(110, 28);
            this.tsbPrintSetup.Text = "打印设置";
            this.tsbPrintSetup.Click += new System.EventHandler(this.tsbPrintSetup_Click);
            // 
            // tsbPageSetup
            // 
            this.tsbPageSetup.Image = ((System.Drawing.Image)(resources.GetObject("tsbPageSetup.Image")));
            this.tsbPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPageSetup.Name = "tsbPageSetup";
            this.tsbPageSetup.Size = new System.Drawing.Size(110, 28);
            this.tsbPageSetup.Text = "页面设置";
            this.tsbPageSetup.Click += new System.EventHandler(this.tsbPageSetup_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(74, 28);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // rbContrQrcode
            // 
            this.rbContrQrcode.AutoSize = true;
            this.rbContrQrcode.Checked = true;
            this.rbContrQrcode.Location = new System.Drawing.Point(20, 52);
            this.rbContrQrcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbContrQrcode.Name = "rbContrQrcode";
            this.rbContrQrcode.Size = new System.Drawing.Size(123, 22);
            this.rbContrQrcode.TabIndex = 6;
            this.rbContrQrcode.TabStop = true;
            this.rbContrQrcode.Text = "合同二维码";
            this.rbContrQrcode.UseVisualStyleBackColor = true;
            this.rbContrQrcode.Click += new System.EventHandler(this.rbContrQrcode_Click);
            // 
            // rbContrFile
            // 
            this.rbContrFile.AutoSize = true;
            this.rbContrFile.Location = new System.Drawing.Point(183, 52);
            this.rbContrFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbContrFile.Name = "rbContrFile";
            this.rbContrFile.Size = new System.Drawing.Size(123, 22);
            this.rbContrFile.TabIndex = 7;
            this.rbContrFile.TabStop = true;
            this.rbContrFile.Text = "合同扫描件";
            this.rbContrFile.UseVisualStyleBackColor = true;
            this.rbContrFile.Click += new System.EventHandler(this.rbContrFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbContrFile);
            this.groupBox1.Controls.Add(this.rbContrQrcode);
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(334, 168);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(396, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // qrCodeGC
            // 
            this.qrCodeGC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.qrCodeGC.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.L;
            this.qrCodeGC.Location = new System.Drawing.Point(364, 74);
            this.qrCodeGC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qrCodeGC.Name = "qrCodeGC";
            this.qrCodeGC.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Four;
            this.qrCodeGC.Size = new System.Drawing.Size(145, 125);
            this.qrCodeGC.TabIndex = 13;
            this.qrCodeGC.Text = "qrCodeGraphicControl1";
            this.qrCodeGC.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 104);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 22);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "条形码";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.rbContrFile_Click);
            // 
            // QueryPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(561, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.qrCodeGC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryPrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印";
            this.Load += new System.EventHandler(this.QueryPrintForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument pd1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrintSetup;
        private System.Windows.Forms.ToolStripButton tsbPageSetup;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.RadioButton rbContrQrcode;
        private System.Windows.Forms.RadioButton rbContrFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private QrCodeGraphicControl qrCodeGC;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}