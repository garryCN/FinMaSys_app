namespace FinMaSys
{
    partial class ContrType
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
            this.cmsContr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.禁用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbContrBigType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddSmallNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSmallType = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBigNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBigType = new System.Windows.Forms.TextBox();
            this.dgvContrType = new System.Windows.Forms.DataGridView();
            this.cmsContr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrType)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsContr
            // 
            this.cmsContr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsContr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.禁用ToolStripMenuItem});
            this.cmsContr.Name = "cmsContr";
            this.cmsContr.Size = new System.Drawing.Size(199, 93);
            this.cmsContr.Opened += new System.EventHandler(this.cmsContr_Opened);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.修改ToolStripMenuItem.Text = "修改分类";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 禁用ToolStripMenuItem
            // 
            this.禁用ToolStripMenuItem.Name = "禁用ToolStripMenuItem";
            this.禁用ToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.禁用ToolStripMenuItem.Text = "禁用分类";
            this.禁用ToolStripMenuItem.Click += new System.EventHandler(this.禁用ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbContrBigType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnAddSmallNew);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSmallType);
            this.groupBox1.Location = new System.Drawing.Point(30, 209);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(683, 174);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "小类维护：请选择大类后再添加小类";
            // 
            // cbContrBigType
            // 
            this.cbContrBigType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContrBigType.FormattingEnabled = true;
            this.cbContrBigType.Location = new System.Drawing.Point(169, 58);
            this.cbContrBigType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbContrBigType.Name = "cbContrBigType";
            this.cbContrBigType.Size = new System.Drawing.Size(303, 26);
            this.cbContrBigType.TabIndex = 17;
            this.cbContrBigType.Click += new System.EventHandler(this.cbContrBigType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "合同大类";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(516, 104);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 44);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddSmallNew
            // 
            this.btnAddSmallNew.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSmallNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSmallNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddSmallNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSmallNew.Location = new System.Drawing.Point(516, 48);
            this.btnAddSmallNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSmallNew.Name = "btnAddSmallNew";
            this.btnAddSmallNew.Size = new System.Drawing.Size(125, 44);
            this.btnAddSmallNew.TabIndex = 15;
            this.btnAddSmallNew.Text = "新增";
            this.btnAddSmallNew.UseVisualStyleBackColor = false;
            this.btnAddSmallNew.Click += new System.EventHandler(this.btnAddSmallNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "合同小类";
            // 
            // txtSmallType
            // 
            this.txtSmallType.Location = new System.Drawing.Point(169, 114);
            this.txtSmallType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSmallType.Name = "txtSmallType";
            this.txtSmallType.Size = new System.Drawing.Size(303, 28);
            this.txtSmallType.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBigNew);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBigType);
            this.groupBox2.Location = new System.Drawing.Point(30, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(683, 162);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "大类维护：请在下框中输入需要添加的合同大类";
            // 
            // btnAddBigNew
            // 
            this.btnAddBigNew.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddBigNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBigNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddBigNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddBigNew.Location = new System.Drawing.Point(516, 70);
            this.btnAddBigNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBigNew.Name = "btnAddBigNew";
            this.btnAddBigNew.Size = new System.Drawing.Size(132, 44);
            this.btnAddBigNew.TabIndex = 15;
            this.btnAddBigNew.Text = "新增";
            this.btnAddBigNew.UseVisualStyleBackColor = false;
            this.btnAddBigNew.Click += new System.EventHandler(this.btnAddBigNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "合同类别";
            // 
            // txtBigType
            // 
            this.txtBigType.Location = new System.Drawing.Point(169, 77);
            this.txtBigType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBigType.Name = "txtBigType";
            this.txtBigType.Size = new System.Drawing.Size(303, 28);
            this.txtBigType.TabIndex = 13;
            // 
            // dgvContrType
            // 
            this.dgvContrType.AllowUserToAddRows = false;
            this.dgvContrType.AllowUserToDeleteRows = false;
            this.dgvContrType.AllowUserToOrderColumns = true;
            this.dgvContrType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContrType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvContrType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrType.ContextMenuStrip = this.cmsContr;
            this.dgvContrType.Location = new System.Drawing.Point(30, 408);
            this.dgvContrType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvContrType.Name = "dgvContrType";
            this.dgvContrType.ReadOnly = true;
            this.dgvContrType.RowTemplate.Height = 27;
            this.dgvContrType.Size = new System.Drawing.Size(693, 302);
            this.dgvContrType.TabIndex = 9;
            // 
            // ContrType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 725);
            this.Controls.Add(this.dgvContrType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContrType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合同分类设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ContrType_Load);
            this.cmsContr.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSmallNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSmallType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddBigNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBigType;
        private System.Windows.Forms.ContextMenuStrip cmsContr;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 禁用ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbContrBigType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContrType;
        private System.Windows.Forms.Button btnRefresh;
    }
}