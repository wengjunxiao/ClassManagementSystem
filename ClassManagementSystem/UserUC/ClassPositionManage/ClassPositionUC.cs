using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassManagementSystem.ClassPositionManage
{
    public partial class ClassPositionUC : UserControl
    {
        private DataTable searchTable = null;
        private event MyDelegate MyDG;

        public ClassPositionUC(mainForm mf)
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
            string posname = this.PositionCBox.Text.Trim();
            if (sno == "" && posname == "")
                this.SearchAll();
            else if (posname != "" && sno == "")
                this.SearchByPosname(posname);
            else if (posname == "" && sno != "")
                this.SearchByNo(sno);
            else
                this.SearchByNo_Posname(sno, posname);
        }

        //录入
        private void InsertCpBtn_Click(object sender, EventArgs e)
        {
            if (this.IsInputLegal())
            {
                string sno = this.SnoTBox.Text.Trim();
                string posname = this.PositionCBox.Text.Trim();
                DateTime btime = Convert.ToDateTime(this.BdateTime.Text);
                bool isPresent = true;
                if (this.PastradioButton.Checked == true)
                    isPresent = false;
                if (!this.IsSnoExist(sno))
                {
                    MessageBox.Show("学号为" + sno + "的学生不存在！");
                    return;
                }
                if (!this.IsPosExist(posname))
                {
                    if (!this.AddPos(posname))
                    {
                        MessageBox.Show("添加新班级职务时出错！");
                        return;
                    }
                }
                string posid = this.GetPosID(posname);
                if (posid == null)
                {
                    MessageBox.Show("班级职务：" + posname + "不存在！");
                    return;
                }
                if (isPresent)
                    this.DoInsert(sno, int.Parse(posid), btime);
                else
                {
                    DateTime etime = Convert.ToDateTime(this.EdateTime.Text);
                    this.DoInsert(sno, int.Parse(posid), btime, etime);
                }
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
            DialogResult DR = MessageBox.Show("您真的要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
                return;
            if (this.ClassPositiondataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.ClassPositiondataGridView.SelectedRows.Count; i++)
                {
                    string sno = this.ClassPositiondataGridView.SelectedRows[i].Cells["学号"].Value.ToString();
                    if (!this.DelByNo(sno))
                        MessageBox.Show("删除学号为" + sno + "的学生的班级干部信息时出错！");
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

        //修改记录
        private void DoModify()
        {
            if (this.ClassPositiondataGridView.SelectedRows.Count > 0)
            {
                string sno = this.ClassPositiondataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
                string posname = this.ClassPositiondataGridView.SelectedRows[0].Cells["班级职务"].Value.ToString();
                string timeStr = this.ClassPositiondataGridView.SelectedRows[0].Cells["上任日期"].Value.ToString();
                if (timeStr == "")
                {
                    MessageBox.Show("请输入上任日期！");
                    return;
                }
                DateTime btime = Convert.ToDateTime(timeStr);
                string end = this.ClassPositiondataGridView.SelectedRows[0].Cells["离职日期"].Value.ToString();
                if (!IsPosExist(posname))
                {
                    if (!this.AddPos(posname))
                    {
                        MessageBox.Show("添加新班级职务时出错！");
                        return;
                    }
                }
                string posid = this.GetPosID(posname);
                if (posid == null)
                {
                    MessageBox.Show("班级职务：" + posname + "不存在！");
                    return;
                }
                if (end == "")
                {
                    string sqlcmd = string.Format(@"update Students_Position set PosID = {0},
                            PosBeginDate = '{1}',PosEndDate = null where Sno = '{2}'",
                             int.Parse(posid), btime, sno);
                    if (!DBModel.UpdateCommand.update(sqlcmd))
                        MessageBox.Show("修改班干部信息失败！");
                }
                else
                {
                    DateTime etime = Convert.ToDateTime(end); 
                    string sqlcmd = string.Format(@"update Students_Position set PosID = {0},
                            PosBeginDate = '{1}',PosEndDate = '{2}' where Sno = '{3}'",
                             int.Parse(posid), btime, etime, sno);
                    if (!DBModel.UpdateCommand.update(sqlcmd))
                        MessageBox.Show("修改班干部信息失败！");
                }
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        //按学号删除记录
        private bool DelByNo(string sno)
        {
            string sqlcmd = string.Format("delete from Students_Position where Sno = '{0}'", sno);
            return DBModel.DeleteCommand.delete(sqlcmd);
        }

        //重载两个插入函数
        private void DoInsert(string sno, int posid, DateTime btime)
        {
            string sqlcmd = string.Format(@"insert into Students_Position(Sno,PosID,PosBeginDate) 
                        values('{0}',{1},'{2}')", sno, posid, btime);
            if (!DBModel.InsertCommand.insert(sqlcmd))
            {
                MessageBox.Show("班级干部信息录入失败！");
                return;
            }
            MessageBox.Show("班级干部信息录入成功！");
            this.SearchAll();
        }

        private void DoInsert(string sno, int posid, DateTime btime,DateTime etime)
        {
            string sqlcmd = string.Format(@"insert into Students_Position(Sno,PosID,PosBeginDate,PosEndDate) 
                        values('{0}',{1},'{2}','{3}')", sno,posid,btime,etime);
            if (!DBModel.InsertCommand.insert(sqlcmd))
            {
                MessageBox.Show("班级干部信息录入失败！");
                return;
            }
            MessageBox.Show("班级干部信息录入成功！");
            this.SearchAll();
        }

        //查询所有记录
        private void SearchAll()
        {
            string sqlcmd = @"select S.Sno as 学号,S.Sname as 姓名, P.PosName as 班级职务,
                            SP.PosBeginDate as 上任日期,SP.PosEndDate as 离职日期,
                            case when SP.PosEndDate is null then '是' else '否' end as 是否在职 
                            from Students S,Students_Position SP,ClassPosition P 
                            where S.Sno = SP.Sno and SP.PosID = P.PosID";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.ClassPositiondataGridView.DataSource = this.searchTable;
        }

        //按班级职务名称查询
        private void SearchByPosname(string posname)
        {
            if (!this.IsPosExist(posname))
            {
                MessageBox.Show("班级职务为" + posname + "的职务不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname as 姓名,
                        P.PosName as 班级职务, SP.PosBeginDate as 上任日期, SP.PosEndDate as 离职日期,
                        case when SP.PosEndDate is null then '是' else '否' end as 是否在职 
                        from Students S,Students_Position SP,ClassPosition P 
                        where S.Sno = SP.Sno and P.PosName = '{0}' and SP.PosID = P.PosID", posname);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：班级职务为" + posname + "的学生记录！");
                return;
            }
            this.ClassPositiondataGridView.DataSource = this.searchTable;
        }

        //按学号查询
        private void SearchByNo(string sno)
        {
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为" + sno + "的学生不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname as 姓名,
                        P.PosName as 班级职务, SP.PosBeginDate as 上任日期, SP.PosEndDate as 离职日期,
                        case when SP.PosEndDate is null then '是' else '否' end as 是否在职 
                        from Students S,Students_Position SP,ClassPosition P 
                        where S.Sno = SP.Sno and S.Sno = '{0}' and SP.PosID = P.PosID", sno);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：学号为" + sno + "的学生记录！");
                return;
            }
            this.ClassPositiondataGridView.DataSource = this.searchTable;
        }

        //按学号和职务名称查询
        private void SearchByNo_Posname(string sno, string posname)
        { 
            if (!this.IsSnoExist(sno))
            {
                MessageBox.Show("学号为" + sno + "的学生不存在！");
                return;
            }
            if (!this.IsPosExist(posname))
            {
                MessageBox.Show("班级职务为" + posname + "的职务不存在！");
                return;
            }
            string sqlcmd = string.Format(@"select S.Sno as 学号,S.Sname as 姓名,
                        P.PosName as 班级职务, SP.PosBeginDate as 上任日期, SP.PosEndDate as 离职日期,
                        case when SP.PosEndDate is null then '是' else '否' end as 是否在职 
                        from Students S,Students_Position SP,ClassPosition P 
                        where S.Sno = SP.Sno and S.Sno = '{0}' and P.PosName = '{1}' and SP.PosID = P.PosID", sno,posname);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到：学号为" + sno + "班级职务为" + posname + "的学生！");
                return;
            }
             this.ClassPositiondataGridView.DataSource = this.searchTable;

        }

        private bool IsPosExist(string posname)
        {
            string sqlcmd = string.Format("select count(*) from ClassPosition where PosName = '{0}'", posname);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

        private bool IsSnoExist(string sno)
        {
            string sqlcmd = string.Format("select count(*) from Students where Sno = '{0}'", sno);
            int count = DBModel.SelectCommand.getCount(sqlcmd);
            if (count < 1)
                return false;
            return true;
        }

        //判断输入是否合法
        private bool IsInputLegal()
        {
            if (this.SnoTBox.Text.Trim() == "")
            {
                MessageBox.Show("学号不能为空，请输入入！");
                return false;
            }
            if (this.PositionCBox.Text.Trim() == "")
            {
                MessageBox.Show("班级职务不能为空，请填入！");
                return false;
            }
            return true;
        }

        private bool AddPos(string posname)
        {
            string sqlcmd = string.Format("insert into ClassPosition(PosName) values('{0}')", posname);
            return DBModel.InsertCommand.insert(sqlcmd);
        }

        private string GetPosID(string posname)
        {
            string sqlcmd = string.Format("select PosID from ClassPosition where PosName = '{0}'", posname);
            return DBModel.SelectCommand.getValue(sqlcmd);
        }

        //设置学号和姓名,最后一列不可修改    
        private void ClassPositiondataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.ClassPositiondataGridView.ColumnCount;
            if (this.ClassPositiondataGridView.CurrentCell.ColumnIndex == 0 || this.ClassPositiondataGridView.CurrentCell.ColumnIndex == 1 || this.ClassPositiondataGridView.CurrentCell.ColumnIndex == count - 1)
                this.ClassPositiondataGridView.CurrentCell.ReadOnly = true;
            else
                this.ClassPositiondataGridView.CurrentCell.ReadOnly = false;
        }

        //刷新
        private void RefreshBtn_Click_1(object sender, EventArgs e)
        {
            this.SearchAll();
        }

        private void DrawBackBtn_Click_1(object sender, EventArgs e)
        {
            this.SnoTBox.Clear();
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
                this.InsertCpBtn.Enabled = true;
                this.DelBtn.Enabled = true;
                this.ModifyBtn.Enabled = true;
            }
        }
    }

}
