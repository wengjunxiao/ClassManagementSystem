namespace ClassManagementSystem.ClassActivityManage
{
    partial class ClassActivityUC
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
            this.ClassActivitydataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ActdateTime = new System.Windows.Forms.DateTimePicker();
            this.AppendixNameLab = new System.Windows.Forms.Label();
            this.AttachLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivityNameTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DrawBackBtn = new System.Windows.Forms.Button();
            this.InsertCaBtn = new System.Windows.Forms.Button();
            this.AppendixopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassActivitydataGridView)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
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
            this.tabPage1.Text = "班级活动管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClassActivitydataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 372);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "班级活动信息（可直接在表格中修改）";
            // 
            // ClassActivitydataGridView
            // 
            this.ClassActivitydataGridView.AllowUserToAddRows = false;
            this.ClassActivitydataGridView.AllowUserToDeleteRows = false;
            this.ClassActivitydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassActivitydataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassActivitydataGridView.Location = new System.Drawing.Point(3, 17);
            this.ClassActivitydataGridView.Name = "ClassActivitydataGridView";
            this.ClassActivitydataGridView.RowTemplate.Height = 23;
            this.ClassActivitydataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassActivitydataGridView.Size = new System.Drawing.Size(555, 352);
            this.ClassActivitydataGridView.TabIndex = 1;
            this.ClassActivitydataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassActivitydataGridView_CellEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OpenBtn);
            this.groupBox3.Controls.Add(this.Upload);
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
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(131, 13);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.Text = "打开附件";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // Upload
            // 
            this.Upload.Enabled = false;
            this.Upload.Location = new System.Drawing.Point(28, 13);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 1;
            this.Upload.Text = "上传新附件";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(440, 13);
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
            this.ModifyBtn.Location = new System.Drawing.Point(337, 13);
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
            this.DelBtn.Location = new System.Drawing.Point(234, 13);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 0;
            this.DelBtn.Text = "删除记录";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ActdateTime);
            this.groupBox1.Controls.Add(this.AppendixNameLab);
            this.groupBox1.Controls.Add(this.AttachLinkLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ActivityNameTBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.DrawBackBtn);
            this.groupBox1.Controls.Add(this.InsertCaBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "班级活动信息";
            // 
            // ActdateTime
            // 
            this.ActdateTime.Location = new System.Drawing.Point(271, 13);
            this.ActdateTime.Name = "ActdateTime";
            this.ActdateTime.Size = new System.Drawing.Size(141, 21);
            this.ActdateTime.TabIndex = 81;
            // 
            // AppendixNameLab
            // 
            this.AppendixNameLab.AutoSize = true;
            this.AppendixNameLab.Location = new System.Drawing.Point(499, 17);
            this.AppendixNameLab.Name = "AppendixNameLab";
            this.AppendixNameLab.Size = new System.Drawing.Size(41, 12);
            this.AppendixNameLab.TabIndex = 80;
            this.AppendixNameLab.Text = "label5";
            // 
            // AttachLinkLabel
            // 
            this.AttachLinkLabel.AutoSize = true;
            this.AttachLinkLabel.Location = new System.Drawing.Point(424, 17);
            this.AttachLinkLabel.Name = "AttachLinkLabel";
            this.AttachLinkLabel.Size = new System.Drawing.Size(59, 12);
            this.AttachLinkLabel.TabIndex = 79;
            this.AttachLinkLabel.TabStop = true;
            this.AttachLinkLabel.Text = "添加附件:";
            this.AttachLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AttachLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "活动日期：";
            // 
            // ActivityNameTBox
            // 
            this.ActivityNameTBox.Location = new System.Drawing.Point(77, 14);
            this.ActivityNameTBox.Name = "ActivityNameTBox";
            this.ActivityNameTBox.Size = new System.Drawing.Size(117, 21);
            this.ActivityNameTBox.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "活动名称：";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(202, 40);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 41;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DrawBackBtn
            // 
            this.DrawBackBtn.Location = new System.Drawing.Point(464, 40);
            this.DrawBackBtn.Name = "DrawBackBtn";
            this.DrawBackBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawBackBtn.TabIndex = 40;
            this.DrawBackBtn.Text = "撤销";
            this.DrawBackBtn.UseVisualStyleBackColor = true;
            this.DrawBackBtn.Click += new System.EventHandler(this.DrawBackBtn_Click);
            // 
            // InsertCaBtn
            // 
            this.InsertCaBtn.Enabled = false;
            this.InsertCaBtn.Location = new System.Drawing.Point(333, 40);
            this.InsertCaBtn.Name = "InsertCaBtn";
            this.InsertCaBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertCaBtn.TabIndex = 39;
            this.InsertCaBtn.Text = "录入";
            this.InsertCaBtn.UseVisualStyleBackColor = true;
            this.InsertCaBtn.Click += new System.EventHandler(this.InsertCaBtn_Click);
            // 
            // ClassActivityUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ClassActivityUC";
            this.Size = new System.Drawing.Size(575, 512);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassActivitydataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ClassActivitydataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ActivityNameTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DrawBackBtn;
        private System.Windows.Forms.Button InsertCaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label AppendixNameLab;
        private System.Windows.Forms.LinkLabel AttachLinkLabel;
        private System.Windows.Forms.OpenFileDialog AppendixopenFileDialog;
        private System.Windows.Forms.DateTimePicker ActdateTime;
    }
}
