namespace FinMaSys.ShareForm
{
    partial class PrintSet
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
            this.txtXPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYPosition = new System.Windows.Forms.TextBox();
            this.btnSaveSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X坐标";
            // 
            // txtXPosition
            // 
            this.txtXPosition.Location = new System.Drawing.Point(130, 33);
            this.txtXPosition.Name = "txtXPosition";
            this.txtXPosition.Size = new System.Drawing.Size(201, 25);
            this.txtXPosition.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y坐标";
            // 
            // txtYPosition
            // 
            this.txtYPosition.Location = new System.Drawing.Point(130, 78);
            this.txtYPosition.Name = "txtYPosition";
            this.txtYPosition.Size = new System.Drawing.Size(201, 25);
            this.txtYPosition.TabIndex = 1;
            // 
            // btnSaveSet
            // 
            this.btnSaveSet.AutoSize = true;
            this.btnSaveSet.Location = new System.Drawing.Point(223, 123);
            this.btnSaveSet.Name = "btnSaveSet";
            this.btnSaveSet.Size = new System.Drawing.Size(108, 30);
            this.btnSaveSet.TabIndex = 2;
            this.btnSaveSet.Text = "保存设置";
            this.btnSaveSet.UseVisualStyleBackColor = true;
            this.btnSaveSet.Click += new System.EventHandler(this.btnSaveSet_Click);
            // 
            // PrintSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 174);
            this.Controls.Add(this.btnSaveSet);
            this.Controls.Add(this.txtYPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXPosition);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印参数设置";
            this.Load += new System.EventHandler(this.PrintSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYPosition;
        private System.Windows.Forms.Button btnSaveSet;
    }
}