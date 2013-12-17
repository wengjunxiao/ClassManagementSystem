using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ClassManagementSystem
{
    public delegate void MyDelegate();
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.lblUserName.Text = UserInfo.User.UserName;
            if (UserInfo.User.IsAdmin)
                this.lblUserType.Text = "管理员";
            else
                this.lblUserType.Text = "普通用户";
            this.InitControl();
            this.ShowPhoto();
            this.MainPanel.Controls.Clear();
            MainUC mainuc = new MainUC();
            this.MainPanel.Controls.Add(mainuc);
            mainuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateStripStatusLabel1.Text = "当前时间：" + DateTime.Now.ToString();
        }

        //录入学生信息
        private void StudentsInfoInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            StudentInfoManage.InsertSInfoUC Iuc = new StudentInfoManage.InsertSInfoUC();
            this.MainPanel.Controls.Add(Iuc);
            Iuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //查询学生信息
        private void StudentsInfoSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            StudentInfoManage.SearchSInfoUC Suc = new StudentInfoManage.SearchSInfoUC();
            this.MainPanel.Controls.Add(Suc);
            Suc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //修改学生信息
        private void StudentsInfoModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            StudentInfoManage.ModifySInfoUC Muc = new StudentInfoManage.ModifySInfoUC();
            this.MainPanel.Controls.Add(Muc);
            Muc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //删除所有在C盘临时文件
        private void DelAllTempFiles()
        {
            string tempFName = Temp.TmpFileName;
            string[] file_names = Directory.GetFiles("\\");
            for (int i = 0; i < file_names.Length; i++)
            {
                string s = Path.GetFileNameWithoutExtension(file_names[i]);
                if (Path.GetFileNameWithoutExtension(file_names[i]) == tempFName)
                    File.Delete(file_names[i]);
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DelAllTempFiles();
        }

        //退出系统
        private void ExitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您确定要退出了吗？","提示",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DR != DialogResult.OK)
                return;
            this.DelAllTempFiles();
            this.Close();
        }

        //考勤管理
        private void StudentsAttendanceMangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            StudAtdInfoManage.StudAtdInfoUC saiuc = new StudAtdInfoManage.StudAtdInfoUC(this);
            this.MainPanel.Controls.Add(saiuc);
            saiuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //班干部管理
        private void ClassPositionMangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            ClassPositionManage.ClassPositionUC cpuc = new ClassPositionManage.ClassPositionUC(this);
            this.MainPanel.Controls.Add(cpuc);
            cpuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //班委工作计划管理
        private void PlanMangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            ClassPlanManage.ClassPlanUC cpuc = new ClassPlanManage.ClassPlanUC(this);
            this.MainPanel.Controls.Add(cpuc);
            cpuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //班级活动管理
        private void ClassActivityManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            ClassActivityManage.ClassActivityUC cauc = new ClassActivityManage.ClassActivityUC(this);
            this.MainPanel.Controls.Add(cauc);
            cauc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //班级文档管理
        private void ClassFileMangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            ClassFileManage.ClassFileUC cfuc = new ClassFileManage.ClassFileUC(this);
            this.MainPanel.Controls.Add(cfuc);
            cfuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();

        }

        //班级费用管理
        private void ClassFeeMangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            ClassFeeManage.ClassFeeUS cfuc = new ClassFeeManage.ClassFeeUS(this);
            this.MainPanel.Controls.Add(cfuc);
            cfuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //学生奖励管理
        private void RewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            RewardPenaltyManage.RewardUC Ruc = new RewardPenaltyManage.RewardUC(this);
            this.MainPanel.Controls.Add(Ruc);
            Ruc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //学生惩罚管理
        private void PenaltyTooltripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            RewardPenaltyManage.PenaltyUC Puc = new RewardPenaltyManage.PenaltyUC(this);
            this.MainPanel.Controls.Add(Puc);
            Puc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        //学年综合测评
        private void ShoolYearZEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            StuOverallEvaManage.StuOverallEva Soe = new StuOverallEvaManage.StuOverallEva(this);
            this.MainPanel.Controls.Add(Soe);
            Soe.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            UserManage.AddUserUC auuc = new UserManage.AddUserUC(this);
            this.MainPanel.Controls.Add(auuc);
            auuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        private void DelUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            UserManage.DelUserUC duuc = new UserManage.DelUserUC(this);
            this.MainPanel.Controls.Add(duuc);
            duuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        private void InitControl()
        {
            if (UserInfo.User.IsAdmin)
            {
                this.AddUserToolStripMenuItem.Enabled = true;
                this.DelUserToolStripMenuItem.Enabled = true;
                this.StudentsInfoInsertToolStripMenuItem.Enabled = true;
                this.StudentsInfoModifyToolStripMenuItem.Enabled = true;
            }
        }

        public void SetPanel()
        {
            this.MainPanel.Controls.Clear();
            MainUC mainuc = new MainUC();
            this.MainPanel.Controls.Add(mainuc);
            mainuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        private void ModifyLab_Click(object sender, EventArgs e)
        {
            UserManage.ModifyForm mof = new UserManage.ModifyForm();
            mof.ShowDialog();
        }

        private void ShowPhoto()
        {
            string sqlcmd = string.Format("select Photo from Students where Sno = '{0}'",UserInfo.User.UserName);
            byte[] photo = DBModel.SelectCommand.getBytesValue(sqlcmd);
            if (photo == null)
            {
                this.MypictureBox.Image = global::ClassManagementSystem.Properties.Resources.png_0656;
                return;
            }
            MemoryStream ms = new MemoryStream(photo);
            Bitmap bmap = new Bitmap(ms);
            this.MypictureBox.Image = bmap;
        }

        private void ModifyPhoto_Click(object sender, EventArgs e)
        {
            string ppath = this.GetPhotoPath();
            if (ppath == null)
                return;
            string photoname = Path.GetFileName(ppath);
            FileStream stream = new FileStream(ppath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, (int)stream.Length);
            stream.Close();
            if (DBModel.UpdateCommand.update(UserInfo.User.UserName,photoname,buffer))
            {
                MessageBox.Show("头像修改成功！");
                this.ShowPhoto();
            }
            else
                MessageBox.Show("头像修改失败！");
        }

        private string GetPhotoPath()
        {
            string fpath = null;
            if (this.PhotoopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.PhotoopenFileDialog.FileName.Length > 0)
                {
                    fpath = this.PhotoopenFileDialog.FileName;
                }
            }
            return fpath;
        }

        private void PersonalInfoLab_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            UserManage.PersonInfoUC piuc = new UserManage.PersonInfoUC(this);
            this.MainPanel.Controls.Add(piuc);
            piuc.Dock = DockStyle.Fill;
            this.MainPanel.Refresh();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abx = new AboutBox();
            abx.Show();
        }

        private void UsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process pro = new Process();
                pro.StartInfo.FileName = @"班级信息管理系统用户操作说明书.pdf";
                pro.Start();
            }
            catch { }
        }
    }
}
