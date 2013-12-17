namespace ClassManagementSystem
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccountManToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassManToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassPositionMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlanMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassActivityManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassFileMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassFeeMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentManToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsInfoMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsInfoInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsInfoSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsInfoModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsAttendanceMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsRewardsPunishmentsMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PenaltyTooltripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShoolYearZEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PersonalInfoLab = new System.Windows.Forms.Label();
            this.ModifyLab = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ModifyPhoto = new System.Windows.Forms.Label();
            this.MypictureBox = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PhotoopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MypictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountManToolStripMenuItem,
            this.ClassManToolStripMenuItem,
            this.StudentManToolStripMenuItem,
            this.ShoolYearZEToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.ExitSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccountManToolStripMenuItem
            // 
            this.AccountManToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserToolStripMenuItem,
            this.DelUserToolStripMenuItem});
            this.AccountManToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_0520;
            this.AccountManToolStripMenuItem.Name = "AccountManToolStripMenuItem";
            this.AccountManToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.AccountManToolStripMenuItem.Text = "用户管理";
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Enabled = false;
            this.AddUserToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_0520;
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.AddUserToolStripMenuItem.Text = "增加用户";
            this.AddUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // DelUserToolStripMenuItem
            // 
            this.DelUserToolStripMenuItem.Enabled = false;
            this.DelUserToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.Comic_Icons_3_back;
            this.DelUserToolStripMenuItem.Name = "DelUserToolStripMenuItem";
            this.DelUserToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.DelUserToolStripMenuItem.Text = "删除用户";
            this.DelUserToolStripMenuItem.Click += new System.EventHandler(this.DelUserToolStripMenuItem_Click);
            // 
            // ClassManToolStripMenuItem
            // 
            this.ClassManToolStripMenuItem.AutoSize = false;
            this.ClassManToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClassPositionMangementToolStripMenuItem,
            this.PlanMangementToolStripMenuItem,
            this.ClassActivityManagementToolStripMenuItem,
            this.ClassFileMangementToolStripMenuItem,
            this.ClassFeeMangementToolStripMenuItem});
            this.ClassManToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_0656;
            this.ClassManToolStripMenuItem.Name = "ClassManToolStripMenuItem";
            this.ClassManToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ClassManToolStripMenuItem.Text = "班级管理";
            // 
            // ClassPositionMangementToolStripMenuItem
            // 
            this.ClassPositionMangementToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_08401;
            this.ClassPositionMangementToolStripMenuItem.Name = "ClassPositionMangementToolStripMenuItem";
            this.ClassPositionMangementToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ClassPositionMangementToolStripMenuItem.Text = "班级干部管理";
            this.ClassPositionMangementToolStripMenuItem.Click += new System.EventHandler(this.ClassPositionMangementToolStripMenuItem_Click);
            // 
            // PlanMangementToolStripMenuItem
            // 
            this.PlanMangementToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_0570;
            this.PlanMangementToolStripMenuItem.Name = "PlanMangementToolStripMenuItem";
            this.PlanMangementToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.PlanMangementToolStripMenuItem.Text = "班委工作计划管理";
            this.PlanMangementToolStripMenuItem.Click += new System.EventHandler(this.PlanMangementToolStripMenuItem_Click);
            // 
            // ClassActivityManagementToolStripMenuItem
            // 
            this.ClassActivityManagementToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_0701;
            this.ClassActivityManagementToolStripMenuItem.Name = "ClassActivityManagementToolStripMenuItem";
            this.ClassActivityManagementToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ClassActivityManagementToolStripMenuItem.Text = "班级活动管理";
            this.ClassActivityManagementToolStripMenuItem.Click += new System.EventHandler(this.ClassActivityManagementToolStripMenuItem_Click);
            // 
            // ClassFileMangementToolStripMenuItem
            // 
            this.ClassFileMangementToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.PNG_0986;
            this.ClassFileMangementToolStripMenuItem.Name = "ClassFileMangementToolStripMenuItem";
            this.ClassFileMangementToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ClassFileMangementToolStripMenuItem.Text = "班级文档管理";
            this.ClassFileMangementToolStripMenuItem.Click += new System.EventHandler(this.ClassFileMangementToolStripMenuItem_Click);
            // 
            // ClassFeeMangementToolStripMenuItem
            // 
            this.ClassFeeMangementToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_0585;
            this.ClassFeeMangementToolStripMenuItem.Name = "ClassFeeMangementToolStripMenuItem";
            this.ClassFeeMangementToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ClassFeeMangementToolStripMenuItem.Text = "班级费用管理";
            this.ClassFeeMangementToolStripMenuItem.Click += new System.EventHandler(this.ClassFeeMangementToolStripMenuItem_Click);
            // 
            // StudentManToolStripMenuItem
            // 
            this.StudentManToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentsInfoMangementToolStripMenuItem,
            this.StudentsAttendanceMangementToolStripMenuItem,
            this.StudentsRewardsPunishmentsMangementToolStripMenuItem});
            this.StudentManToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.PNG_08861;
            this.StudentManToolStripMenuItem.Name = "StudentManToolStripMenuItem";
            this.StudentManToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.StudentManToolStripMenuItem.Text = "学生管理";
            // 
            // StudentsInfoMangementToolStripMenuItem
            // 
            this.StudentsInfoMangementToolStripMenuItem.AccessibleDescription = "";
            this.StudentsInfoMangementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentsInfoInsertToolStripMenuItem,
            this.StudentsInfoSearchToolStripMenuItem,
            this.StudentsInfoModifyToolStripMenuItem});
            this.StudentsInfoMangementToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_0758;
            this.StudentsInfoMangementToolStripMenuItem.Name = "StudentsInfoMangementToolStripMenuItem";
            this.StudentsInfoMangementToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.StudentsInfoMangementToolStripMenuItem.Text = "学生信息管理";
            // 
            // StudentsInfoInsertToolStripMenuItem
            // 
            this.StudentsInfoInsertToolStripMenuItem.Enabled = false;
            this.StudentsInfoInsertToolStripMenuItem.Name = "StudentsInfoInsertToolStripMenuItem";
            this.StudentsInfoInsertToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.StudentsInfoInsertToolStripMenuItem.Text = "学生信息录入";
            this.StudentsInfoInsertToolStripMenuItem.Click += new System.EventHandler(this.StudentsInfoInsertToolStripMenuItem_Click);
            // 
            // StudentsInfoSearchToolStripMenuItem
            // 
            this.StudentsInfoSearchToolStripMenuItem.Name = "StudentsInfoSearchToolStripMenuItem";
            this.StudentsInfoSearchToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.StudentsInfoSearchToolStripMenuItem.Text = "学生信息查询";
            this.StudentsInfoSearchToolStripMenuItem.Click += new System.EventHandler(this.StudentsInfoSearchToolStripMenuItem_Click);
            // 
            // StudentsInfoModifyToolStripMenuItem
            // 
            this.StudentsInfoModifyToolStripMenuItem.Enabled = false;
            this.StudentsInfoModifyToolStripMenuItem.Name = "StudentsInfoModifyToolStripMenuItem";
            this.StudentsInfoModifyToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.StudentsInfoModifyToolStripMenuItem.Text = "学生信息修改";
            this.StudentsInfoModifyToolStripMenuItem.Click += new System.EventHandler(this.StudentsInfoModifyToolStripMenuItem_Click);
            // 
            // StudentsAttendanceMangementToolStripMenuItem
            // 
            this.StudentsAttendanceMangementToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_050611;
            this.StudentsAttendanceMangementToolStripMenuItem.Name = "StudentsAttendanceMangementToolStripMenuItem";
            this.StudentsAttendanceMangementToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.StudentsAttendanceMangementToolStripMenuItem.Text = "学生考勤管理";
            this.StudentsAttendanceMangementToolStripMenuItem.Click += new System.EventHandler(this.StudentsAttendanceMangementToolStripMenuItem_Click);
            // 
            // StudentsRewardsPunishmentsMangementToolStripMenuItem
            // 
            this.StudentsRewardsPunishmentsMangementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RewardToolStripMenuItem,
            this.PenaltyTooltripMenuItem});
            this.StudentsRewardsPunishmentsMangementToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources._2337CE614DBD6B4CAEF850A5CF8493C7;
            this.StudentsRewardsPunishmentsMangementToolStripMenuItem.Name = "StudentsRewardsPunishmentsMangementToolStripMenuItem";
            this.StudentsRewardsPunishmentsMangementToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.StudentsRewardsPunishmentsMangementToolStripMenuItem.Text = "学生奖惩管理";
            // 
            // RewardToolStripMenuItem
            // 
            this.RewardToolStripMenuItem.Name = "RewardToolStripMenuItem";
            this.RewardToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.RewardToolStripMenuItem.Text = "奖励模块管理";
            this.RewardToolStripMenuItem.Click += new System.EventHandler(this.RewardToolStripMenuItem_Click);
            // 
            // PenaltyTooltripMenuItem
            // 
            this.PenaltyTooltripMenuItem.AccessibleDescription = "";
            this.PenaltyTooltripMenuItem.Name = "PenaltyTooltripMenuItem";
            this.PenaltyTooltripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.PenaltyTooltripMenuItem.Text = "惩罚模块管理";
            this.PenaltyTooltripMenuItem.Click += new System.EventHandler(this.PenaltyTooltripMenuItem_Click);
            // 
            // ShoolYearZEToolStripMenuItem
            // 
            this.ShoolYearZEToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.PNG_09471;
            this.ShoolYearZEToolStripMenuItem.Name = "ShoolYearZEToolStripMenuItem";
            this.ShoolYearZEToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.ShoolYearZEToolStripMenuItem.Text = "学年综合评测";
            this.ShoolYearZEToolStripMenuItem.Click += new System.EventHandler(this.ShoolYearZEToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsageToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.png_05061;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "关于我们";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ExitSystemToolStripMenuItem
            // 
            this.ExitSystemToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitSystemToolStripMenuItem.Image = global::ClassManagementSystem.Properties.Resources.Comic_Icons_3_button_cancel1;
            this.ExitSystemToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ExitSystemToolStripMenuItem.Name = "ExitSystemToolStripMenuItem";
            this.ExitSystemToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ExitSystemToolStripMenuItem.Text = "退出系统";
            this.ExitSystemToolStripMenuItem.Click += new System.EventHandler(this.ExitSystemToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dateStripStatusLabel1
            // 
            this.dateStripStatusLabel1.Name = "dateStripStatusLabel1";
            this.dateStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录用户：";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(83, 80);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 12);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "uname";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户类型：";
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(83, 174);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(29, 12);
            this.lblUserType.TabIndex = 3;
            this.lblUserType.Text = "type";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.PersonalInfoLab);
            this.groupBox1.Controls.Add(this.ModifyLab);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(0, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // PersonalInfoLab
            // 
            this.PersonalInfoLab.AutoSize = true;
            this.PersonalInfoLab.BackColor = System.Drawing.Color.Transparent;
            this.PersonalInfoLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonalInfoLab.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PersonalInfoLab.ForeColor = System.Drawing.Color.Blue;
            this.PersonalInfoLab.Location = new System.Drawing.Point(83, 250);
            this.PersonalInfoLab.Name = "PersonalInfoLab";
            this.PersonalInfoLab.Size = new System.Drawing.Size(57, 12);
            this.PersonalInfoLab.TabIndex = 12;
            this.PersonalInfoLab.Text = "个人信息";
            this.PersonalInfoLab.Click += new System.EventHandler(this.PersonalInfoLab_Click);
            // 
            // ModifyLab
            // 
            this.ModifyLab.AutoSize = true;
            this.ModifyLab.BackColor = System.Drawing.Color.Transparent;
            this.ModifyLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifyLab.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModifyLab.ForeColor = System.Drawing.Color.Blue;
            this.ModifyLab.Location = new System.Drawing.Point(12, 250);
            this.ModifyLab.Name = "ModifyLab";
            this.ModifyLab.Size = new System.Drawing.Size(57, 12);
            this.ModifyLab.TabIndex = 12;
            this.ModifyLab.Text = "修改密码";
            this.ModifyLab.Click += new System.EventHandler(this.ModifyLab_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.ModifyPhoto);
            this.groupBox3.Controls.Add(this.MypictureBox);
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(0, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 229);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "头像";
            // 
            // ModifyPhoto
            // 
            this.ModifyPhoto.AutoSize = true;
            this.ModifyPhoto.BackColor = System.Drawing.Color.Transparent;
            this.ModifyPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifyPhoto.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModifyPhoto.ForeColor = System.Drawing.Color.Blue;
            this.ModifyPhoto.Location = new System.Drawing.Point(59, 199);
            this.ModifyPhoto.Name = "ModifyPhoto";
            this.ModifyPhoto.Size = new System.Drawing.Size(57, 12);
            this.ModifyPhoto.TabIndex = 13;
            this.ModifyPhoto.Text = "修改头像";
            this.ModifyPhoto.Click += new System.EventHandler(this.ModifyPhoto_Click);
            // 
            // MypictureBox
            // 
            this.MypictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MypictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MypictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MypictureBox.ErrorImage = null;
            this.MypictureBox.Image = global::ClassManagementSystem.Properties.Resources.png_0656;
            this.MypictureBox.Location = new System.Drawing.Point(12, 34);
            this.MypictureBox.Name = "MypictureBox";
            this.MypictureBox.Size = new System.Drawing.Size(146, 148);
            this.MypictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MypictureBox.TabIndex = 12;
            this.MypictureBox.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(180, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(610, 519);
            this.MainPanel.TabIndex = 5;
            // 
            // UsageToolStripMenuItem
            // 
            this.UsageToolStripMenuItem.Name = "UsageToolStripMenuItem";
            this.UsageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.UsageToolStripMenuItem.Text = "使用说明";
            this.UsageToolStripMenuItem.Click += new System.EventHandler(this.UsageToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 571);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级信息管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MypictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccountManToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassManToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentManToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShoolYearZEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassPositionMangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlanMangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassActivityManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassFileMangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassFeeMangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsInfoMangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsAttendanceMangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsRewardsPunishmentsMangementToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel dateStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsInfoInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsInfoSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsInfoModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RewardToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ModifyLab;
        private System.Windows.Forms.PictureBox MypictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PenaltyTooltripMenuItem;
        private System.Windows.Forms.Label ModifyPhoto;
        private System.Windows.Forms.OpenFileDialog PhotoopenFileDialog;
        private System.Windows.Forms.Label PersonalInfoLab;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsageToolStripMenuItem;
    }
}