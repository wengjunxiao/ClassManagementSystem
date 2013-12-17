namespace ClassManagementSystem.ClassPositionManage
{
    partial class ClassPositionUC
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClassPositiondataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PositionCBox = new System.Windows.Forms.ComboBox();
            this.PastradioButton = new System.Windows.Forms.RadioButton();
            this.NowradioButton = new System.Windows.Forms.RadioButton();
            this.EdateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BdateTime = new System.Windows.Forms.DateTimePicker();
            this.上任日期 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SnoTBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DrawBackBtn = new System.Windows.Forms.Button();
            this.InsertCpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassPositiondataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "班级干部管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClassPositiondataGridView);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 382);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "班级干部信息（可直接在表格中修改）";
            // 
            // ClassPositiondataGridView
            // 
            this.ClassPositiondataGridView.AllowUserToAddRows = false;
            this.ClassPositiondataGridView.AllowUserToDeleteRows = false;
            this.ClassPositiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassPositiondataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassPositiondataGridView.Location = new System.Drawing.Point(3, 17);
            this.ClassPositiondataGridView.Name = "ClassPositiondataGridView";
            this.ClassPositiondataGridView.RowTemplate.Height = 23;
            this.ClassPositiondataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassPositiondataGridView.Size = new System.Drawing.Size(600, 314);
            this.ClassPositiondataGridView.TabIndex = 4;
            this.ClassPositiondataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassPositiondataGridView_CellEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RefreshBtn);
            this.groupBox3.Controls.Add(this.ModifyBtn);
            this.groupBox3.Controls.Add(this.DelBtn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 48);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(375, 17);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 11;
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click_1);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Enabled = false;
            this.ModifyBtn.Location = new System.Drawing.Point(239, 17);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyBtn.TabIndex = 10;
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
            this.DelBtn.TabIndex = 9;
            this.DelBtn.Text = "删除记录";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PositionCBox);
            this.groupBox1.Controls.Add(this.PastradioButton);
            this.groupBox1.Controls.Add(this.NowradioButton);
            this.groupBox1.Controls.Add(this.EdateTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BdateTime);
            this.groupBox1.Controls.Add(this.上任日期);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SnoTBox);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.DrawBackBtn);
            this.groupBox1.Controls.Add(this.InsertCpBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "班级干部信息";
            // 
            // PositionCBox
            // 
            this.PositionCBox.FormattingEnabled = true;
            this.PositionCBox.Items.AddRange(new object[] {
            "班长",
            "副班长",
            "学习委员",
            "体育委员",
            "生活委员",
            "组织委员",
            "宣传委员"});
            this.PositionCBox.Location = new System.Drawing.Point(312, 12);
            this.PositionCBox.Name = "PositionCBox";
            this.PositionCBox.Size = new System.Drawing.Size(153, 20);
            this.PositionCBox.TabIndex = 1;
            // 
            // PastradioButton
            // 
            this.PastradioButton.AutoSize = true;
            this.PastradioButton.Location = new System.Drawing.Point(532, 14);
            this.PastradioButton.Name = "PastradioButton";
            this.PastradioButton.Size = new System.Drawing.Size(47, 16);
            this.PastradioButton.TabIndex = 3;
            this.PastradioButton.Text = "前任";
            this.PastradioButton.UseVisualStyleBackColor = true;
            // 
            // NowradioButton
            // 
            this.NowradioButton.AutoSize = true;
            this.NowradioButton.Checked = true;
            this.NowradioButton.Location = new System.Drawing.Point(480, 14);
            this.NowradioButton.Name = "NowradioButton";
            this.NowradioButton.Size = new System.Drawing.Size(47, 16);
            this.NowradioButton.TabIndex = 2;
            this.NowradioButton.TabStop = true;
            this.NowradioButton.Text = "现任";
            this.NowradioButton.UseVisualStyleBackColor = true;
            // 
            // EdateTime
            // 
            this.EdateTime.Location = new System.Drawing.Point(366, 38);
            this.EdateTime.Name = "EdateTime";
            this.EdateTime.Size = new System.Drawing.Size(214, 21);
            this.EdateTime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "离职日期：";
            // 
            // BdateTime
            // 
            this.BdateTime.Location = new System.Drawing.Point(77, 40);
            this.BdateTime.Name = "BdateTime";
            this.BdateTime.Size = new System.Drawing.Size(187, 21);
            this.BdateTime.TabIndex = 4;
            // 
            // 上任日期
            // 
            this.上任日期.AutoSize = true;
            this.上任日期.Location = new System.Drawing.Point(6, 44);
            this.上任日期.Name = "上任日期";
            this.上任日期.Size = new System.Drawing.Size(65, 12);
            this.上任日期.TabIndex = 41;
            this.上任日期.Text = "上任日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "学    号：";
            // 
            // SnoTBox
            // 
            this.SnoTBox.Location = new System.Drawing.Point(80, 13);
            this.SnoTBox.Name = "SnoTBox";
            this.SnoTBox.Size = new System.Drawing.Size(142, 21);
            this.SnoTBox.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(230, 67);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DrawBackBtn
            // 
            this.DrawBackBtn.Location = new System.Drawing.Point(504, 67);
            this.DrawBackBtn.Name = "DrawBackBtn";
            this.DrawBackBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawBackBtn.TabIndex = 8;
            this.DrawBackBtn.Text = "撤销";
            this.DrawBackBtn.UseVisualStyleBackColor = true;
            this.DrawBackBtn.Click += new System.EventHandler(this.DrawBackBtn_Click_1);
            // 
            // InsertCpBtn
            // 
            this.InsertCpBtn.Enabled = false;
            this.InsertCpBtn.Location = new System.Drawing.Point(367, 67);
            this.InsertCpBtn.Name = "InsertCpBtn";
            this.InsertCpBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertCpBtn.TabIndex = 7;
            this.InsertCpBtn.Text = "录入";
            this.InsertCpBtn.UseVisualStyleBackColor = true;
            this.InsertCpBtn.Click += new System.EventHandler(this.InsertCpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级职务：\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 512);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
            // 
            // ClassPositionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ClassPositionUC";
            this.Size = new System.Drawing.Size(620, 512);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassPositiondataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker EdateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BdateTime;
        private System.Windows.Forms.Label 上任日期;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SnoTBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DrawBackBtn;
        private System.Windows.Forms.Button InsertCpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RadioButton PastradioButton;
        private System.Windows.Forms.RadioButton NowradioButton;
        private System.Windows.Forms.ComboBox PositionCBox;
        private System.Windows.Forms.DataGridView ClassPositiondataGridView;


    }
}
