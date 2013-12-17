namespace ClassManagementSystem.UserManage
{
    partial class AddUserUC
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
            this.AddtabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DrawBackBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SnoTBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UserTypeCBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.AddtabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddtabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // AddtabPage
            // 
            this.AddtabPage.Controls.Add(this.groupBox2);
            this.AddtabPage.Controls.Add(this.groupBox1);
            this.AddtabPage.Location = new System.Drawing.Point(4, 21);
            this.AddtabPage.Name = "AddtabPage";
            this.AddtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddtabPage.Size = new System.Drawing.Size(541, 476);
            this.AddtabPage.TabIndex = 0;
            this.AddtabPage.Text = "添加用户";
            this.AddtabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserTypeCBox);
            this.groupBox1.Controls.Add(this.DrawBackBtn);
            this.groupBox1.Controls.Add(this.AddUserBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.SnoTBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // DrawBackBtn
            // 
            this.DrawBackBtn.Location = new System.Drawing.Point(443, 52);
            this.DrawBackBtn.Name = "DrawBackBtn";
            this.DrawBackBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawBackBtn.TabIndex = 39;
            this.DrawBackBtn.Text = "撤销";
            this.DrawBackBtn.UseVisualStyleBackColor = true;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(329, 52);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(75, 23);
            this.AddUserBtn.TabIndex = 38;
            this.AddUserBtn.Text = "添加";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "用户类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "用户名：";
            // 
            // SnoTBox
            // 
            this.SnoTBox.Location = new System.Drawing.Point(63, 20);
            this.SnoTBox.Name = "SnoTBox";
            this.SnoTBox.Size = new System.Drawing.Size(109, 21);
            this.SnoTBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 21);
            this.textBox1.TabIndex = 1;
            // 
            // UserTypeCBox
            // 
            this.UserTypeCBox.FormattingEnabled = true;
            this.UserTypeCBox.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.UserTypeCBox.Location = new System.Drawing.Point(410, 23);
            this.UserTypeCBox.Name = "UserTypeCBox";
            this.UserTypeCBox.Size = new System.Drawing.Size(108, 20);
            this.UserTypeCBox.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UserdataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 385);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前用户列表";
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.AllowUserToAddRows = false;
            this.UserdataGridView.AllowUserToDeleteRows = false;
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserdataGridView.Location = new System.Drawing.Point(3, 17);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.ReadOnly = true;
            this.UserdataGridView.RowTemplate.Height = 23;
            this.UserdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserdataGridView.Size = new System.Drawing.Size(529, 365);
            this.UserdataGridView.TabIndex = 0;
            // 
            // AddUserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AddUserUC";
            this.Size = new System.Drawing.Size(549, 501);
            this.tabControl1.ResumeLayout(false);
            this.AddtabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddtabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.ComboBox UserTypeCBox;
        private System.Windows.Forms.Button DrawBackBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox SnoTBox;
    }
}
