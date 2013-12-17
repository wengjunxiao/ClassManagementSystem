namespace ClassManagementSystem.RewardPenaltyManage
{
    partial class RewardUC
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.RewardtabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RewarddataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.OpenAppendixBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SnoTBox = new System.Windows.Forms.TextBox();
            this.AppendixNameLab = new System.Windows.Forms.Label();
            this.AttachLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.DrawbackBtn = new System.Windows.Forms.Button();
            this.RewardComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.InserBtn = new System.Windows.Forms.Button();
            this.RewarddateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AppendixopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.RewardtabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RewarddataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.RewardtabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(620, 522);
            this.tabControl.TabIndex = 0;
            this.tabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDoubleClick);
            // 
            // RewardtabPage
            // 
            this.RewardtabPage.Controls.Add(this.groupBox3);
            this.RewardtabPage.Controls.Add(this.groupBox2);
            this.RewardtabPage.Controls.Add(this.groupBox1);
            this.RewardtabPage.Location = new System.Drawing.Point(4, 21);
            this.RewardtabPage.Name = "RewardtabPage";
            this.RewardtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RewardtabPage.Size = new System.Drawing.Size(612, 497);
            this.RewardtabPage.TabIndex = 0;
            this.RewardtabPage.Text = "奖励信息管理";
            this.RewardtabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RewarddataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 375);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "学生奖励信息（可直接在表格上修改）";
            // 
            // RewarddataGridView
            // 
            this.RewarddataGridView.AllowUserToAddRows = false;
            this.RewarddataGridView.AllowUserToDeleteRows = false;
            this.RewarddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RewarddataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RewarddataGridView.Location = new System.Drawing.Point(3, 17);
            this.RewarddataGridView.Name = "RewarddataGridView";
            this.RewarddataGridView.RowTemplate.Height = 23;
            this.RewarddataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RewarddataGridView.Size = new System.Drawing.Size(600, 355);
            this.RewarddataGridView.TabIndex = 0;
            this.RewarddataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RewarddataGridView_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UploadBtn);
            this.groupBox2.Controls.Add(this.RefreshBtn);
            this.groupBox2.Controls.Add(this.ModifyBtn);
            this.groupBox2.Controls.Add(this.DelBtn);
            this.groupBox2.Controls.Add(this.OpenAppendixBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 43);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Enabled = false;
            this.UploadBtn.Location = new System.Drawing.Point(56, 14);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadBtn.TabIndex = 1;
            this.UploadBtn.Text = "上传新附件";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(472, 14);
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
            this.ModifyBtn.Location = new System.Drawing.Point(368, 14);
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
            this.DelBtn.Location = new System.Drawing.Point(264, 14);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 0;
            this.DelBtn.Text = "删除";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // OpenAppendixBtn
            // 
            this.OpenAppendixBtn.Location = new System.Drawing.Point(160, 14);
            this.OpenAppendixBtn.Name = "OpenAppendixBtn";
            this.OpenAppendixBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenAppendixBtn.TabIndex = 0;
            this.OpenAppendixBtn.Text = "打开附件";
            this.OpenAppendixBtn.UseVisualStyleBackColor = true;
            this.OpenAppendixBtn.Click += new System.EventHandler(this.OpenAppendixBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SnoTBox);
            this.groupBox1.Controls.Add(this.AppendixNameLab);
            this.groupBox1.Controls.Add(this.AttachLinkLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DrawbackBtn);
            this.groupBox1.Controls.Add(this.RewardComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.InserBtn);
            this.groupBox1.Controls.Add(this.RewarddateTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 73);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生奖励";
            // 
            // SnoTBox
            // 
            this.SnoTBox.Location = new System.Drawing.Point(54, 15);
            this.SnoTBox.Name = "SnoTBox";
            this.SnoTBox.Size = new System.Drawing.Size(121, 21);
            this.SnoTBox.TabIndex = 0;
            // 
            // AppendixNameLab
            // 
            this.AppendixNameLab.AutoSize = true;
            this.AppendixNameLab.Location = new System.Drawing.Point(86, 49);
            this.AppendixNameLab.Name = "AppendixNameLab";
            this.AppendixNameLab.Size = new System.Drawing.Size(41, 12);
            this.AppendixNameLab.TabIndex = 76;
            this.AppendixNameLab.Text = "label5";
            // 
            // AttachLinkLabel
            // 
            this.AttachLinkLabel.AutoSize = true;
            this.AttachLinkLabel.Location = new System.Drawing.Point(11, 49);
            this.AttachLinkLabel.Name = "AttachLinkLabel";
            this.AttachLinkLabel.Size = new System.Drawing.Size(59, 12);
            this.AttachLinkLabel.TabIndex = 66;
            this.AttachLinkLabel.TabStop = true;
            this.AttachLinkLabel.Text = "上传附件:";
            this.AttachLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AttachLinkLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 72;
            this.label4.Text = "获奖日期：";
            // 
            // DrawbackBtn
            // 
            this.DrawbackBtn.Location = new System.Drawing.Point(491, 42);
            this.DrawbackBtn.Name = "DrawbackBtn";
            this.DrawbackBtn.Size = new System.Drawing.Size(88, 24);
            this.DrawbackBtn.TabIndex = 68;
            this.DrawbackBtn.Text = "撤销";
            this.DrawbackBtn.Click += new System.EventHandler(this.DrawbackBtn_Click);
            // 
            // RewardComboBox
            // 
            this.RewardComboBox.FormattingEnabled = true;
            this.RewardComboBox.Items.AddRange(new object[] {
            "一等奖学金",
            "二等奖学金",
            "三等奖学金",
            "三好学生",
            "优秀团员",
            "优秀党员"});
            this.RewardComboBox.Location = new System.Drawing.Point(257, 17);
            this.RewardComboBox.Name = "RewardComboBox";
            this.RewardComboBox.Size = new System.Drawing.Size(123, 20);
            this.RewardComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 71;
            this.label2.Text = "奖励名称：";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(209, 43);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(88, 24);
            this.SearchBtn.TabIndex = 67;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // InserBtn
            // 
            this.InserBtn.Enabled = false;
            this.InserBtn.Location = new System.Drawing.Point(350, 43);
            this.InserBtn.Name = "InserBtn";
            this.InserBtn.Size = new System.Drawing.Size(88, 24);
            this.InserBtn.TabIndex = 67;
            this.InserBtn.Text = "录入";
            this.InserBtn.Click += new System.EventHandler(this.InserBtn_Click);
            // 
            // RewarddateTime
            // 
            this.RewarddateTime.Location = new System.Drawing.Point(457, 16);
            this.RewarddateTime.Name = "RewarddateTime";
            this.RewarddateTime.Size = new System.Drawing.Size(123, 21);
            this.RewarddateTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 70;
            this.label3.Text = "学号：";
            // 
            // RewardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "RewardUC";
            this.Size = new System.Drawing.Size(620, 522);
            this.tabControl.ResumeLayout(false);
            this.RewardtabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RewarddataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage RewardtabPage;
        private System.Windows.Forms.Label AppendixNameLab;
        private System.Windows.Forms.LinkLabel AttachLinkLabel;
        private System.Windows.Forms.Button DrawbackBtn;
        private System.Windows.Forms.Button InserBtn;
        private System.Windows.Forms.DateTimePicker RewarddateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SnoTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox RewardComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView RewarddataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button OpenAppendixBtn;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.OpenFileDialog AppendixopenFileDialog;
    }
}
