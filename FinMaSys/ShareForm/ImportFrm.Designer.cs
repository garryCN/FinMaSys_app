namespace FinMaSys.ShareForm
{
    partial class ImportFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHouseInfo = new System.Windows.Forms.RadioButton();
            this.rbRentExpense = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSheets = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnDelSelected = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择要导入的EXCEL表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrower);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(957, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXCEL连接设置";
            // 
            // btnBrower
            // 
            this.btnBrower.AutoSize = true;
            this.btnBrower.Location = new System.Drawing.Point(856, 83);
            this.btnBrower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(84, 34);
            this.btnBrower.TabIndex = 4;
            this.btnBrower.Text = "浏览";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(20, 82);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(817, 28);
            this.txtFilePath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Excel文件路径";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHouseInfo);
            this.groupBox2.Controls.Add(this.rbRentExpense);
            this.groupBox2.Location = new System.Drawing.Point(21, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(957, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导入项目";
            // 
            // rbHouseInfo
            // 
            this.rbHouseInfo.AutoSize = true;
            this.rbHouseInfo.Checked = true;
            this.rbHouseInfo.Location = new System.Drawing.Point(20, 43);
            this.rbHouseInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHouseInfo.Name = "rbHouseInfo";
            this.rbHouseInfo.Size = new System.Drawing.Size(105, 22);
            this.rbHouseInfo.TabIndex = 4;
            this.rbHouseInfo.TabStop = true;
            this.rbHouseInfo.Text = "房屋信息";
            this.rbHouseInfo.UseVisualStyleBackColor = true;
            // 
            // rbRentExpense
            // 
            this.rbRentExpense.AutoSize = true;
            this.rbRentExpense.Location = new System.Drawing.Point(268, 43);
            this.rbRentExpense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRentExpense.Name = "rbRentExpense";
            this.rbRentExpense.Size = new System.Drawing.Size(123, 22);
            this.rbRentExpense.TabIndex = 5;
            this.rbRentExpense.Text = "水电管理费";
            this.rbRentExpense.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.Location = new System.Drawing.Point(820, 783);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(142, 30);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "导入数据库";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbSheets);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnViewAll);
            this.groupBox3.Location = new System.Drawing.Point(21, 372);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(957, 403);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据编辑";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(791, 300);
            this.dataGridView1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 96);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(136, 299);
            this.treeView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "选择工作表";
            // 
            // cbSheets
            // 
            this.cbSheets.FormattingEnabled = true;
            this.cbSheets.Location = new System.Drawing.Point(106, 47);
            this.cbSheets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSheets.Name = "cbSheets";
            this.cbSheets.Size = new System.Drawing.Size(185, 26);
            this.cbSheets.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(490, 46);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnViewAll
            // 
            this.btnViewAll.AutoSize = true;
            this.btnViewAll.Location = new System.Drawing.Point(315, 46);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(137, 30);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "显示所有列";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // btnDelSelected
            // 
            this.btnDelSelected.Location = new System.Drawing.Point(28, 778);
            this.btnDelSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelSelected.Name = "btnDelSelected";
            this.btnDelSelected.Size = new System.Drawing.Size(136, 28);
            this.btnDelSelected.TabIndex = 0;
            this.btnDelSelected.Text = "删除所选项目";
            this.btnDelSelected.UseVisualStyleBackColor = true;
            // 
            // ImportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 830);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImportFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入数据";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHouseInfo;
        private System.Windows.Forms.RadioButton rbRentExpense;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSheets;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnDelSelected;
    }
}