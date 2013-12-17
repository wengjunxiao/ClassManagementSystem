using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClassManagementSystem.ClassActivityManage
{
    public partial class ClassActivityUC : UserControl
    {
        private DataTable searchTable = null;
        private string appendixPath = "";
        private event MyDelegate MyDG;

        public ClassActivityUC(mainForm mf)
        {
            InitializeComponent();
            this.MyDG += mf.SetPanel;
            this.InitControl();
            this.AppendixNameLab.Text = "";
            this.SearchAll();
        }

        //查询
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string acname = this.ActivityNameTBox.Text.Trim();
            DateTime actime = Convert.ToDateTime(this.ActdateTime.Text);
            if (acname == "")
                this.SearchByDate(actime);
            else
                this.SearchByName(acname);
        }

        //录入
        private void InsertCaBtn_Click(object sender, EventArgs e)
        {
            this.DoInsert();
        }

        //撤销
        private void DrawBackBtn_Click(object sender, EventArgs e)
        {
            this.ActivityNameTBox.Clear();
            this.AppendixNameLab.Text = "";
        }

        //删除记录
        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
                return;
            if (this.ClassActivitydataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.ClassActivitydataGridView.SelectedRows.Count; i++)
                {
                    string planid = this.ClassActivitydataGridView.SelectedRows[i].Cells["活动编号"].Value.ToString();
                    if (!this.DelByID(planid))
                        MessageBox.Show("删除活动编号为" + planid + "的班级活动信息时出错！");
                }
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        //保存修改
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要修改这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
            {
                this.SearchAll();
                return;
            }
            this.DoModify();
        }

        //刷新表格
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.SearchAll();
        }

        private void DoInsert()
        {
            if (this.IsInputLegal())
            {
                string acname = this.ActivityNameTBox.Text.Trim();
                DateTime actime = Convert.ToDateTime(this.ActdateTime.Text);
                if (this.AppendixNameLab.Text == "")
                {
                    string sqlcmd = string.Format("insert into ClassActivity(ActivityName,ActivityDate) values('{0}','{1}')", acname,actime);
                    if (!DBModel.InsertCommand.insert(sqlcmd))
                    {
                        MessageBox.Show("班委活动录入失败！");
                        return;
                    }
                    MessageBox.Show("班委活动录入成功！");
                }
                else
                {
                    FileStream stream = new FileStream(this.appendixPath, FileMode.Open, FileAccess.Read);
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);
                    stream.Close();
                    if (!DBModel.InsertCommand.insert(acname,actime, this.AppendixNameLab.Text, buffer))
                    {
                        MessageBox.Show("班委活动录入失败！");
                        return;
                    }
                    MessageBox.Show("班委活动录入成功！");
                    this.AppendixNameLab.Text = "";
                }
                this.SearchAll();
            }
        }

        private void DoModify()
        {
            if (this.ClassActivitydataGridView.SelectedRows.Count > 0)
            {
                string acname = this.ClassActivitydataGridView.SelectedRows[0].Cells["活动名称"].Value.ToString();
                string acid = this.ClassActivitydataGridView.SelectedRows[0].Cells["活动编号"].Value.ToString();
                string timeStr = this.ClassActivitydataGridView.SelectedRows[0].Cells["活动日期"].Value.ToString();
                if (timeStr == "")
                {
                    MessageBox.Show("请输入活动日期！");
                    return;
                }
                DateTime actime = Convert.ToDateTime(timeStr);
                string sqlcmd = string.Format("update ClassActivity set ActivityName = '{0}',ActivityDate = '{1}' where ActivityID = '{2}'", acname, actime,int.Parse(acid));
                if (!DBModel.UpdateCommand.update(sqlcmd))
                    MessageBox.Show("修改班级活动信息失败！");
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        private bool DelByID(string acid)
        {
            string sqlcmd = string.Format("delete from ClassActivity where ActivityID = '{0}'", acid);
            return DBModel.DeleteCommand.delete(sqlcmd);
        }

        private void SearchAll()
        {
            string sqlcmd = "select ActivityID as 活动编号, ActivityName as 活动名称, ActivityDate as 活动日期,AppendixName as 附件 from ClassActivity";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.ClassActivitydataGridView.DataSource = this.searchTable;
        }

        private void SearchByDate(DateTime time)
        {
            string sqlcmd = string.Format("select ActivityID as 活动编号,ActivityName as 活动名称,ActivityDate as 活动日期,AppendixName as 附件 from ClassActivity where ActivityDate = '{0}'", time);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：" + time.Year + "年" + time.Month + "月" + time.Day + "日”的活动记录！");
                return;
            }
            this.ClassActivitydataGridView.DataSource = this.searchTable;
        }

        private void SearchByName(string acname)
        {
            string sqlcmd = string.Format("select ActivityID as 活动编号,ActivityName as 活动名称, ActivityDate as 活动日期,AppendixName as 附件 from ClassActivity where ActivityName = '{0}'", acname);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：活动名称为" + acname + "的活动记录！");
                return;
            }
            this.ClassActivitydataGridView.DataSource = this.searchTable;
        }

        private bool IsInputLegal()
        {
            if (this.ActivityNameTBox.Text.Trim() == "")
            {
                MessageBox.Show("活动名称不能为空，请输入！");
                return false;
            }
            return true;
        }

        //设置活动编号不可修改
        private void ClassActivitydataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.ClassActivitydataGridView.ColumnCount;
            if (this.ClassActivitydataGridView.CurrentCell.ColumnIndex == 0 || this.ClassActivitydataGridView.CurrentCell.ColumnIndex == count - 1)
                this.ClassActivitydataGridView.CurrentCell.ReadOnly = true;
            else
                this.ClassActivitydataGridView.CurrentCell.ReadOnly = false;
        }

        private void AttachLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.AppendixopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.AppendixopenFileDialog.FileName.Length > 0)
                {
                    this.AppendixNameLab.Text = Path.GetFileName(this.AppendixopenFileDialog.FileName);
                    this.appendixPath = this.AppendixopenFileDialog.FileName;
                }
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            string acid = this.ClassActivitydataGridView.SelectedRows[0].Cells["活动编号"].Value.ToString();
            string sqlcmd1 = string.Format("select AppendixName from ClassActivity where ActivityID = {0}", int.Parse(acid));
            string fname = DBModel.SelectCommand.getValue(sqlcmd1);
            if (fname == "")
            {
                MessageBox.Show("无活动附件！");
                return;
            }
            string sqlcmd2 = string.Format("select Appendix from ClassActivity where ActivityID = {0}", int.Parse(acid));
            byte[] bts = DBModel.SelectCommand.getBytesValue(sqlcmd2);
            string tempFName = Temp.TmpFileName;
            string exstr = "\\" + tempFName + fname.Substring(fname.LastIndexOf('.'));
            FileStream fs = new FileStream(exstr, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(bts, 0, bts.Length);
            bw.Close();
            fs.Close();
            System.Diagnostics.Process.Start(exstr);
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            if (this.ClassActivitydataGridView.SelectedRows.Count > 0)
            {
                string acid = this.ClassActivitydataGridView.SelectedRows[0].Cells["活动编号"].Value.ToString();
                string ppath = this.GetAppendixPath();
                if (ppath == null)
                    return;
                FileStream stream = new FileStream(ppath, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int)stream.Length);
                stream.Close();
                if (!DBModel.UpdateCommand.updateActiAppendix(int.Parse(acid), Path.GetFileName(ppath), buffer))
                {
                    MessageBox.Show("上传班级活动附件时出错！");
                }
                else
                {
                    MessageBox.Show("上传新班级活动附件成功！");
                    this.SearchAll();
                }
            }
        }

        private string GetAppendixPath()
        {
            string fpath = null;
            if (this.AppendixopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.AppendixopenFileDialog.FileName.Length > 0)
                {
                    fpath = this.AppendixopenFileDialog.FileName;
                }
            }
            return fpath;
        }

           

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            Point pt = new Point(e.X, e.Y);
            for (int i = 0; i < this.tabControl1.TabCount; i++)
            {
                Rectangle recTab = tabControl1.GetTabRect(i);
                if (recTab.Contains(pt))
                {
                    if (this.MyDG != null)
                        this.MyDG();
                    return;
                }
            }
        }

        private void InitControl()
        {
            if (UserInfo.User.IsAdmin)
            {
                this.InsertCaBtn.Enabled = true;
                this.Upload.Enabled = true;
                this.DelBtn.Enabled = true;
                this.ModifyBtn.Enabled = true;
            }
        }
    }
}
