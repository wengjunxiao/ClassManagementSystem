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
    public partial class RewardUC : UserControl
    {
        private DataTable searchTable = null;
        private string appendixPath = "";
        private event MyDelegate MyDG;

        public RewardUC(mainForm mf)
        {
            InitializeComponent();
            this.MyDG += mf.SetPanel;
            this.AppendixNameLab.Text = "";
            this.InitControl();
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

        private void OpenAppendixBtn_Click(object sender, EventArgs e)
        {
            string sno = this.RewarddataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
            string sqlcmd1 = string.Format("select AppendixName from Students_Reward where Sno = '{0}'", sno);
            string fname = DBModel.SelectCommand.getValue(sqlcmd1);
            if (fname == "")
            {
                MessageBox.Show("该学生无奖励附件，无法查看！");
                return;
            }
            string sqlcmd2 = string.Format("select RewardAppendix from Students_Reward where Sno = '{0}'", sno);
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
            DialogResult DR = MessageBox.Show("您真的要修改这条学生奖励信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            if (this.RewarddataGridView.SelectedRows.Count > 0)
            {
                string sno = this.RewarddataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
                string ppath = this.GetAppendixPath();
                if (ppath == null)
                    return;
                FileStream stream = new FileStream(ppath, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int)stream.Length);
                stream.Close();
                if (!DBModel.UpdateCommand.updateApx(sno, Path.GetFileName(ppath), buffer))
                {
                    MessageBox.Show("上传学号为“" + sno + "”的学生的获奖附件时出错！");
                }
                else
                {
                    MessageBox.Show("上传新附件成功！");
                    this.SearchAll();
                }
            }
        }

        private void DoSearch()
        {
            string sno = this.SnoTBox.Text.Trim();
            string reward = this.RewardComboBox.Text;
            if (sno == "" && reward == "")
                this.SearchAll();
            else if (sno != "" && reward == "")
                this.SearchBySno(sno);
            else if (sno == "" && reward != "")
                this.SearchByReward(reward);
            else
                this.SearchBySno_Reward(sno,reward);
        }

        private void DoDelete()
        {
            if (this.RewarddataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.RewarddataGridView.SelectedRows.Count; i++)
                {
                    string sno = this.RewarddataGridView.SelectedRows[i].Cells["学号"].Value.ToString();
                    if (!this.DelBySno(sno))
                    {
                        MessageBox.Show("删除学号为“" + sno + "”的学生奖励信息时出错，未能成功删除该记录！");
                        continue;
                    }
                }
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何信息！");
        }

        private void DoInsert()
        {
            if (this.IsInputLegal())
            {
                string sno = this.SnoTBox.Text.Trim();
                string reward = this.RewardComboBox.Text.Trim();
                DateTime rewardtime = Convert.ToDateTime(this.RewarddateTime.Text);
                if (!this.IsSnoExist(sno))
                {
                    MessageBox.Show("学号为:" + sno + "的学生不存在！");
                    return;
                }
                if (!this.IsRewardExist(reward))
                {
                    if (!this.AddReward(reward))
                    {
                        MessageBox.Show("添加新奖项时出错！");
                        return;
                    }
                }
                string rewardid = this.GetRewardID(reward);
                if (rewardid == null)
                {
                    MessageBox.Show("奖项：" + reward + "不存在！");
                    return;
                }
                if (this.AppendixNameLab.Text == string.Empty)
                {
                    string sqlcmd = string.Format(@"insert into Students_Reward(Sno,ItemID,RewardDate) 
                                values('{0}',{1},'{2}')", sno, int.Parse(rewardid), rewardtime);
                    if (DBModel.InsertCommand.insert(sqlcmd))
                    {
                        MessageBox.Show("学生奖励信息录入成功！");
                        this.SearchAll();
                    }
                    else
                        MessageBox.Show("学生奖励信息录入失败！");
                }
                else
                {
                    FileStream stream = new FileStream(this.appendixPath, FileMode.Open, FileAccess.Read);
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);
                    stream.Close();
                    if (DBModel.InsertCommand.insert(sno, int.Parse(rewardid), rewardtime, this.AppendixNameLab.Text, buffer))
                    {
                        MessageBox.Show("学生奖励信息录入成功！");
                        this.SearchAll();
                        this.AppendixNameLab.Text = "";
                    }
                    else
                        MessageBox.Show("学生奖励信息录入失败！");
                }
                if (!this.RewardComboBox.Items.Contains(reward))
                    this.RewardComboBox.Items.Add(reward);
            }
        }

        private void DoModify()
        {
            if (this.RewarddataGridView.SelectedRows.Count > 0)
            {
                string sno = this.RewarddataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
                string reward = this.RewarddataGridView.SelectedRows[0].Cells["奖项"].Value.ToString();
                string timeStr = this.RewarddataGridView.SelectedRows[0].Cells["获奖日期"].Value.ToString();
                if (timeStr == "")
                {
                    MessageBox.Show("请输入获奖日期！");
                    return;
                }
                DateTime rwdtime = Convert.ToDateTime(timeStr);
                if (!this.IsRewardExist(reward))
                {
                    if (!this.AddReward(reward))
                    {
                        MessageBox.Show("添加新奖项时出错！");
                        return;
                    }
                }
                string rwdid = this.GetRewardID(reward);
                if (rwdid == null)
                {
                    MessageBox.Show("奖项：" + reward + "不存在！");
                    return;
                }
                string sqlcmd = string.Format("update Students_Reward set ItemID = {0},RewardDate = '{1}' where sno = '{2}'", int.Parse(rwdid), rwdtime, sno);
                if (!DBModel.UpdateCommand.update(sqlcmd))
                    MessageBox.Show("修改奖励信息失败！");
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }
        
        private void SearchAll()
        {
            string sqlcmd = @"select S.Sno as 学号,S.Sname 姓名,R.ItemName as 奖项,
                        SR.RewardDate 获奖日期,SR.AppendixName as 附件 from Students S,Students_Reward SR,RewardItem R 
                        where S.Sno = SR.Sno and SR.ItemID = R.ItemID";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.RewarddataGridView.DataSource = this.searchTable;
        }

        private void SearchBySno(string sno)
        {
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为：" + sno + "的学生不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname 姓名,R.ItemName as 奖项,
                        SR.RewardDate 获奖日期,SR.AppendixName as 附件 from Students S,Students_Reward SR,RewardItem R 
                        where S.Sno = SR.Sno and SR.ItemID = R.ItemID and S.Sno = '{0}'", sno);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("查询不到学号为：" + sno + "的学生的奖励信息！");
            else
                this.RewarddataGridView.DataSource = this.searchTable;
        }

        private void SearchByReward(string reward)
        {
            if (!this.IsRewardExist(reward))
            {
                MessageBox.Show("奖项：" + reward + "不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname 姓名,R.ItemName as 奖项,
                        SR.RewardDate 获奖日期,SR.AppendixName as 附件 from Students S,Students_Reward SR,RewardItem R 
                        where S.Sno = SR.Sno and SR.ItemID = R.ItemID and R.ItemName = '{0}'", reward);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("查询不到奖项为：" + reward + "的学生奖励信息！");
            else
                this.RewarddataGridView.DataSource = this.searchTable;
        }

        private void SearchBySno_Reward(string sno,string reward)
        {
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为：" + sno + "的学生不存在！");
                return;
            }
            if (!this.IsRewardExist(reward))
            {
                MessageBox.Show("奖项：" + reward + "不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname 姓名,R.ItemName as 奖项,
                        SR.RewardDate 获奖日期,SR.AppendixName as 附件 from Students S,Students_Reward SR,RewardItem R 
                        where S.Sno = SR.Sno and SR.ItemID = R.ItemID and S.Sno = '{0}' and R.ItemName = '{1}'", sno,reward);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("查询不到学号为：" + sno + "奖项为：" + reward + "的学生奖励信息！");
            else
                this.RewarddataGridView.DataSource = this.searchTable;
        }

        private bool DelBySno(string sno)
        {
            string sqlcmd = string.Format("delete from Students_Reward where Sno = '{0}'", sno);
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

        private bool IsRewardExist(string reward)
        {
            string sqlcmd = string.Format("select count(*) from RewardItem where ItemName = '{0}'", reward);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
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

        private bool IsInputLegal()
        {
            if (this.SnoTBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("学号不能为空，请输入学号！");
                this.SnoTBox.Focus();
                return false;
            }
            if (this.RewardComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("姓名不能为空，请输入姓名！");
                this.RewardComboBox.Focus();
                return false;
            }
            return true;
        }

        private bool AddReward(string reward)
        {
            string sqlcmd = string.Format("insert into RewardItem(ItemName) values('{0}')", reward);
            return DBModel.InsertCommand.insert(sqlcmd);
        }

        private string GetRewardID(string reward)
        {
            string sqlcmd = string.Format("select ItemID from RewardItem where ItemName = '{0}'", reward);
            return DBModel.SelectCommand.getValue(sqlcmd);
        }

        //设置学号、姓名、附件名不可修改
        private void RewarddataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.RewarddataGridView.ColumnCount;
            if (this.RewarddataGridView.CurrentCell.ColumnIndex == 0 || this.RewarddataGridView.CurrentCell.ColumnIndex == 1 || this.RewarddataGridView.CurrentCell.ColumnIndex == count - 1)
                this.RewarddataGridView.CurrentCell.ReadOnly = true;
            else
                this.RewarddataGridView.CurrentCell.ReadOnly = false;
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

        private void tabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            for (int i = 0; i < this.tabControl.TabCount; i++)
            {
                Rectangle recTab = tabControl.GetTabRect(i);
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
