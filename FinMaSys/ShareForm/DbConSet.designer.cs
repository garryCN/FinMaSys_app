namespace FinMaSys
{
    partial class DbConSet
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
            this.btnSaveSet = new System.Windows.Forms.Button();
            this.txtServAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器地址";
            // 
            // btnSaveSet
            // 
            this.btnSaveSet.AutoSize = true;
            this.btnSaveSet.Location = new System.Drawing.Point(316, 196);
            this.btnSaveSet.Name = "btnSaveSet";
            this.btnSaveSet.Size = new System.Drawing.Size(122, 31);
            this.btnSaveSet.TabIndex = 1;
            this.btnSaveSet.Text = "保存设置";
            this.btnSaveSet.UseVisualStyleBackColor = true;
            this.btnSaveSet.Click += new System.EventHandler(this.btnSaveSet_Click);
            // 
            // txtServAddr
            // 
            this.txtServAddr.Location = new System.Drawing.Point(158, 39);
            this.txtServAddr.Name = "txtServAddr";
            this.txtServAddr.Size = new System.Drawing.Size(280, 28);
            this.txtServAddr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "登录名";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(158, 90);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(280, 28);
            this.txtLoginName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(158, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(280, 28);
            this.txtPassword.TabIndex = 2;
            // 
            // DbConSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(491, 247);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveSet);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbConSet";
            this.ShowInTaskbar = false;
            this.Text = "服务器设置";
            this.Load += new System.EventHandler(this.DbConSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveSet;
        private System.Windows.Forms.TextBox txtServAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
    }
}