using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClassManagementSystem.StudentInfoManage
{
    public partial class InsertSInfoUC : UserControl
    {
        private DataTable searchTable = null;
        private string photoPath = "";

        public InsertSInfoUC()
        {
            InitializeComponent();
            this.PhotoNameLab.Text = string.Empty;
            this.SearchAll();
        }

        //学生录入
        private void InsertStuBtn_Click(object sender, EventArgs e)
        {
            this.DoInsert();
        }

        private void SearchAll()
        {
            string sqlcmd = "select Sno as 学号,Sname as 姓名,Sex as 性别,BirthDate as 出生日期,Class as 班级,Specialty as 专业,PhotoName as 照片名 from Students";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.StudDataGridView.DataSource = this.searchTable;
        }

        private void DoInsert()
        {
            if (this.IsInputLegal())
            {
                string sno = this.SnoTBox.Text.Trim();
                string sname = this.SnameTBox.Text.Trim();
                string sex = this.SexComboBox.Text.Trim();
                string cals = this.ClassTBox.Text.Trim();
                string specialty = this.SpecialtyTBox.Text.Trim();
                DateTime birthdate = Convert.ToDateTime(this.BirthdateTime.Text);
                if (this.PhotoNameLab.Text == string.Empty)
                {
                    string sqlcmd1 = string.Format("insert into Students(Sno,Sname,Sex,BirthDate,Class,Specialty) values('{0}','{1}','{2}','{3}','{4}','{5}')"
                        , sno, sname, sex, birthdate, cals, specialty);
                    if (DBModel.InsertCommand.insert(sqlcmd1))
                    {
                        MessageBox.Show("学生信息录入成功！");
                        this.SearchAll();
                    }
                    else
                        MessageBox.Show("学生信息录入失败！");
                }
                else
                {
                    FileStream stream = new FileStream(this.photoPath, FileMode.Open, FileAccess.Read);
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);
                    stream.Close();
                    if (DBModel.InsertCommand.insert(sno, sname, sex, birthdate, cals, specialty, this.PhotoNameLab.Text, buffer))
                    {
                        MessageBox.Show("学生信息录入成功！");
                        this.SearchAll();
                        this.PhotoNameLab.Text = "";
                    }
                    else
                        MessageBox.Show("学生信息录入失败！");
                }
            }
        }

        private bool IsInputLegal()
        {
            if (this.SnoTBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("学号不能为空，请输入学号！");
                this.SnoTBox.Focus();
                return false;
            }
            if (this.SnameTBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("姓名不能为空，请输入姓名！");
                this.SnameTBox.Focus();
                return false;
            }
            return true;
        }

        private void AttachLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.PhotoopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.PhotoopenFileDialog.FileName.Length > 0)
                {
                    this.PhotoNameLab.Text = Path.GetFileName(this.PhotoopenFileDialog.FileName);
                    this.photoPath = this.PhotoopenFileDialog.FileName;
                }
            }
        }

        private void SnoTBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.DoInsert();
            }
        }

        private void SnameTBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.DoInsert();
            }
        }

        private void SexComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.DoInsert();
            }
        }

        private void ClassTBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.DoInsert();
            }
        }

        private void SpecialtyTBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.DoInsert();
            }
        }

        private void BirthdateTime_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.DoInsert();
            }
        }

        private void DrawbackBtn_Click(object sender, EventArgs e)
        {
            this.SnoTBox.Clear();
            this.SnameTBox.Clear();
            this.ClassTBox.Clear();
            this.SpecialtyTBox.Clear();
            this.PhotoNameLab.Text = "";
        }
    }
}
