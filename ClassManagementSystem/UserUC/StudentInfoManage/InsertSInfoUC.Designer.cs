namespace ClassManagementSystem.StudentInfoManage
{
    partial class InsertSInfoUC
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
            this.StudTabControl = new System.Windows.Forms.TabControl();
            this.AddStudtabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhotoNameLab = new System.Windows.Forms.Label();
            this.AttachLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DrawbackBtn = new System.Windows.Forms.Button();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.InsertStuBtn = new System.Windows.Forms.Button();
            this.BirthdateTime = new System.Windows.Forms.DateTimePicker();
            this.SpecialtyTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassTBox = new System.Windows.Forms.TextBox();
            this.SnoTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SnameTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StudDataGridView = new System.Windows.Forms.DataGridView();
            this.PhotoopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.StudTabControl.SuspendLayout();
            this.AddStudtabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudTabControl
            // 
            this.StudTabControl.Controls.Add(this.AddStudtabPage);
            this.StudTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudTabControl.Location = new System.Drawing.Point(0, 0);
            this.StudTabControl.Name = "StudTabControl";
            this.StudTabControl.SelectedIndex = 0;
            this.StudTabControl.Size = new System.Drawing.Size(574, 519);
            this.StudTabControl.TabIndex = 0;
            // 
            // AddStudtabPage
            // 
            this.AddStudtabPage.Controls.Add(this.groupBox1);
            this.AddStudtabPage.Controls.Add(this.groupBox2);
            this.AddStudtabPage.Location = new System.Drawing.Point(4, 21);
            this.AddStudtabPage.Name = "AddStudtabPage";
            this.AddStudtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddStudtabPage.Size = new System.Drawing.Size(566, 494);
            this.AddStudtabPage.TabIndex = 0;
            this.AddStudtabPage.Text = "学生信息录入";
            this.AddStudtabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhotoNameLab);
            this.groupBox1.Controls.Add(this.AttachLinkLabel);
            this.groupBox1.Controls.Add(this.DrawbackBtn);
            this.groupBox1.Controls.Add(this.SexComboBox);
            this.groupBox1.Controls.Add(this.InsertStuBtn);
            this.groupBox1.Controls.Add(this.BirthdateTime);
            this.groupBox1.Controls.Add(this.SpecialtyTBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClassTBox);
            this.groupBox1.Controls.Add(this.SnoTBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SnameTBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 108);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // PhotoNameLab
            // 
            this.PhotoNameLab.AutoSize = true;
            this.PhotoNameLab.Location = new System.Drawing.Point(81, 79);
            this.PhotoNameLab.Name = "PhotoNameLab";
            this.PhotoNameLab.Size = new System.Drawing.Size(41, 12);
            this.PhotoNameLab.TabIndex = 60;
            this.PhotoNameLab.Text = "label5";
            // 
            // AttachLinkLabel
            // 
            this.AttachLinkLabel.AutoSize = true;
            this.AttachLinkLabel.Location = new System.Drawing.Point(3, 79);
            this.AttachLinkLabel.Name = "AttachLinkLabel";
            this.AttachLinkLabel.Size = new System.Drawing.Size(59, 12);
            this.AttachLinkLabel.TabIndex = 6;
            this.AttachLinkLabel.TabStop = true;
            this.AttachLinkLabel.Text = "上传照片:";
            this.AttachLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AttachLinkLabel_LinkClicked);
            // 
            // DrawbackBtn
            // 
            this.DrawbackBtn.Location = new System.Drawing.Point(459, 73);
            this.DrawbackBtn.Name = "DrawbackBtn";
            this.DrawbackBtn.Size = new System.Drawing.Size(88, 24);
            this.DrawbackBtn.TabIndex = 8;
            this.DrawbackBtn.Text = "撤销";
            this.DrawbackBtn.Click += new System.EventHandler(this.DrawbackBtn_Click);
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.SexComboBox.Location = new System.Drawing.Point(424, 12);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(123, 20);
            this.SexComboBox.TabIndex = 2;
            this.SexComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SexComboBox_KeyUp);
            // 
            // InsertStuBtn
            // 
            this.InsertStuBtn.Location = new System.Drawing.Point(330, 74);
            this.InsertStuBtn.Name = "InsertStuBtn";
            this.InsertStuBtn.Size = new System.Drawing.Size(88, 24);
            this.InsertStuBtn.TabIndex = 7;
            this.InsertStuBtn.Text = "录入";
            this.InsertStuBtn.Click += new System.EventHandler(this.InsertStuBtn_Click);
            // 
            // BirthdateTime
            // 
            this.BirthdateTime.Location = new System.Drawing.Point(424, 46);
            this.BirthdateTime.Name = "BirthdateTime";
            this.BirthdateTime.Size = new System.Drawing.Size(123, 21);
            this.BirthdateTime.TabIndex = 58;
            this.BirthdateTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BirthdateTime_KeyUp);
            // 
            // SpecialtyTBox
            // 
            this.SpecialtyTBox.Location = new System.Drawing.Point(229, 47);
            this.SpecialtyTBox.Name = "SpecialtyTBox";
            this.SpecialtyTBox.Size = new System.Drawing.Size(118, 21);
            this.SpecialtyTBox.TabIndex = 5;
            this.SpecialtyTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpecialtyTBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "学号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 51;
            this.label9.Text = "专业：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "姓名：";
            // 
            // ClassTBox
            // 
            this.ClassTBox.Location = new System.Drawing.Point(46, 46);
            this.ClassTBox.Name = "ClassTBox";
            this.ClassTBox.Size = new System.Drawing.Size(121, 21);
            this.ClassTBox.TabIndex = 4;
            this.ClassTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ClassTBox_KeyUp);
            // 
            // SnoTBox
            // 
            this.SnoTBox.Location = new System.Drawing.Point(46, 17);
            this.SnoTBox.Name = "SnoTBox";
            this.SnoTBox.Size = new System.Drawing.Size(121, 21);
            this.SnoTBox.TabIndex = 0;
            this.SnoTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnoTBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "性    别：";
            // 
            // SnameTBox
            // 
            this.SnameTBox.Location = new System.Drawing.Point(229, 17);
            this.SnameTBox.Name = "SnameTBox";
            this.SnameTBox.Size = new System.Drawing.Size(118, 21);
            this.SnameTBox.TabIndex = 1;
            this.SnameTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnameTBox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "出生日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "班级：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StudDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 374);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前班级学生列表";
            // 
            // StudDataGridView
            // 
            this.StudDataGridView.AllowUserToAddRows = false;
            this.StudDataGridView.AllowUserToDeleteRows = false;
            this.StudDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudDataGridView.Location = new System.Drawing.Point(3, 17);
            this.StudDataGridView.Name = "StudDataGridView";
            this.StudDataGridView.ReadOnly = true;
            this.StudDataGridView.RowTemplate.Height = 23;
            this.StudDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudDataGridView.Size = new System.Drawing.Size(554, 354);
            this.StudDataGridView.TabIndex = 0;
            // 
            // PhotoopenFileDialog
            // 
            this.PhotoopenFileDialog.FileName = "openFileDialog1";
            // 
            // InsertSInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudTabControl);
            this.Name = "InsertSInfoUC";
            this.Size = new System.Drawing.Size(574, 519);
            this.StudTabControl.ResumeLayout(false);
            this.AddStudtabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl StudTabControl;
        private System.Windows.Forms.TabPage AddStudtabPage;
        private System.Windows.Forms.DateTimePicker BirthdateTime;
        private System.Windows.Forms.Button DrawbackBtn;
        private System.Windows.Forms.Button InsertStuBtn;
        private System.Windows.Forms.TextBox SpecialtyTBox;
        private System.Windows.Forms.TextBox SnoTBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SnameTBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.TextBox ClassTBox;
        private System.Windows.Forms.Label PhotoNameLab;
        private System.Windows.Forms.LinkLabel AttachLinkLabel;
        private System.Windows.Forms.DataGridView StudDataGridView;
        private System.Windows.Forms.OpenFileDialog PhotoopenFileDialog;
    }
}
