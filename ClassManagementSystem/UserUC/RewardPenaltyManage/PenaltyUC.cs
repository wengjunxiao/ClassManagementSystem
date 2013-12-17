using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClassManagementSystem.RewardPenaltyManage
{
    public partial class PenaltyUC : UserControl
    {
        private DataTable searchTable = null;
        private string appendixPath = "";
        private event MyDelegate MyDG;

        public PenaltyUC(mainForm mf)
        {
            InitializeComponent();
            this.MyDG += mf.SetPanel;
            this.InitControl();
            this.AppendixNameLab.Text = "";
            this.SearchAll();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.DoSearch();
        }

        private void InserBtn_Click(object sender, EventArgs e)
        {
            this.DoInsert();
        }

        private void DrawbackBtn_Click(object sender, EventArgs e)
        {
            this.SnoTBox.Clear();
            this.AppendixNameLab.Text = "";
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            if (this.PenaltydataGridView.SelectedRows.Count > 0)
            {
                string sno = this.PenaltydataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
                string ppath = this.GetAppendixPath();
                if (ppath == null)
                    return;
                FileStream stream = new FileStream(ppath, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int)stream.Length);
                stream.Close();
                if (!DBModel.UpdateCommand.updateApxPenalty(sno, Path.GetFileName(ppath), buffer))
                {
                    MessageBox.Show("上传学号为“" + sno + "”的学生的惩罚附件时出错！");
                }
                else
                {
                    MessageBox.Show("上传新附件成功！");
                    this.SearchAll();
                }
            }
        }

        private void OpenAppendixBtn_Click(object sender, EventArgs e)
        {
            string sno = this.PenaltydataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
            string sqlcmd1 = string.Format("select AppendixName from Students_Penalty where Sno = '{0}'", sno);
            string fname = DBModel.SelectCommand.getValue(sqlcmd1);
            if (fname == "")
            {
                MessageBox.Show("该学生无惩罚附件，无法查看！");
                return;
            }
            string sqlcmd2 = string.Format("select PenaltyAppendix from Students_Penalty where Sno = '{0}'", sno);
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

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这些记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
                return;
            this.DoDelete();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要修改这条学生惩罚信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.DoModify();
            }
            else
                this.SearchAll();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.SearchAll();
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

        private void DoSearch()
        {
            string sno = this.SnoTBox.Text.Trim();
            string penalty = this.PenaltyComboBox.Text.Trim();
            if (sno == "" && penalty == "")
                this.SearchAll();
            else if (sno != "" && penalty == "")
                this.SearchBySno(sno);
            else if (sno == "" && penalty != "")
                this.SearchByReward(penalty);
            else
                this.SearchBySno_Penalty(sno, penalty);
        }

        private void DoDelete()
        {
            if (this.PenaltydataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.PenaltydataGridView.SelectedRows.Count; i++)
                {
                    string sno = this.PenaltydataGridView.SelectedRows[i].Cells["学号"].Value.ToString();
                    if (!this.DelBySno(sno))
                    {
                        MessageBox.Show("删除学号为“" + sno + "”的学生惩罚信息时出错，未能成功删除该记录！");
                        continue;
                    }
                }
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何信息！");
        }

        private void DoModify()
        {
            if (this.PenaltydataGridView.SelectedRows.Count > 0)
            {
                string sno = this.PenaltydataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
                string penalty = this.PenaltydataGridView.SelectedRows[0].Cells["惩罚内容"].Value.ToString();
                string timeStr = this.PenaltydataGridView.SelectedRows[0].Cells["惩罚日期"].Value.ToString();
                if (timeStr == "")
                {
                    MessageBox.Show("请输入惩罚日期！");
                    return;
                }
                DateTime ptytime = Convert.ToDateTime(timeStr);
                if (!this.IsPenaltyExist(penalty))
                {
                    if (!this.AddPenalty(penalty))
                    {
                        MessageBox.Show("添加新惩罚内容时出错！");
                        return;
                    }
                }
                string ptyid = this.GetPenaltyID(penalty);
                if (ptyid == null)
                {
                    MessageBox.Show("惩罚内容：" + penalty + "不存在！");
                    return;
                }
                string sqlcmd = string.Format("update Students_Penalty set ItemID = {0},PenaltyDate = '{1}' where sno = '{2}'", int.Parse(ptyid), ptytime, sno);
                if (!DBModel.UpdateCommand.update(sqlcmd))
                    MessageBox.Show("修改惩罚信息失败！");
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        private void DoInsert()
        {
            if (this.IsInputLegal())
            {
                string sno = this.SnoTBox.Text.Trim();
                string penalty = this.PenaltyComboBox.Text.Trim();
                DateTime penaltytime = Convert.ToDateTime(this.PenaltydateTime.Text);
                if (!this.IsSnoExist(sno))
                {
                    MessageBox.Show("学号为:" + sno + "的学生不存在！");
                    return;
                }
                if (!this.IsPenaltyExist(penalty))
                {
                    if (!this.AddPenalty(penalty))
                    {
                        MessageBox.Show("添加新惩罚内容时出错！");
                        return;
                    }
                }
                string ptyid = this.GetPenaltyID(penalty);
                if (ptyid == null)
                {
                    MessageBox.Show("惩罚内容：" + penalty + "不存在！");
                    return;
                }
                if (this.AppendixNameLab.Text == string.Empty)
                {
                    string sqlcmd = string.Format(@"insert into Students_Penalty(Sno,ItemID,PenaltyDate) 
                                values('{0}',{1},'{2}')", sno, int.Parse(ptyid), penaltytime);
                    if (DBModel.InsertCommand.insert(sqlcmd))
                    {
                        MessageBox.Show("学生惩罚信息录入成功！");
                        this.SearchAll();
                    }
                    else
                        MessageBox.Show("学生惩罚信息录入失败！");
                }
                else
                {
                    FileStream stream = new FileStream(this.appendixPath, FileMode.Open, FileAccess.Read);
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);
                    stream.Close();
                    if (DBModel.InsertCommand.insertPenalty(sno, int.Parse(ptyid), penaltytime, this.AppendixNameLab.Text, buffer))
                    {
                        MessageBox.Show("学生惩罚信息录入成功！");
                        this.SearchAll();
                        this.AppendixNameLab.Text = "";
                    }
                    else
                        MessageBox.Show("学生惩罚信息录入失败！");
                }
                if (!this.PenaltyComboBox.Items.Contains(penalty))
                    this.PenaltyComboBox.Items.Add(penalty);
            }
        }

        private void SearchAll()
        {
            string sqlcmd = @"select S.Sno as 学号,S.Sname as 姓名,P.ItemName as 惩罚内容,
                        SP.PenaltyDate as 惩罚日期,SP.AppendixName as 附件 from Students S,Students_Penalty SP,PenaltyItem P 
                        where S.Sno = SP.Sno and SP.ItemID = P.ItemID";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.PenaltydataGridView.DataSource = this.searchTable;
        }

        private void SearchBySno(string sno)
        {
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为：" + sno + "的学生不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname 姓名,P.ItemName as 惩罚内容,
                        SP.PenaltyDate 惩罚日期,SP.AppendixName as 附件 from Students S,Students_Penalty SP,PenaltyItem P 
                        where S.Sno = SP.Sno and SP.ItemID = P.ItemID and S.Sno = '{0}'", sno);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("查询不到学号为：" + sno + "的学生的惩罚信息！");
            else
                this.PenaltydataGridView.DataSource = this.searchTable;
        }

        private void SearchByReward(string penalty)
        {
            if (!this.IsPenaltyExist(penalty))
            {
                MessageBox.Show("惩罚内容：" + penalty + "不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname 姓名,P.ItemName as 惩罚内容,
                        SP.PenaltyDate 惩罚日期,SP.AppendixName as 附件 from Students S,Students_Penalty SP,PenaltyItem P 
                        where S.Sno = SP.Sno and SP.ItemID = P.ItemID and P.ItemName = '{0}'", penalty);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("查询不到惩罚为：" + penalty + "的学生惩罚信息！");
            else
                this.PenaltydataGridView.DataSource = this.searchTable;
        }

        private void SearchBySno_Penalty(string sno, string penalty)
        {
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为：" + sno + "的学生不存在！");
                return;
            }
            if (!this.IsPenaltyExist(penalty))
            {
                MessageBox.Show("惩罚内容：" + penalty + "不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname 姓名,P.ItemName as 惩罚内容,
                        SP.PenaltyDate 惩罚日期,SP.AppendixName as 附件 from Students S,Students_Penalty SP,PenaltyItem P 
                        where S.Sno = SP.Sno and SP.ItemID = P.ItemID and S.Sno = '{0}' and P.ItemName = '{1}'", sno, penalty);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("查询不到学号为：" + sno + "惩罚内容为：" + penalty + "的学生惩罚信息！");
            else
                this.PenaltydataGridView.DataSource = this.searchTable;
        }

        private bool DelBySno(string sno)
        {
            string sqlcmd = string.Format("delete from Students_Penalty where Sno = '{0}'", sno);
            return DBModel.DeleteCommand.delete(sqlcmd);
        }

        private bool IsSnoExist(string sno)
        {
            string sqlcmd = string.Format("select count(*) from Students where Sno = '{0}'", sno);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

        private bool IsPenaltyExist(string penalty)
        {
            string sqlcmd = string.Format("select count(*) from PenaltyItem where ItemName = '{0}'", penalty);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

        private bool IsInputLegal()
        {
            if (this.SnoTBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("学号不能为空，请输入学号！");
                this.SnoTBox.Focus();
                return false;
            }
            if (this.PenaltyComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("姓名不能为空，请输入姓名！");
                this.PenaltyComboBox.Focus();
                return false;
            }
            return true;
        }

        private bool AddPenalty(string penalty)
        {
            string sqlcmd = string.Format("insert into PenaltyItem(ItemName) values('{0}')", penalty);
            return DBModel.InsertCommand.insert(sqlcmd);
        }

        private string GetPenaltyID(string penalty)
        {
            string sqlcmd = string.Format("select ItemID from PenaltyItem where ItemName = '{0}'", penalty);
            return DBModel.SelectCommand.getValue(sqlcmd);
        }

        private void PenaltydataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.PenaltydataGridView.ColumnCount;
            if (this.PenaltydataGridView.CurrentCell.ColumnIndex == 0 || this.PenaltydataGridView.CurrentCell.ColumnIndex == 1 || this.PenaltydataGridView.CurrentCell.ColumnIndex == count - 1)
                this.PenaltydataGridView.CurrentCell.ReadOnly = true;
            else
                this.PenaltydataGridView.CurrentCell.ReadOnly = false;
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
                this.InserBtn.Enabled = true;
                this.UploadBtn.Enabled = true;
                this.DelBtn.Enabled = true;
                this.ModifyBtn.Enabled = true;
            }
        }
    }
}
