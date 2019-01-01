namespace FinMaSys
{
    partial class UserEdit
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbUserGroup = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserEditErrProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOpenBank = new System.Windows.Forms.TextBox();
            this.tbAccNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditErrProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(333, 260);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 42);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(177, 260);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbUserGroup
            // 
            this.cbUserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserGroup.FormattingEnabled = true;
            this.cbUserGroup.Location = new System.Drawing.Point(177, 132);
            this.cbUserGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUserGroup.Name = "cbUserGroup";
            this.cbUserGroup.Size = new System.Drawing.Size(290, 26);
            this.cbUserGroup.TabIndex = 2;
            this.cbUserGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbUserGroup_KeyUp);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(177, 89);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(290, 28);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyUp);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(177, 40);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(290, 28);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "所属用户组";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "用户姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户工号";
            // 
            // UserEditErrProv
            // 
            this.UserEditErrProv.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "开户行";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "帐号";
            // 
            // tbOpenBank
            // 
            this.tbOpenBank.Location = new System.Drawing.Point(177, 172);
            this.tbOpenBank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOpenBank.Name = "tbOpenBank";
            this.tbOpenBank.Size = new System.Drawing.Size(290, 28);
            this.tbOpenBank.TabIndex = 0;
            this.tbOpenBank.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyUp);
            // 
            // tbAccNum
            // 
            this.tbAccNum.Location = new System.Drawing.Point(177, 210);
            this.tbAccNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAccNum.Name = "tbAccNum";
            this.tbAccNum.Size = new System.Drawing.Size(290, 28);
            this.tbAccNum.TabIndex = 0;
            this.tbAccNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyUp);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 320);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbUserGroup);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.tbAccNum);
            this.Controls.Add(this.tbOpenBank);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户编辑";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserEditErrProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbUserGroup;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider UserEditErrProv;
        private System.Windows.Forms.TextBox tbAccNum;
        private System.Windows.Forms.TextBox tbOpenBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}