using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassManagementSystem.StuOverallEvaManage
{
    public partial class StuOverallEva : UserControl
    {
        private DataTable searchTable = null;
        private event MyDelegate MyDG;

        public StuOverallEva(mainForm mf)
        {
            InitializeComponent();
            this.MyDG += mf.SetPanel;
            this.InitControl();
            this.SearchAll();

        }

        //查询
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string sno = this.SnoTBox.Text.Trim();
            string pscore = this.PscoreTBox.Text.Trim();
            string mscore = this.MSoreTBox.Text.Trim();
            this.SearchByNo(sno);
        }

        //录入
        private void InsertSOEBtn_Click(object sender, EventArgs e)
        {
            if (this.IsInputLegal())
            {
                string sno = this.SnoTBox.Text.Trim();
                string pscore = this.PscoreTBox.Text.Trim();
                string mscore = this.MSoreTBox.Text.Trim();
                if (!this.IsNumber(pscore))
                {
                    MessageBox.Show("专业成绩输入数字！");
                    this.PscoreTBox.Focus();
                    return;
                }
                if (!this.IsNumber(mscore))
                {
                    MessageBox.Show("德育成绩输入数字！");
                    this.MSoreTBox.Focus();
                    return;
                }
                if (!this.IsSnoExist(sno))
                {
                    MessageBox.Show("学号为" + sno + "的学生不存在！");
                    return;
                }
                this.DoInsert(sno, pscore, mscore);
            }
        }

        //撤销
        private void DrawBackBtn_Click(object sender, EventArgs e)
        {
            this.SnoTBox.Clear();
            this.PscoreTBox.Clear();
            this.MSoreTBox.Clear();
        }

        //删除记录
        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
                return;
            if (this.StuOverallEvadataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.StuOverallEvadataGridView.SelectedRows.Count; i++)
                {
                    string sno = this.StuOverallEvadataGridView.SelectedRows[i].Cells["学号"].Value.ToString();
                    if (!this.DelByNO(sno))
                        MessageBox.Show("删除学号为" + sno + "的学生的学年综合评测记录时出错！");
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


        private void DoModify()
        {
            if (this.StuOverallEvadataGridView.SelectedRows.Count > 0)
            {
                string sno = this.StuOverallEvadataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
                string pscore = this.StuOverallEvadataGridView.SelectedRows[0].Cells["专业成绩"].Value.ToString();
                string mscore = this.StuOverallEvadataGridView.SelectedRows[0].Cells["德育成绩"].Value.ToString();
                if (!this.IsNumber(pscore))
                {
                    MessageBox.Show("专业成绩输入数字！");
                    this.PscoreTBox.Focus();
                    return;
                }
                if (!this.IsNumber(mscore))
                {
                    MessageBox.Show("德育成绩输入数字！");
                    this.MSoreTBox.Focus();
                    return;
                }
                string sqlcmd = string.Format("update Students_Score set ProfessionalScore = '{0}',MoralScore = '{1}' where sno = '{2}'", pscore, mscore, sno);
                if (!DBModel.UpdateCommand.update(sqlcmd))
                {
                    MessageBox.Show("修改学年综合评测记录失败！");
                    return;
                }
                sqlcmd = string.Format("select count(*) from Students_Reward where Sno = '{0}'", sno);
                int count1 = DBModel.SelectCommand.getCount(sqlcmd);
                sqlcmd = string.Format("select count(*) from Students_Penalty where Sno = '{0}'", sno);
                int count2 = DBModel.SelectCommand.getCount(sqlcmd);
                sqlcmd = string.Format("select count(*) from Students_Attendance where Sno = '{0}' and ItemID = 1", sno);
                int count3 = DBModel.SelectCommand.getCount(sqlcmd);
                sqlcmd = string.Format("select count(*) from Students_Attendance where Sno = '{0}' and ItemID = 2", sno);
                int count4 = DBModel.SelectCommand.getCount(sqlcmd);
                sqlcmd = string.Format("select count(*) from Students_Attendance where Sno = '{0}' and ItemID = 3", sno);
                int count5 = DBModel.SelectCommand.getCount(sqlcmd);
                double rpscore = count1 - count2;
                double atscore = 10 - count3 - count4 - count5;

                double sum = double.Parse(pscore) / 100 + double.Parse(mscore) / 100 + rpscore / 10 + atscore / 10;
                sqlcmd = string.Format("update Students_Overall set OverallScore = '{0}' where sno = '{1}'", sum, sno);
                if (!DBModel.UpdateCommand.update(sqlcmd))
                {
                    MessageBox.Show("修改学年综合评测记录失败！");
                    return;
                }
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        private bool DelByNO(string sno)
        {
            string sqlcmd = string.Format("delete from Students_Score where Sno = '{0}'", sno);
            bool d1 = DBModel.DeleteCommand.delete(sqlcmd);
            sqlcmd = string.Format("delete from Students_RPA where Sno = '{0}'", sno);
            bool d2 = DBModel.DeleteCommand.delete(sqlcmd);
            sqlcmd = string.Format("delete from Students_Overall where Sno = '{0}'", sno);
            bool d3 = DBModel.DeleteCommand.delete(sqlcmd);
            return d1 && d2 && d3;
        }




        private void DoInsert(string sno, string pscore, string mscore)
        {
            string sqlcmd = string.Format("insert into Students_Score(Sno,ProfessionalScore,MoralScore) values('{0}',{1},'{2}')", sno, pscore, mscore);
            if (!DBModel.InsertCommand.insert(sqlcmd))
            {
                MessageBox.Show("学年综合评测记录录入失败！");
                return;
            }

            sqlcmd = string.Format("select count(*) from Students_Reward where Sno = '{0}'", sno);
            int count1 = DBModel.SelectCommand.getCount(sqlcmd);
            sqlcmd = string.Format("select count(*) from Students_Penalty where Sno = '{0}'", sno);
            int count2 = DBModel.SelectCommand.getCount(sqlcmd);
            sqlcmd = string.Format("select count(*) from Students_Attendance where Sno = '{0}' and ItemID = 1", sno);
            int count3 = DBModel.SelectCommand.getCount(sqlcmd);
            sqlcmd = string.Format("select count(*) from Students_Attendance where Sno = '{0}' and ItemID = 2", sno);
            int count4 = DBModel.SelectCommand.getCount(sqlcmd);
            sqlcmd = string.Format("select count(*) from Students_Attendance where Sno = '{0}' and ItemID = 3", sno);
            int count5 = DBModel.SelectCommand.getCount(sqlcmd);
            double rpscore = count1 - count2;
            double atscore = 10 - count3 - count4 - count5;
            sqlcmd = string.Format("insert into Students_RPA(Sno,RPScore,AttendanceScore) values('{0}','{1}','{2}')", sno, rpscore, atscore);
            if (!DBModel.InsertCommand.insert(sqlcmd))
            {
                MessageBox.Show("学年综合评测记录录入失败！");
                return;
            }

            double sum = double.Parse(pscore) / 100 + double.Parse(mscore) / 100 + rpscore / 10 + atscore / 10;
            sqlcmd = string.Format("insert into Students_Overall(Sno,OverallScore) values('{0}','{1}')", sno, sum);
            if (!DBModel.InsertCommand.insert(sqlcmd))
            {
                MessageBox.Show("学年综合评测记录录入失败！");
                return;
            }
            MessageBox.Show("学年综合评测记录录入成功！");

            this.SearchAll();
        }



        private void SearchAll()
        {
            string sqlcmd = "select SS.Sno as 学号,S.Sname as 姓名,SS.ProfessionalScore as 专业成绩,SS.MoralScore as 德育成绩,SR.RPScore as 奖惩得分,SR.AttendanceScore as 考勤得分,SO.OverallScore as 综合评测得分 from Students_Score SS,Students_RPA SR,Students_Overall SO,Students S where SS.Sno = SR.Sno and SS.Sno = SO.Sno and SR.Sno = SO.Sno and SS.Sno = S.Sno";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.StuOverallEvadataGridView.DataSource = this.searchTable;
        }

        private void SearchByNo(string sno)
        {
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为" + sno + "的学生不存在！");
                return;
            }
            string sqlcmd = string.Format("select SS.Sno as 学号,S.Sname as 姓名,SS.ProfessionalScore as 专业成绩,SS.MoralScore as 德育成绩,SR.RPScore as 奖惩得分,SR.AttendanceScore as 考勤得分,SO.OverallScore as 综合评测得分 from Students_Score SS,Students_RPA SR,Students_Overall SO,Students S where SS.Sno = SR.Sno and SS.Sno = SO.Sno and SR.Sno = SO.Sno and SS.Sno = S.Sno and  SS.sno = '{0}' ", sno);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：学号为" + sno + "的学生的学年综合评测记录！");
                return;
            }
            this.StuOverallEvadataGridView.DataSource = this.searchTable;
        }

        private bool IsSnoExist(string sno)
        {
            string sqlcmd = string.Format("select count(*) from Students where Sno = '{0}'", sno);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

    

        private bool IsInputLegal()
        {
            if (this.SnoTBox.Text.Trim() == "")
            {
                MessageBox.Show("学号不能为空，请输入！");
                return false;
            }
            if (this.PscoreTBox.Text.Trim() == "")
            {
                MessageBox.Show("专业成绩不能为空，请输入！");
                return false;
            }
            if (this.MSoreTBox.Text.Trim() == "")
            {
                MessageBox.Show("德育成绩不能为空，请输入！");
                return false;
            }
            return true;
        }
        //设置学号和姓名不可修改
        private void StuOverallEvadataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            if (this.StuOverallEvadataGridView.CurrentCell.ColumnIndex == 0 || this.StuOverallEvadataGridView.CurrentCell.ColumnIndex == 1 || this.StuOverallEvadataGridView.CurrentCell.ColumnIndex == 4 || this.StuOverallEvadataGridView.CurrentCell.ColumnIndex == 5 || this.StuOverallEvadataGridView.CurrentCell.ColumnIndex == 6)
                this.StuOverallEvadataGridView.CurrentCell.ReadOnly = true;
            else
                this.StuOverallEvadataGridView.CurrentCell.ReadOnly = false;
        
        }

        private bool IsNumber(string str)
        {
            try
            {
                double d = double.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
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
                this.InsertSOEBtn.Enabled = true;
                this.DelBtn.Enabled = true;
                this.ModifyBtn.Enabled = true;
            }
        }
    }
}
