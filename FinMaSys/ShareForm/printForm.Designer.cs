namespace FinMaSys.ShareForm
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.pd1 = new System.Drawing.Printing.PrintDocument();
            this.tsPrint = new System.Windows.Forms.ToolStrip();
            this.tsbPrintSet = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintView = new System.Windows.Forms.ToolStripButton();
            this.tsbPageSet = new System.Windows.Forms.ToolStripButton();
            this.tsPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pd1
            // 
            this.pd1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd1_PrintPage);
            // 
            // tsPrint
            // 
            this.tsPrint.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrintSet,
            this.tsbPageSet,
            this.tsbPrintView});
            this.tsPrint.Location = new System.Drawing.Point(0, 0);
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(1083, 31);
            this.tsPrint.TabIndex = 0;
            this.tsPrint.Text = "toolStrip1";
            // 
            // tsbPrintSet
            // 
            this.tsbPrintSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPrintSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintSet.Image")));
            this.tsbPrintSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintSet.Name = "tsbPrintSet";
            this.tsbPrintSet.Size = new System.Drawing.Size(86, 28);
            this.tsbPrintSet.Text = "打印设置";
            this.tsbPrintSet.Click += new System.EventHandler(this.tsbPrintSet_Click);
            // 
            // tsbPrintView
            // 
            this.tsbPrintView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPrintView.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintView.Image")));
            this.tsbPrintView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintView.Name = "tsbPrintView";
            this.tsbPrintView.Size = new System.Drawing.Size(86, 28);
            this.tsbPrintView.Text = "打印预览";
            this.tsbPrintView.Click += new System.EventHandler(this.tsbPrintView_Click);
            // 
            // tsbPageSet
            // 
            this.tsbPageSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPageSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbPageSet.Image")));
            this.tsbPageSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPageSet.Name = "tsbPageSet";
            this.tsbPageSet.Size = new System.Drawing.Size(86, 28);
            this.tsbPageSet.Text = "页面设置";
            this.tsbPageSet.Click += new System.EventHandler(this.tsbPageSet_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 491);
            this.Controls.Add(this.tsPrint);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印预览";
            this.tsPrint.ResumeLayout(false);
            this.tsPrint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument pd1;
        private System.Windows.Forms.ToolStrip tsPrint;
        private System.Windows.Forms.ToolStripButton tsbPrintSet;
        private System.Windows.Forms.ToolStripButton tsbPrintView;
        private System.Windows.Forms.ToolStripButton tsbPageSet;
    }
}