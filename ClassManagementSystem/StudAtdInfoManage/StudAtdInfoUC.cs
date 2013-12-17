using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassManagementSystem.StudAtdInfoManage
{
    public partial class StudAtdInfoUC : UserControl
    {
        private DataTable searchTable = null;

        public StudAtdInfoUC()
        {
            InitializeComponent();
            this.SearchAll();
        }

        //查询
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string sno = this.SnoTBox.Text.Trim();
            string item = this.AtdItemCBox.Text.Trim();
            DateTime atdtime = Convert.ToDateTime(this.AtddateTime.Text);
            if (sno == "" && item == "")
                this.SearchByDate(atdtime);
            else if (sno != "" && item == "")
                this.SearchByNo(sno);
            else if (sno == "" && item != "")
                this.SearchByItem(item);
            else
                this.SearchByNo_Item_Date(sno,item,atdtime);
        }

        //录入
        private void InsertAtdBtn_Click(object sender, EventArgs e)
        {
            if (this.IsInputLegal())
            {
                string sno = this.SnoTBox.Text.Trim();
                string item = this.AtdItemCBox.Text.Trim();
                DateTime atdtime = Convert.ToDateTime(this.AtddateTime.Text);
                if (!this.IsSnoExist(sno))
                {
                    MessageBox.Show("学号为" + sno + "的学生不存在！");
                    return;
                }
                if (!this.IsItemExist(item))
                {
                    if (!this.AddItem(item))
                    {
                        MessageBox.Show("添加新考勤项目时出错！");
                        return;
                    }
                }
                string itemid = this.GetItemID(item);
                if (itemid == null)
                {
                    MessageBox.Show("考勤项目：" + item + "不存在！");
                    return;
                }
                this.DoInsert(sno, int.Parse(itemid), atdtime);
            }
        }

        //撤销
        private void DrawBackBtn_Click(object sender, EventArgs e)
        {
            this.SnoTBox.Clear();
        }

        //删除记录
        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这条记录吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
                return;
            if (this.AttendancedataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.AttendancedataGridView.SelectedRows.Count; i++)
                {
                    string sno = this.AttendancedataGridView.SelectedRows[i].Cells["学号"].Value.ToString();
                    if (!this.DelByNO(sno))
                        MessageBox.Show("删除学号为" + sno + "的学生的考勤记录时出错！");
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
            if (this.AttendancedataGridView.SelectedRows.Count > 0)
            {
                string sno = this.AttendancedataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
                string item = this.AttendancedataGridView.SelectedRows[0].Cells["考勤项目"].Value.ToString();
                DateTime atdtime = Convert.ToDateTime(this.AttendancedataGridView.SelectedRows[0].Cells["考勤日期"].Value);
                if (!IsItemExist(item))
                {
                    if (!this.AddItem(item))
                    {
                        MessageBox.Show("添加新考勤项目时出错！");
                        return;
                    }
                }
                string itemid = this.GetItemID(item);
                if (itemid == null)
                {
                    MessageBox.Show("考勤项目：" + item + "不存在！");
                    return;
                }
                string sqlcmd = string.Format("update Students_Attendance set ItemID = {0},AttendanceDate = '{1}' where sno = '{2}'",int.Parse(itemid),atdtime,sno);
                if (!DBModel.UpdateCommand.update(sqlcmd))
                    MessageBox.Show("修改考勤记录失败！");
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        private bool DelByNO(string sno)
        {
            string sqlcmd = string.Format("delete from Students where Sno = '{0}'", sno);
            return DBModel.DeleteCommand.delete(sqlcmd);
        }

        private void DoInsert(string sno, int item_id, DateTime time)
        {
            string sqlcmd = string.Format("insert into Students_Attendance(Sno,ItemID,AttendanceDate) values('{0}',{1},'{2}')", sno,item_id, time);
            if (!DBModel.InsertCommand.insert(sqlcmd))
            {
                MessageBox.Show("考勤记录录入失败！");
                return;
            }
            MessageBox.Show("考勤记录录入成功！");
            this.SearchAll();
        }

        private void SearchAll()
        {
            string sqlcmd = "select S.Sno as 学号,S.Sname as 姓名,A.ItemName as 考勤项目,SA.AttendanceDate as 考勤日期 from Students S,Students_Attendance SA,AttendanceItem A where S.Sno = SA.Sno and SA.ItemID = A.ItemID";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.AttendancedataGridView.DataSource = this.searchTable;
        }

        private void SearchByDate(DateTime time)
        {
            string sqlcmd = string.Format("select S.Sno as 学号,S.Sname as 姓名,A.ItemName as 考勤项目,SA.AttendanceDate as 考勤日期 from Students S,Students_Attendance SA,AttendanceItem A where S.Sno = SA.Sno and SA.ItemID = A.ItemID and SA.AttendanceDate = '{0}'",time);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：" + time.Year + "年" + time.Month + "月" + time.Day + "日”的学生考勤记录！");
                return;
            }
            this.AttendancedataGridView.DataSource = this.searchTable;
        }

        private void SearchByNo(string sno)
        {
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为" + sno + "的学生不存在！");
                return;
            }
            string sqlcmd = string.Format("select S.Sno as 学号,S.Sname as 姓名,A.ItemName as 考勤项目,SA.AttendanceDate as 考勤日期 from Students S,Students_Attendance SA,AttendanceItem A where S.Sno = SA.Sno and SA.Sno = '{0}' and SA.ItemID = A.ItemID",sno);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：学号为" + sno + "的学生的考勤记录！");
                return;
            }
            this.AttendancedataGridView.DataSource = this.searchTable;
        }

        private void SearchByItem(string item)
        {
            if (!this.IsItemExist(item))
            {
                MessageBox.Show("考勤项目" + item + "不存在！");
                return;
            }
            string sqlcmd = string.Format("select S.Sno as 学号,S.Sname as 姓名,A.ItemName as 考勤项目,SA.AttendanceDate as 考勤日期 from Students S,Students_Attendance SA,AttendanceItem A where S.Sno = SA.Sno and A.ItemName = '{0}' and SA.ItemID = A.ItemID", item);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：考勤项目为" + item + "的学生考勤记录！");
                return;
            }
            this.AttendancedataGridView.DataSource = this.searchTable;
        }

        private void SearchByNo_Item_Date(string sno, string item, DateTime time)
        {
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为" + sno + "的学生不存在！");
                return;
            }
            if (!this.IsItemExist(item))
            {
                MessageBox.Show("考勤项目" + item + "不存在！");
                return;
            }
            string sqlcmd = string.Format("select S.Sno as 学号,S.Sname as 姓名,A.ItemName as 考勤项目,SA.AttendanceDate as 考勤日期 from Students S,Students_Attendance SA,AttendanceItem A where S.Sno = SA.Sno and SA.Sno = '{0}' and A.ItemName = '{1}' and SA.ItemID = A.ItemID and SA.AttendanceDate = '{2}'", sno,item,time);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：学号为" + sno + "的学生在" + time.Year + "年" + time.Month + "月" + time.Day + "日" + item + "的考勤记录！");
                return;
            }
            this.AttendancedataGridView.DataSource = this.searchTable;
        }

        private bool IsSnoExist(string sno)
        {
            string sqlcmd = string.Format("select count(*) from Students where Sno = '{0}'", sno);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

        private bool IsItemExist(string item)
        {
            string sqlcmd = string.Format("select count(*) from AttendanceItem where ItemName = '{0}'", item);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

        private bool AddItem(string item)
        {
            string sqlcmd = string.Format("insert into AttendanceItem(ItemName) values('{0}')",item);
            return DBModel.InsertCommand.insert(sqlcmd);
        }

        private string GetItemID(string item)
        {
            string sqlcmd = string.Format("select ItemID from AttendanceItem where ItemName = '{0}'", item);
            return DBModel.SelectCommand.getValue(sqlcmd);
        }

        private bool IsInputLegal()
        {
            if (this.SnoTBox.Text.Trim() == "")
            {
                MessageBox.Show("学号不能为空，请输入！");
                return false;
            }
            if (this.AtdItemCBox.Text.Trim() == "")
            {
                MessageBox.Show("考勤项目不能为空，请填入！");
                return false;
            }
            return true;
        }

        //设置学号和姓名不可修改
        private void AttendancedataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.AttendancedataGridView.CurrentCell.ColumnIndex == 0 || this.AttendancedataGridView.CurrentCell.ColumnIndex == 1)
                this.AttendancedataGridView.CurrentCell.ReadOnly = true;
            else
                this.AttendancedataGridView.CurrentCell.ReadOnly = false;
        }
    }
}
