namespace FinMaSys.ShareForm
{
    partial class ContrDoMoudle
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblContrID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbContrExecStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTemo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "合同编号:";
            // 
            // lblContrID
            // 
            this.lblContrID.AutoSize = true;
            this.lblContrID.Location = new System.Drawing.Point(196, 46);
            this.lblContrID.Name = "lblContrID";
            this.lblContrID.Size = new System.Drawing.Size(62, 18);
            this.lblContrID.TabIndex = 1;
            this.lblContrID.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "收(付)款金额:";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(220, 178);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(182, 28);
            this.txtPayAmount.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Location = new System.Drawing.Point(288, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 39);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "合同执行状态:";
            // 
            // cbContrExecStatus
            // 
            this.cbContrExecStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContrExecStatus.FormattingEnabled = true;
            this.cbContrExecStatus.Location = new System.Drawing.Point(203, 85);
            this.cbContrExecStatus.Name = "cbContrExecStatus";
            this.cbContrExecStatus.Size = new System.Drawing.Size(202, 26);
            this.cbContrExecStatus.TabIndex = 5;
            this.cbContrExecStatus.DropDown += new System.EventHandler(this.cbContrExecStatus_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "选择日期：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(200, 134);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(204, 28);
            this.dtpDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "备注:";
            // 
            // txtTemo
            // 
            this.txtTemo.Location = new System.Drawing.Point(220, 228);
            this.txtTemo.Name = "txtTemo";
            this.txtTemo.Size = new System.Drawing.Size(182, 28);
            this.txtTemo.TabIndex = 3;
            // 
            // ContrDoMoudle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(536, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbContrExecStatus);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTemo);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContrID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContrDoMoudle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支付窗体";
            this.Load += new System.EventHandler(this.ContrDoMoudle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContrID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbContrExecStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTemo;
    }
}