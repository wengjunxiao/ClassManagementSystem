using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassManagementSystem.ClassFeeManage
{
    public partial class ClassFeeUS : UserControl
    {
        private DataTable searchTable = null;
        public event MyDelegate MyDG;

        public ClassFeeUS(mainForm mf)
        {
            InitializeComponent();
            this.MyDG += mf.SetPanel;
            this.InitControl();
            this.SearchAll();
        }

        //查询
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string aq = this.AccountQuantityTBox.Text.Trim();
            string atype = this.AccountTypeCBox.Text.Trim();
            DateTime atime = Convert.ToDateTime(this.AccountDateTime.Text);
            if (atype == "" && aq == "")
                this.SearchByDate(atime);
            else if (aq != "" && atype == "")
                this.SearchByQ(aq);
            else if (aq == "" && atype != "")
                this.SearchByType(atype);
            else
                this.SearchByQ_Type_Date(aq, atype, atime);
        }
        
        //录入
        private void InsertCfBtn_Click(object sender, EventArgs e)
        {
            if (this.IsInputLegal())
            {
                string aq = this.AccountQuantityTBox.Text.Trim();
                string atype = this.AccountTypeCBox.Text.Trim();
                DateTime atime = Convert.ToDateTime(this.AccountDateTime.Text);
                string remark = this.RemarkTBox.Text.Trim();
                this.DoInsert(aq,atype,atime,remark);
            }
        }

        //撤销
        private void DrawBackBtn_Click(object sender, EventArgs e)
        {
            this.AccountQuantityTBox.Clear();
        }

        //删除记录
        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
                return;
            if (this.ClassFeedataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.ClassFeedataGridView.SelectedRows.Count; i++)
                {
                    string aid = this.ClassFeedataGridView.SelectedRows[i].Cells["收支编号"].Value.ToString();
                    if (!this.DelByID(aid))
                        MessageBox.Show("删除收支编号为" + aid + "的班级费用信息时出错！");
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
            if (this.ClassFeedataGridView.SelectedRows.Count > 0)
            {
                string aid = this.ClassFeedataGridView.SelectedRows[0].Cells["收支编号"].Value.ToString();
                string atype = this.ClassFeedataGridView.SelectedRows[0].Cells["收支类型"].Value.ToString();
                string aq = this.ClassFeedataGridView.SelectedRows[0].Cells["收支金额"].Value.ToString();
                string remark = this.ClassFeedataGridView.SelectedRows[0].Cells["备注"].Value.ToString();
                if (atype != "收入" && atype != "支出")
                {
                    MessageBox.Show("请输入收入或支出！");
                    return;
                }
                string timeStr = this.ClassFeedataGridView.SelectedRows[0].Cells["收支日期"].Value.ToString();
                if (timeStr == "")
                {
                    MessageBox.Show("请输入收支日期！");
                    return;
                }
                DateTime atime = Convert.ToDateTime(timeStr);
                string sqlcmd = string.Format("update ClassFee set AccountType = '{0}',AccountQuantity = '{1}' ,AccountDate = '{2}',remarks = '{3}' where AccountID = '{4}'", atype,aq,atime,remark,int.Parse(aid));
                if (!DBModel.UpdateCommand.update(sqlcmd))
                    MessageBox.Show("修改收支记录失败！");
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }


        private bool DelByID(string aid)
        {
            string sqlcmd = string.Format("delete from ClassFee where AccountID = '{0}'", aid);
            return DBModel.DeleteCommand.delete(sqlcmd);
        }  

        private void DoInsert(string aq, string atype, DateTime atime,string remark)
        {
            string sqlcmd = string.Format("insert into ClassFee(AccountDate,AccountType,AccountQuantity,Remarks) values('{0}','{1}','{2}','{3}')", atime, atype, aq ,remark);
            if (!DBModel.InsertCommand.insert(sqlcmd))
            {
                MessageBox.Show("班级费用信息录入失败！");
                return;
            }
            MessageBox.Show("班级费用信息录入成功！");
            this.SearchAll();
        }

        private void SearchAll()
        {
            string sqlcmd = "select AccountID as 收支编号,AccountDate as 收支日期, AccountType as 收支类型, AccountQuantity as 收支金额,Remarks as 备注 from ClassFee";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.ClassFeedataGridView.DataSource = this.searchTable;
        }

        private void SearchByDate(DateTime time)
        {
            string sqlcmd = string.Format("select AccountID as 收支编号,AccountDate as 收支日期, AccountType as 收支类型, AccountQuantity as 收支金额,Remarks as 备注 from ClassFee where AccountDate = '{0}'", time);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：" + time.Year + "年" + time.Month + "月" + time.Day + "日”的费用收支记录！");
                return;
            }
            this.ClassFeedataGridView.DataSource = this.searchTable;
        }

        private void SearchByQ(string aq)
        {
            if (!this.IsQExist(aq))
            {
                MessageBox.Show("收支金额为" + aq + "的收支记录不存在！");
                return;
            }
            string sqlcmd = string.Format("select AccountID as 收支编号,AccountDate as 收支日期, AccountType as 收支类型, AccountQuantity as 收支金额,Remarks as 备注 from ClassFee where AccountQuantity = '{0}'", aq);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：收支金额为" + aq + "的收支记录！");
                return;
            }
            this.ClassFeedataGridView.DataSource = this.searchTable;
        }

        private void SearchByType(string atype)
        {
            if (!this.IsTypeExist(atype))
            {
                MessageBox.Show("收支类型为" + atype + "的收支记录不存在！");
                return;
            }
            string sqlcmd = string.Format("select AccountID as 收支编号,AccountDate as 收支日期, AccountType as 收支类型, AccountQuantity as 收支金额,Remarks as 备注 from ClassFee where AccountType = '{0}'", atype);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：收支类型为" + atype + "的收支记录！");
                return;
            }
            this.ClassFeedataGridView.DataSource = this.searchTable;
        }

        private void SearchByQ_Type_Date(string aq,string atype,DateTime atime)
        {  
            if (!this.IsTypeExist(atype))
            {
                MessageBox.Show("收支类型为" + atype + "的收支记录不存在！");
                return;
            }

            if (!this.IsQExist(aq))
            {
                MessageBox.Show("收支金额为" + aq + "的收支记录不存在！");
                return;
            }

            string sqlcmd = string.Format("select AccountID as 收支编号,AccountDate as 收支日期, AccountType as 收支类型, AccountQuantity as 收支金额,Remarks as 备注 from ClassFee where AccountQuantity = '{0}' and AccountType = '{1}' and AccountDate = '{2}'", aq, atype, atime);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：收支类型为" + atype + "收支金额为" + aq + "在" + atime.Year + "年" + atime.Month + "月" + atime.Day + "日的收支记录！");
                return;
            }
            this.ClassFeedataGridView.DataSource = this.searchTable;
        }

        private bool IsQExist(string aq)
        {
            string sqlcmd = string.Format("select count(*) from ClassFee where AccountQuantity = '{0}'", aq);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

        private bool IsTypeExist(string atype)
        {
            string sqlcmd = string.Format("select count(*) from ClassFee where AccountType = '{0}'", atype);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

        private bool IsInputLegal()
        {
            if (this.AccountTypeCBox.Text.Trim() == "")
            {
                MessageBox.Show("收支类型不能为空，请输入！");
                return false;
            }
            if (this.AccountQuantityTBox.Text.Trim() == "")
            {
                MessageBox.Show("收支金额不能为空，请填入！");
                return false;
            }
            return true;
        }

        //设置收支编号不可修改
        private void ClassFeedataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.ClassFeedataGridView.CurrentCell.ColumnIndex == 0)
                this.ClassFeedataGridView.CurrentCell.ReadOnly = true;
            else
                this.ClassFeedataGridView.CurrentCell.ReadOnly = false;

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
                this.InsertCfBtn.Enabled = true;
                this.DelBtn.Enabled = true;
                this.ModifyBtn.Enabled = true;
            }
        }
    }
}
