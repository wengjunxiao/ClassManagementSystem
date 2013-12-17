namespace ClassManagementSystem.StudentInfoManage
{
    partial class ModifySInfoUC
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
            this.ModifytabControl = new System.Windows.Forms.TabControl();
            this.ModifyTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UploadPhotoBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StuddataGridView = new System.Windows.Forms.DataGridView();
            this.PhotoopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ModifytabControl.SuspendLayout();
            this.ModifyTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifytabControl
            // 
            this.ModifytabControl.Controls.Add(this.ModifyTabPage);
            this.ModifytabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifytabControl.Location = new System.Drawing.Point(0, 0);
            this.ModifytabControl.Name = "ModifytabControl";
            this.ModifytabControl.SelectedIndex = 0;
            this.ModifytabControl.Size = new System.Drawing.Size(597, 502);
            this.ModifytabControl.TabIndex = 0;
            // 
            // ModifyTabPage
            // 
            this.ModifyTabPage.Controls.Add(this.groupBox2);
            this.ModifyTabPage.Controls.Add(this.groupBox1);
            this.ModifyTabPage.Location = new System.Drawing.Point(4, 21);
            this.ModifyTabPage.Name = "ModifyTabPage";
            this.ModifyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ModifyTabPage.Size = new System.Drawing.Size(589, 477);
            this.ModifyTabPage.TabIndex = 0;
            this.ModifyTabPage.Text = "修改学生信息";
            this.ModifyTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UploadPhotoBtn);
            this.groupBox2.Controls.Add(this.DelBtn);
            this.groupBox2.Controls.Add(this.RefreshBtn);
            this.groupBox2.Controls.Add(this.ModifyBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // UploadPhotoBtn
            // 
            this.UploadPhotoBtn.Location = new System.Drawing.Point(72, 19);
            this.UploadPhotoBtn.Name = "UploadPhotoBtn";
            this.UploadPhotoBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadPhotoBtn.TabIndex = 3;
            this.UploadPhotoBtn.Text = "上传新照片";
            this.UploadPhotoBtn.UseVisualStyleBackColor = true;
            this.UploadPhotoBtn.Click += new System.EventHandler(this.UploadPhotoBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(196, 19);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "删除";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(444, 19);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 1;
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Location = new System.Drawing.Point(320, 19);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyBtn.TabIndex = 0;
            this.ModifyBtn.Text = "保存修改";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StuddataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息（可直接修改信息，照片名在上传照片时修改）";
            // 
            // StuddataGridView
            // 
            this.StuddataGridView.AllowUserToAddRows = false;
            this.StuddataGridView.AllowUserToDeleteRows = false;
            this.StuddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuddataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuddataGridView.Location = new System.Drawing.Point(3, 17);
            this.StuddataGridView.Name = "StuddataGridView";
            this.StuddataGridView.RowTemplate.Height = 23;
            this.StuddataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StuddataGridView.Size = new System.Drawing.Size(577, 388);
            this.StuddataGridView.TabIndex = 0;
            this.StuddataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StuddataGridView_CellEnter);
            // 
            // PhotoopenFileDialog
            // 
            this.PhotoopenFileDialog.FileName = "openFileDialog1";
            // 
            // ModifySInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModifytabControl);
            this.Name = "ModifySInfoUC";
            this.Size = new System.Drawing.Size(597, 502);
            this.ModifytabControl.ResumeLayout(false);
            this.ModifyTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuddataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ModifytabControl;
        private System.Windows.Forms.TabPage ModifyTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.DataGridView StuddataGridView;
        private System.Windows.Forms.Button UploadPhotoBtn;
        private System.Windows.Forms.OpenFileDialog PhotoopenFileDialog;
    }
}
