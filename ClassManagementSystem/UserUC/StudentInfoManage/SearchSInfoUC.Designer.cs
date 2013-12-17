namespace ClassManagementSystem.StudentInfoManage
{
    partial class SearchSInfoUC
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
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StudentsdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.SearchTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SearchTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.groupBox2);
            this.SearchTabPage.Controls.Add(this.groupBox1);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 21);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(566, 484);
            this.SearchTabPage.TabIndex = 1;
            this.SearchTabPage.Text = "学生信息查询";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StudentsdataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 415);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果（点击选中行可查看照片）";
            // 
            // StudentsdataGridView
            // 
            this.StudentsdataGridView.AllowUserToAddRows = false;
            this.StudentsdataGridView.AllowUserToDeleteRows = false;
            this.StudentsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsdataGridView.Location = new System.Drawing.Point(3, 17);
            this.StudentsdataGridView.MultiSelect = false;
            this.StudentsdataGridView.Name = "StudentsdataGridView";
            this.StudentsdataGridView.ReadOnly = true;
            this.StudentsdataGridView.RowTemplate.Height = 23;
            this.StudentsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsdataGridView.Size = new System.Drawing.Size(554, 395);
            this.StudentsdataGridView.TabIndex = 0;
            this.StudentsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsdataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblStuName);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblStuNo);
            this.groupBox1.Controls.Add(this.txtStuNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 57);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件（可选填）";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(230, 24);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(53, 12);
            this.lblStuName.TabIndex = 13;
            this.lblStuName.Text = "姓    名";
            // 
            // txtStuName
            // 
            this.txtStuName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStuName.Location = new System.Drawing.Point(289, 20);
            this.txtStuName.MaxLength = 4;
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(150, 21);
            this.txtStuName.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(465, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "查　询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(6, 24);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(53, 12);
            this.lblStuNo.TabIndex = 12;
            this.lblStuNo.Text = "学    号";
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(65, 20);
            this.txtStuNo.MaxLength = 10;
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(150, 21);
            this.txtStuNo.TabIndex = 3;
            // 
            // SearchSInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchSInfoUC";
            this.Size = new System.Drawing.Size(574, 509);
            this.tabControl1.ResumeLayout(false);
            this.SearchTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView StudentsdataGridView;
    }
}
