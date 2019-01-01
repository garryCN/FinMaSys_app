using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMaSys
{
    public partial class DataBakStart : Form
    {
        private GroupBox groupBox1;
        private Button btnBrowerAuto;
        private TextBox txtAutoPath;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private NumericUpDown numUpDownMinute;
        private NumericUpDown numUpDownHour;
        private CheckBox cbDelBakData;
        private CheckBox cbRarBak;
        private CheckBox cbAutoBak;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private CheckBox checkBox1;
        private Button btnRarSoft;
        private TextBox txtRarPath;
        private Button btnAutoSave;

        public DataBakStart()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutoPath = new System.Windows.Forms.TextBox();
            this.btnBrowerAuto = new System.Windows.Forms.Button();
            this.numUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAutoBak = new System.Windows.Forms.CheckBox();
            this.cbRarBak = new System.Windows.Forms.CheckBox();
            this.cbDelBakData = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtRarPath = new System.Windows.Forms.TextBox();
            this.btnRarSoft = new System.Windows.Forms.Button();
            this.btnAutoSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.cbDelBakData);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cbRarBak);
            this.groupBox1.Controls.Add(this.cbAutoBak);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRarPath);
            this.groupBox1.Controls.Add(this.numUpDownMinute);
            this.groupBox1.Controls.Add(this.numUpDownHour);
            this.groupBox1.Controls.Add(this.btnAutoSave);
            this.groupBox1.Controls.Add(this.btnRarSoft);
            this.groupBox1.Controls.Add(this.btnBrowerAuto);
            this.groupBox1.Controls.Add(this.txtAutoPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自动备份设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "自动备份路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "网络备份请用\\server\\share形式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "每日备份时间：";
            // 
            // txtAutoPath
            // 
            this.txtAutoPath.Enabled = false;
            this.txtAutoPath.Location = new System.Drawing.Point(122, 39);
            this.txtAutoPath.Name = "txtAutoPath";
            this.txtAutoPath.Size = new System.Drawing.Size(376, 25);
            this.txtAutoPath.TabIndex = 3;
            // 
            // btnBrowerAuto
            // 
            this.btnBrowerAuto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBrowerAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowerAuto.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowerAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrowerAuto.Location = new System.Drawing.Point(512, 38);
            this.btnBrowerAuto.Name = "btnBrowerAuto";
            this.btnBrowerAuto.Size = new System.Drawing.Size(75, 26);
            this.btnBrowerAuto.TabIndex = 4;
            this.btnBrowerAuto.Text = "浏览";
            this.btnBrowerAuto.UseVisualStyleBackColor = false;
            // 
            // numUpDownHour
            // 
            this.numUpDownHour.Location = new System.Drawing.Point(130, 106);
            this.numUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numUpDownHour.Name = "numUpDownHour";
            this.numUpDownHour.Size = new System.Drawing.Size(42, 25);
            this.numUpDownHour.TabIndex = 5;
            this.numUpDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpDownMinute
            // 
            this.numUpDownMinute.Location = new System.Drawing.Point(200, 106);
            this.numUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDownMinute.Name = "numUpDownMinute";
            this.numUpDownMinute.Size = new System.Drawing.Size(42, 25);
            this.numUpDownMinute.TabIndex = 6;
            this.numUpDownMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // cbAutoBak
            // 
            this.cbAutoBak.AutoSize = true;
            this.cbAutoBak.Location = new System.Drawing.Point(130, 139);
            this.cbAutoBak.Name = "cbAutoBak";
            this.cbAutoBak.Size = new System.Drawing.Size(119, 19);
            this.cbAutoBak.TabIndex = 8;
            this.cbAutoBak.Text = "执行自动备份";
            this.cbAutoBak.UseVisualStyleBackColor = true;
            // 
            // cbRarBak
            // 
            this.cbRarBak.AutoSize = true;
            this.cbRarBak.Location = new System.Drawing.Point(130, 173);
            this.cbRarBak.Name = "cbRarBak";
            this.cbRarBak.Size = new System.Drawing.Size(168, 19);
            this.cbRarBak.TabIndex = 8;
            this.cbRarBak.Text = "备份后压缩(winzip)";
            this.cbRarBak.UseVisualStyleBackColor = true;
            // 
            // cbDelBakData
            // 
            this.cbDelBakData.AutoSize = true;
            this.cbDelBakData.Location = new System.Drawing.Point(308, 139);
            this.cbDelBakData.Name = "cbDelBakData";
            this.cbDelBakData.Size = new System.Drawing.Size(59, 19);
            this.cbDelBakData.TabIndex = 8;
            this.cbDelBakData.Text = "删除";
            this.cbDelBakData.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(361, 136);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 25);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "日前备份数据";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(130, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "备份后压缩(winzip)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtRarPath
            // 
            this.txtRarPath.Enabled = false;
            this.txtRarPath.Location = new System.Drawing.Point(292, 169);
            this.txtRarPath.Name = "txtRarPath";
            this.txtRarPath.Size = new System.Drawing.Size(247, 25);
            this.txtRarPath.TabIndex = 3;
            // 
            // btnRarSoft
            // 
            this.btnRarSoft.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRarSoft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRarSoft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRarSoft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRarSoft.Location = new System.Drawing.Point(545, 168);
            this.btnRarSoft.Name = "btnRarSoft";
            this.btnRarSoft.Size = new System.Drawing.Size(69, 26);
            this.btnRarSoft.TabIndex = 4;
            this.btnRarSoft.Text = "浏览";
            this.btnRarSoft.UseVisualStyleBackColor = false;
            // 
            // btnAutoSave
            // 
            this.btnAutoSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAutoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAutoSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAutoSave.Location = new System.Drawing.Point(495, 204);
            this.btnAutoSave.Name = "btnAutoSave";
            this.btnAutoSave.Size = new System.Drawing.Size(119, 33);
            this.btnAutoSave.TabIndex = 4;
            this.btnAutoSave.Text = "保存设置";
            this.btnAutoSave.UseVisualStyleBackColor = false;
            // 
            // DataBakStart
            // 
            this.ClientSize = new System.Drawing.Size(630, 252);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataBakStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开始备份";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
