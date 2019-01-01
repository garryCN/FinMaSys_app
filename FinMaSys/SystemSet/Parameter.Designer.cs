namespace FinMaSys
{
    partial class Parameter
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCollection = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUserDiss = new System.Windows.Forms.ComboBox();
            this.cbUserAble = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCollection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 323);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCollection);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCollection
            // 
            this.tpCollection.Controls.Add(this.btnSave);
            this.tpCollection.Controls.Add(this.label4);
            this.tpCollection.Controls.Add(this.label3);
            this.tpCollection.Controls.Add(this.cbUserDiss);
            this.tpCollection.Controls.Add(this.cbUserAble);
            this.tpCollection.Controls.Add(this.label2);
            this.tpCollection.Controls.Add(this.label1);
            this.tpCollection.Controls.Add(this.txtCoName);
            this.tpCollection.Location = new System.Drawing.Point(4, 25);
            this.tpCollection.Name = "tpCollection";
            this.tpCollection.Size = new System.Drawing.Size(434, 292);
            this.tpCollection.TabIndex = 0;
            this.tpCollection.Text = "使用单位";
            this.tpCollection.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(249, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "锁定";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "正常";
            // 
            // cbUserDiss
            // 
            this.cbUserDiss.FormattingEnabled = true;
            this.cbUserDiss.Location = new System.Drawing.Point(106, 187);
            this.cbUserDiss.Name = "cbUserDiss";
            this.cbUserDiss.Size = new System.Drawing.Size(250, 23);
            this.cbUserDiss.TabIndex = 3;
            this.cbUserDiss.DropDown += new System.EventHandler(this.cbUserDiss_DropDown);
            // 
            // cbUserAble
            // 
            this.cbUserAble.FormattingEnabled = true;
            this.cbUserAble.Location = new System.Drawing.Point(106, 147);
            this.cbUserAble.Name = "cbUserAble";
            this.cbUserAble.Size = new System.Drawing.Size(250, 23);
            this.cbUserAble.TabIndex = 3;
            this.cbUserAble.DropDown += new System.EventHandler(this.cbUserAble_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "使用单位";
            // 
            // txtCoName
            // 
            this.txtCoName.Location = new System.Drawing.Point(66, 62);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.Size = new System.Drawing.Size(290, 25);
            this.txtCoName.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(438, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 323);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Parameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统参数设置";
            this.Load += new System.EventHandler(this.Parameter_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpCollection.ResumeLayout(false);
            this.tpCollection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCollection;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUserDiss;
        private System.Windows.Forms.ComboBox cbUserAble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoName;
        private System.Windows.Forms.Button btnSave;
    }
}