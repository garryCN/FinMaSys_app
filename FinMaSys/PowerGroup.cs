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
    public partial class PowerGroup : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgAddUser;
        private TextBox txtUserGroups;
        private Button btnAddNew;
        private Label label1;
        private Button btnQuery;
        private TabPage tabPage2;

        public PowerGroup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgAddUser = new System.Windows.Forms.DataGridView();
            this.txtUserGroups = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvUserGroup = new System.Windows.Forms.DataGridView();
            this.tvUserGroup = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 485);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgAddUser);
            this.tabPage1.Controls.Add(this.txtUserGroups);
            this.tabPage1.Controls.Add(this.btnAddNew);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnQuery);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "用户组";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgAddUser
            // 
            this.dgAddUser.AllowUserToAddRows = false;
            this.dgAddUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddUser.Location = new System.Drawing.Point(29, 84);
            this.dgAddUser.Name = "dgAddUser";
            this.dgAddUser.RowTemplate.Height = 27;
            this.dgAddUser.Size = new System.Drawing.Size(763, 344);
            this.dgAddUser.TabIndex = 13;
            // 
            // txtUserGroups
            // 
            this.txtUserGroups.Location = new System.Drawing.Point(562, 50);
            this.txtUserGroups.Name = "txtUserGroups";
            this.txtUserGroups.Size = new System.Drawing.Size(155, 25);
            this.txtUserGroups.TabIndex = 12;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNew.Location = new System.Drawing.Point(29, 33);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(115, 32);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "+添加用户组";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "组名";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuery.Location = new System.Drawing.Point(734, 46);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(58, 32);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvUserGroup);
            this.tabPage2.Controls.Add(this.tvUserGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "组权限";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUserGroup
            // 
            this.dgvUserGroup.AllowUserToAddRows = false;
            this.dgvUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserGroup.Location = new System.Drawing.Point(159, 3);
            this.dgvUserGroup.Name = "dgvUserGroup";
            this.dgvUserGroup.RowTemplate.Height = 27;
            this.dgvUserGroup.Size = new System.Drawing.Size(659, 447);
            this.dgvUserGroup.TabIndex = 1;
            // 
            // tvUserGroup
            // 
            this.tvUserGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvUserGroup.Location = new System.Drawing.Point(3, 3);
            this.tvUserGroup.Name = "tvUserGroup";
            this.tvUserGroup.Size = new System.Drawing.Size(156, 447);
            this.tvUserGroup.TabIndex = 0;
            // 
            // PowerGroup
            // 
            this.ClientSize = new System.Drawing.Size(839, 494);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowerGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户组及权限管理";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
