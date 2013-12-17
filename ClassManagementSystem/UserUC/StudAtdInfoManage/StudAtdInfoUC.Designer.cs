namespace ClassManagementSystem.StudAtdInfoManage
{
    partial class StudAtdInfoUC
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
            this.AtdInsttabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AttendancedataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DrawBackBtn = new System.Windows.Forms.Button();
            this.InsertAtdBtn = new System.Windows.Forms.Button();
            this.AtddateTime = new System.Windows.Forms.DateTimePicker();
            this.AtdItemCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SnoTBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.AtdInsttabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendancedataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AtdInsttabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 512);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
            // 
            // AtdInsttabPage
            // 
            this.AtdInsttabPage.Controls.Add(this.groupBox3);
            this.AtdInsttabPage.Controls.Add(this.groupBox2);
            this.AtdInsttabPage.Controls.Add(this.groupBox1);
            this.AtdInsttabPage.Location = new System.Drawing.Point(4, 21);
            this.AtdInsttabPage.Name = "AtdInsttabPage";
            this.AtdInsttabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AtdInsttabPage.Size = new System.Drawing.Size(567, 487);
            this.AtdInsttabPage.TabIndex = 0;
            this.AtdInsttabPage.Text = "考勤信息管理";
            this.AtdInsttabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RefreshBtn);
            this.groupBox3.Controls.Add(this.ModifyBtn);
            this.groupBox3.Controls.Add(this.DelBtn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(375, 17);
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
            this.ModifyBtn.Location = new System.Drawing.Point(239, 17);
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
            this.DelBtn.Location = new System.Drawing.Point(103, 17);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 0;
            this.DelBtn.Text = "删除记录";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AttendancedataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 402);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前班级考勤记录（可直接在表格中修改）";
            // 
            // AttendancedataGridView
            // 
            this.AttendancedataGridView.AllowUserToAddRows = false;
            this.AttendancedataGridView.AllowUserToDeleteRows = false;
            this.AttendancedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendancedataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttendancedataGridView.Location = new System.Drawing.Point(3, 17);
            this.AttendancedataGridView.Name = "AttendancedataGridView";
            this.AttendancedataGridView.RowTemplate.Height = 23;
            this.AttendancedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendancedataGridView.Size = new System.Drawing.Size(555, 382);
            this.AttendancedataGridView.TabIndex = 0;
            this.AttendancedataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendancedataGridView_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.DrawBackBtn);
            this.groupBox1.Controls.Add(this.InsertAtdBtn);
            this.groupBox1.Controls.Add(this.AtddateTime);
            this.groupBox1.Controls.Add(this.AtdItemCBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SnoTBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "班级考勤信息";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(198, 43);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 35;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DrawBackBtn
            // 
            this.DrawBackBtn.Location = new System.Drawing.Point(466, 43);
            this.DrawBackBtn.Name = "DrawBackBtn";
            this.DrawBackBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawBackBtn.TabIndex = 4;
            this.DrawBackBtn.Text = "撤销";
            this.DrawBackBtn.UseVisualStyleBackColor = true;
            this.DrawBackBtn.Click += new System.EventHandler(this.DrawBackBtn_Click);
            // 
            // InsertAtdBtn
            // 
            this.InsertAtdBtn.Enabled = false;
            this.InsertAtdBtn.Location = new System.Drawing.Point(335, 43);
            this.InsertAtdBtn.Name = "InsertAtdBtn";
            this.InsertAtdBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertAtdBtn.TabIndex = 3;
            this.InsertAtdBtn.Text = "录入";
            this.InsertAtdBtn.UseVisualStyleBackColor = true;
            this.InsertAtdBtn.Click += new System.EventHandler(this.InsertAtdBtn_Click);
            // 
            // AtddateTime
            // 
            this.AtddateTime.Location = new System.Drawing.Point(404, 16);
            this.AtddateTime.Name = "AtddateTime";
            this.AtddateTime.Size = new System.Drawing.Size(137, 21);
            this.AtddateTime.TabIndex = 2;
            // 
            // AtdItemCBox
            // 
            this.AtdItemCBox.FormattingEnabled = true;
            this.AtdItemCBox.Items.AddRange(new object[] {
            "迟到",
            "旷课",
            "早退",
            "请假"});
            this.AtdItemCBox.Location = new System.Drawing.Point(239, 16);
            this.AtdItemCBox.Name = "AtdItemCBox";
            this.AtdItemCBox.Size = new System.Drawing.Size(82, 20);
            this.AtdItemCBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "考勤日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "考勤项目：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "学号：";
            // 
            // SnoTBox
            // 
            this.SnoTBox.Location = new System.Drawing.Point(49, 16);
            this.SnoTBox.Name = "SnoTBox";
            this.SnoTBox.Size = new System.Drawing.Size(109, 21);
            this.SnoTBox.TabIndex = 0;
            // 
            // StudAtdInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "StudAtdInfoUC";
            this.Size = new System.Drawing.Size(575, 512);
            this.tabControl1.ResumeLayout(false);
            this.AtdInsttabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendancedataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AtdInsttabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AtdItemCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SnoTBox;
        private System.Windows.Forms.DateTimePicker AtddateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DrawBackBtn;
        private System.Windows.Forms.Button InsertAtdBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView AttendancedataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}
