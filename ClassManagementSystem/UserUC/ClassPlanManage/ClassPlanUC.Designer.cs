namespace ClassManagementSystem.ClassPlanManage
{
    partial class ClassPlanUC
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClassPlandataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.OpenAppendixBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppendixNameLab = new System.Windows.Forms.Label();
            this.AttachLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PlanNameTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DrawBackBtn = new System.Windows.Forms.Button();
            this.InsertCpBtn = new System.Windows.Forms.Button();
            this.AppendixopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassPlandataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 512);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "班委工作计划管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClassPlandataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 370);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "班委工作计划信息（可直接在表格中修改）";
            // 
            // ClassPlandataGridView
            // 
            this.ClassPlandataGridView.AllowUserToAddRows = false;
            this.ClassPlandataGridView.AllowUserToDeleteRows = false;
            this.ClassPlandataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassPlandataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassPlandataGridView.Location = new System.Drawing.Point(3, 17);
            this.ClassPlandataGridView.Name = "ClassPlandataGridView";
            this.ClassPlandataGridView.RowTemplate.Height = 23;
            this.ClassPlandataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassPlandataGridView.Size = new System.Drawing.Size(555, 350);
            this.ClassPlandataGridView.TabIndex = 1;
            this.ClassPlandataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassPlandataGridView_CellEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UploadBtn);
            this.groupBox3.Controls.Add(this.OpenAppendixBtn);
            this.groupBox3.Controls.Add(this.RefreshBtn);
            this.groupBox3.Controls.Add(this.ModifyBtn);
            this.groupBox3.Controls.Add(this.DelBtn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 42);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Enabled = false;
            this.UploadBtn.Location = new System.Drawing.Point(35, 13);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadBtn.TabIndex = 1;
            this.UploadBtn.Text = "上传新附件";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // OpenAppendixBtn
            // 
            this.OpenAppendixBtn.Location = new System.Drawing.Point(138, 13);
            this.OpenAppendixBtn.Name = "OpenAppendixBtn";
            this.OpenAppendixBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenAppendixBtn.TabIndex = 1;
            this.OpenAppendixBtn.Text = "查看附件";
            this.OpenAppendixBtn.UseVisualStyleBackColor = true;
            this.OpenAppendixBtn.Click += new System.EventHandler(this.OpenAppendixBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(447, 13);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 0;
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Enabled = false;
            this.ModifyBtn.Location = new System.Drawing.Point(344, 13);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyBtn.TabIndex = 0;
            this.ModifyBtn.Text = "保存修改";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Enabled = false;
            this.DelBtn.Location = new System.Drawing.Point(241, 13);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 0;
            this.DelBtn.Text = "删除记录";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AppendixNameLab);
            this.groupBox1.Controls.Add(this.AttachLinkLabel);
            this.groupBox1.Controls.Add(this.PlanNameTBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.DrawBackBtn);
            this.groupBox1.Controls.Add(this.InsertCpBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "班委工作计划信息";
            // 
            // AppendixNameLab
            // 
            this.AppendixNameLab.AutoSize = true;
            this.AppendixNameLab.Location = new System.Drawing.Point(466, 17);
            this.AppendixNameLab.Name = "AppendixNameLab";
            this.AppendixNameLab.Size = new System.Drawing.Size(41, 12);
            this.AppendixNameLab.TabIndex = 78;
            this.AppendixNameLab.Text = "label5";
            // 
            // AttachLinkLabel
            // 
            this.AttachLinkLabel.AutoSize = true;
            this.AttachLinkLabel.Location = new System.Drawing.Point(391, 17);
            this.AttachLinkLabel.Name = "AttachLinkLabel";
            this.AttachLinkLabel.Size = new System.Drawing.Size(59, 12);
            this.AttachLinkLabel.TabIndex = 77;
            this.AttachLinkLabel.TabStop = true;
            this.AttachLinkLabel.Text = "添加附件:";
            this.AttachLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AttachLinkLabel_LinkClicked);
            // 
            // PlanNameTBox
            // 
            this.PlanNameTBox.Location = new System.Drawing.Point(101, 14);
            this.PlanNameTBox.Name = "PlanNameTBox";
            this.PlanNameTBox.Size = new System.Drawing.Size(253, 21);
            this.PlanNameTBox.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "工作计划名称：";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(239, 41);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 41;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DrawBackBtn
            // 
            this.DrawBackBtn.Location = new System.Drawing.Point(455, 41);
            this.DrawBackBtn.Name = "DrawBackBtn";
            this.DrawBackBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawBackBtn.TabIndex = 40;
            this.DrawBackBtn.Text = "撤销";
            this.DrawBackBtn.UseVisualStyleBackColor = true;
            this.DrawBackBtn.Click += new System.EventHandler(this.DrawBackBtn_Click);
            // 
            // InsertCpBtn
            // 
            this.InsertCpBtn.Enabled = false;
            this.InsertCpBtn.Location = new System.Drawing.Point(347, 41);
            this.InsertCpBtn.Name = "InsertCpBtn";
            this.InsertCpBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertCpBtn.TabIndex = 39;
            this.InsertCpBtn.Text = "录入";
            this.InsertCpBtn.UseVisualStyleBackColor = true;
            this.InsertCpBtn.Click += new System.EventHandler(this.InsertCpBtn_Click);
            // 
            // ClassPlanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ClassPlanUC";
            this.Size = new System.Drawing.Size(575, 512);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassPlandataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DrawBackBtn;
        private System.Windows.Forms.Button InsertCpBtn;
        private System.Windows.Forms.TextBox PlanNameTBox;
        private System.Windows.Forms.DataGridView ClassPlandataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Button OpenAppendixBtn;
        private System.Windows.Forms.Label AppendixNameLab;
        private System.Windows.Forms.LinkLabel AttachLinkLabel;
        private System.Windows.Forms.OpenFileDialog AppendixopenFileDialog;
    }
}
