namespace ClassManagementSystem.StuOverallEvaManage
{
    partial class StuOverallEva
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
            this.StuOverallEvadataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MSoreTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PscoreTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SnoTBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DrawBackBtn = new System.Windows.Forms.Button();
            this.InsertSOEBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuOverallEvadataGridView)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(620, 512);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
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
            this.tabPage1.Text = "学年综合评测";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StuOverallEvadataGridView);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 412);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学年综合评测信息（可直接在表格中修改）";
            // 
            // StuOverallEvadataGridView
            // 
            this.StuOverallEvadataGridView.AllowUserToAddRows = false;
            this.StuOverallEvadataGridView.AllowUserToDeleteRows = false;
            this.StuOverallEvadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuOverallEvadataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuOverallEvadataGridView.Location = new System.Drawing.Point(3, 17);
            this.StuOverallEvadataGridView.Name = "StuOverallEvadataGridView";
            this.StuOverallEvadataGridView.RowTemplate.Height = 23;
            this.StuOverallEvadataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StuOverallEvadataGridView.Size = new System.Drawing.Size(600, 350);
            this.StuOverallEvadataGridView.TabIndex = 4;
            this.StuOverallEvadataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StuOverallEvadataGridView_CellEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RefreshBtn);
            this.groupBox3.Controls.Add(this.ModifyBtn);
            this.groupBox3.Controls.Add(this.DelBtn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 42);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(375, 15);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 11;
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Enabled = false;
            this.ModifyBtn.Location = new System.Drawing.Point(239, 15);
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
            this.DelBtn.Location = new System.Drawing.Point(103, 15);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 9;
            this.DelBtn.Text = "删除记录";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MSoreTBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PscoreTBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SnoTBox);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.DrawBackBtn);
            this.groupBox1.Controls.Add(this.InsertSOEBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学年综合评测信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "德育成绩：";
            // 
            // MSoreTBox
            // 
            this.MSoreTBox.Location = new System.Drawing.Point(485, 12);
            this.MSoreTBox.Name = "MSoreTBox";
            this.MSoreTBox.Size = new System.Drawing.Size(94, 21);
            this.MSoreTBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "专业成绩：";
            // 
            // PscoreTBox
            // 
            this.PscoreTBox.Location = new System.Drawing.Point(299, 12);
            this.PscoreTBox.Name = "PscoreTBox";
            this.PscoreTBox.Size = new System.Drawing.Size(88, 21);
            this.PscoreTBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
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
            this.SearchBtn.Location = new System.Drawing.Point(230, 39);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DrawBackBtn
            // 
            this.DrawBackBtn.Location = new System.Drawing.Point(504, 39);
            this.DrawBackBtn.Name = "DrawBackBtn";
            this.DrawBackBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawBackBtn.TabIndex = 8;
            this.DrawBackBtn.Text = "撤销";
            this.DrawBackBtn.UseVisualStyleBackColor = true;
            this.DrawBackBtn.Click += new System.EventHandler(this.DrawBackBtn_Click);
            // 
            // InsertSOEBtn
            // 
            this.InsertSOEBtn.Enabled = false;
            this.InsertSOEBtn.Location = new System.Drawing.Point(367, 39);
            this.InsertSOEBtn.Name = "InsertSOEBtn";
            this.InsertSOEBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertSOEBtn.TabIndex = 7;
            this.InsertSOEBtn.Text = "录入";
            this.InsertSOEBtn.UseVisualStyleBackColor = true;
            this.InsertSOEBtn.Click += new System.EventHandler(this.InsertSOEBtn_Click);
            // 
            // StuOverallEva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "StuOverallEva";
            this.Size = new System.Drawing.Size(620, 512);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuOverallEvadataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView StuOverallEvadataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SnoTBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DrawBackBtn;
        private System.Windows.Forms.Button InsertSOEBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MSoreTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PscoreTBox;
    }
}
