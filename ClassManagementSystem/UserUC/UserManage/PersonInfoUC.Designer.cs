namespace ClassManagementSystem.UserManage
{
    partial class PersonInfoUC
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
            this.InfoPage = new System.Windows.Forms.TabPage();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.SexCBox = new System.Windows.Forms.ComboBox();
            this.SpecTBox = new System.Windows.Forms.TextBox();
            this.ClassTBox = new System.Windows.Forms.TextBox();
            this.SnameTBox = new System.Windows.Forms.TextBox();
            this.SnoTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.InfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InfoPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 479);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
            // 
            // InfoPage
            // 
            this.InfoPage.Controls.Add(this.CancelBtn);
            this.InfoPage.Controls.Add(this.SaveBtn);
            this.InfoPage.Controls.Add(this.BirthDate);
            this.InfoPage.Controls.Add(this.SexCBox);
            this.InfoPage.Controls.Add(this.SpecTBox);
            this.InfoPage.Controls.Add(this.ClassTBox);
            this.InfoPage.Controls.Add(this.SnameTBox);
            this.InfoPage.Controls.Add(this.SnoTBox);
            this.InfoPage.Controls.Add(this.label6);
            this.InfoPage.Controls.Add(this.label5);
            this.InfoPage.Controls.Add(this.label4);
            this.InfoPage.Controls.Add(this.label3);
            this.InfoPage.Controls.Add(this.label2);
            this.InfoPage.Controls.Add(this.label1);
            this.InfoPage.Location = new System.Drawing.Point(4, 22);
            this.InfoPage.Name = "InfoPage";
            this.InfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.InfoPage.Size = new System.Drawing.Size(594, 453);
            this.InfoPage.TabIndex = 0;
            this.InfoPage.Text = "用户个人信息";
            this.InfoPage.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(309, 388);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(89, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(153, 388);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(89, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "保存信息";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(258, 199);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(140, 21);
            this.BirthDate.TabIndex = 3;
            // 
            // SexCBox
            // 
            this.SexCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexCBox.FormattingEnabled = true;
            this.SexCBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.SexCBox.Location = new System.Drawing.Point(258, 149);
            this.SexCBox.Name = "SexCBox";
            this.SexCBox.Size = new System.Drawing.Size(140, 20);
            this.SexCBox.TabIndex = 2;
            // 
            // SpecTBox
            // 
            this.SpecTBox.Location = new System.Drawing.Point(258, 302);
            this.SpecTBox.Name = "SpecTBox";
            this.SpecTBox.Size = new System.Drawing.Size(140, 21);
            this.SpecTBox.TabIndex = 1;
            // 
            // ClassTBox
            // 
            this.ClassTBox.Location = new System.Drawing.Point(258, 251);
            this.ClassTBox.Name = "ClassTBox";
            this.ClassTBox.Size = new System.Drawing.Size(140, 21);
            this.ClassTBox.TabIndex = 1;
            // 
            // SnameTBox
            // 
            this.SnameTBox.Location = new System.Drawing.Point(258, 98);
            this.SnameTBox.Name = "SnameTBox";
            this.SnameTBox.Size = new System.Drawing.Size(140, 21);
            this.SnameTBox.TabIndex = 1;
            // 
            // SnoTBox
            // 
            this.SnoTBox.Location = new System.Drawing.Point(258, 47);
            this.SnoTBox.Name = "SnoTBox";
            this.SnoTBox.ReadOnly = true;
            this.SnoTBox.Size = new System.Drawing.Size(140, 21);
            this.SnoTBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(150, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "专    业：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(150, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "班    级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(150, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "出生日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(150, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "性    别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(150, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓    名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(150, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "学    号：";
            // 
            // PersonInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "PersonInfoUC";
            this.Size = new System.Drawing.Size(602, 479);
            this.tabControl1.ResumeLayout(false);
            this.InfoPage.ResumeLayout(false);
            this.InfoPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InfoPage;
        private System.Windows.Forms.ComboBox SexCBox;
        private System.Windows.Forms.TextBox SpecTBox;
        private System.Windows.Forms.TextBox ClassTBox;
        private System.Windows.Forms.TextBox SnameTBox;
        private System.Windows.Forms.TextBox SnoTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Button CancelBtn;
    }
}
