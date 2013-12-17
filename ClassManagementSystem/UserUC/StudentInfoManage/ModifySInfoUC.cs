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
    public partial class ModifySInfoUC : UserControl
    {
        private DataTable searchTable = null;

        public ModifySInfoUC()
        {
            InitializeComponent();
            this.SearchAll();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.SearchAll();
        }

        private void SearchAll()
        {
            string sqlcmd = "select Sno as 学号,Sname as 姓名,Sex as 性别,BirthDate as 出生日期,Class as 班级,Specialty as 专业,PhotoName as 照片名 from Students";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.StuddataGridView.DataSource = this.searchTable;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这些学生信息吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.DoDelete();
            }
        }

        private void DoDelete()
        {
            if (this.StuddataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.StuddataGridView.SelectedRows.Count; i++)
                {
                    string sno = this.StuddataGridView.SelectedRows[i].Cells["学号"].Value.ToString();
                    if (!this.DeleteByNo(sno))
                    {
                        MessageBox.Show("删除学号为“" + sno + "”的学生信息时出错，未能成功删除该记录！");
                        continue;
                    }
                }
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何信息！");
        }

        private bool DeleteByNo(string sno)
        {
            string sqlcmd = string.Format("delete from Students where Sno = '{0}'",sno);
            return DBModel.DeleteCommand.delete(sqlcmd);
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要修改这些学生信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.DoModify();
            }
            else
                this.SearchAll();
        }

        private void DoModify()
        {
            if (this.StuddataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.StuddataGridView.SelectedRows.Count; i++)
                {
                    string sno = this.StuddataGridView.SelectedRows[i].Cells["学号"].Value.ToString();
                    string sname = this.StuddataGridView.SelectedRows[i].Cells["姓名"].Value.ToString();
                    string sex = this.StuddataGridView.SelectedRows[i].Cells["性别"].Value.ToString();
                    string timeStr = this.StuddataGridView.SelectedRows[i].Cells["出生日期"].Value.ToString();
                    if (timeStr == "")
                    {
                        MessageBox.Show("请输入出生日期！");
                        return;
                    }
                    DateTime birthdate = Convert.ToDateTime(timeStr);
                    string clas = this.StuddataGridView.SelectedRows[i].Cells["班级"].Value.ToString();
                    string specialty = this.StuddataGridView.SelectedRows[i].Cells["专业"].Value.ToString();
                    if (!this.ModifyByNo(sno, sname, sex, birthdate, clas, specialty))
                    {
                        MessageBox.Show("修改学号为“" + sno + "”的学生信息时出错，未能成功修改该记录！");
                        continue;
                    }
                }
                this.SearchAll();
            }
        }

        private bool ModifyByNo(string sno,string sname,string sex,DateTime birthdate,string clas,string specialty)
        {
            string sqlcmd = string.Format("update Students set Sname = '{0}',Sex = '{1}',BirthDate = '{2}',Class = '{3}',Specialty = '{4}' where Sno = '{5}'",
                sname, sex, birthdate, clas, specialty, sno);
            return DBModel.UpdateCommand.update(sqlcmd);
        }

        //将第一列和最后一列设为只读
        private void StuddataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.StuddataGridView.ColumnCount;
            if (this.StuddataGridView.CurrentCell.ColumnIndex == 0 || this.StuddataGridView.CurrentCell.ColumnIndex == count - 1)
                this.StuddataGridView.CurrentCell.ReadOnly = true;
            else
                this.StuddataGridView.CurrentCell.ReadOnly = false;
        }

        private void UploadPhotoBtn_Click(object sender, EventArgs e)
        {
            if (this.StuddataGridView.SelectedRows.Count > 0)
            {
                string sno = this.StuddataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
                string ppath = this.GetPhotoPath();
                if (ppath == null)
                    return;
                FileStream stream = new FileStream(ppath, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int)stream.Length);
                stream.Close();
                if (!DBModel.UpdateCommand.update(sno, Path.GetFileName(ppath), buffer))
                {
                    MessageBox.Show("上传学号为“" + sno + "”的学生的新照片时出错，未能成功上传照片！");
                }
                else
                {
                    MessageBox.Show("上传新照片成功！");
                    this.SearchAll();
                }
            }
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
    }
}
