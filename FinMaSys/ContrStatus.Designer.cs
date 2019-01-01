namespace FinMaSys
{
    partial class ContrStatus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvContrStatus = new System.Windows.Forms.DataGridView();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnStatusSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvContrExcStatus = new System.Windows.Forms.DataGridView();
            this.txtExecStatus = new System.Windows.Forms.TextBox();
            this.btnExecStatusSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrStatus)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrExcStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvContrStatus);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.btnStatusSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(550, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合同状态";
            // 
            // dgvContrStatus
            // 
            this.dgvContrStatus.AllowUserToAddRows = false;
            this.dgvContrStatus.AllowUserToDeleteRows = false;
            this.dgvContrStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContrStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvContrStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrStatus.Location = new System.Drawing.Point(40, 113);
            this.dgvContrStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvContrStatus.Name = "dgvContrStatus";
            this.dgvContrStatus.ReadOnly = true;
            this.dgvContrStatus.RowTemplate.Height = 27;
            this.dgvContrStatus.Size = new System.Drawing.Size(454, 251);
            this.dgvContrStatus.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(133, 54);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(244, 28);
            this.txtStatus.TabIndex = 2;
            // 
            // btnStatusSave
            // 
            this.btnStatusSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStatusSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStatusSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatusSave.Location = new System.Drawing.Point(384, 50);
            this.btnStatusSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStatusSave.Name = "btnStatusSave";
            this.btnStatusSave.Size = new System.Drawing.Size(110, 38);
            this.btnStatusSave.TabIndex = 3;
            this.btnStatusSave.Text = "保存";
            this.btnStatusSave.UseVisualStyleBackColor = false;
            this.btnStatusSave.Click += new System.EventHandler(this.btnStatusSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "合同状态";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvContrExcStatus);
            this.groupBox2.Controls.Add(this.txtExecStatus);
            this.groupBox2.Controls.Add(this.btnExecStatusSave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(570, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(584, 371);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "合同执行状态";
            // 
            // dgvContrExcStatus
            // 
            this.dgvContrExcStatus.AllowUserToAddRows = false;
            this.dgvContrExcStatus.AllowUserToDeleteRows = false;
            this.dgvContrExcStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContrExcStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvContrExcStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrExcStatus.Location = new System.Drawing.Point(47, 100);
            this.dgvContrExcStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvContrExcStatus.Name = "dgvContrExcStatus";
            this.dgvContrExcStatus.ReadOnly = true;
            this.dgvContrExcStatus.RowTemplate.Height = 27;
            this.dgvContrExcStatus.Size = new System.Drawing.Size(506, 251);
            this.dgvContrExcStatus.TabIndex = 4;
            // 
            // txtExecStatus
            // 
            this.txtExecStatus.Location = new System.Drawing.Point(160, 41);
            this.txtExecStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExecStatus.Name = "txtExecStatus";
            this.txtExecStatus.Size = new System.Drawing.Size(244, 28);
            this.txtExecStatus.TabIndex = 2;
            // 
            // btnExecStatusSave
            // 
            this.btnExecStatusSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExecStatusSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecStatusSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExecStatusSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExecStatusSave.Location = new System.Drawing.Point(423, 36);
            this.btnExecStatusSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExecStatusSave.Name = "btnExecStatusSave";
            this.btnExecStatusSave.Size = new System.Drawing.Size(110, 38);
            this.btnExecStatusSave.TabIndex = 3;
            this.btnExecStatusSave.Text = "保存";
            this.btnExecStatusSave.UseVisualStyleBackColor = false;
            this.btnExecStatusSave.Click += new System.EventHandler(this.btnExecStatusSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "合同执行状态";
            // 
            // ContrStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContrStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合同状态设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ContrStatus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrStatus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrExcStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvContrStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnStatusSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvContrExcStatus;
        private System.Windows.Forms.TextBox txtExecStatus;
        private System.Windows.Forms.Button btnExecStatusSave;
        private System.Windows.Forms.Label label2;
    }
}