using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassManagementSystem.UserManage
{
    public partial class DelUserUC : UserControl
    {
        private DataTable searchTable = null;
        private event MyDelegate MyDG;

        public DelUserUC(mainForm mf)
        {
            InitializeComponent();
            this.MyDG += mf.SetPanel;
            this.SearchAll();
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

        private void SearchAll()
        {
            string sqlcmd = "select UserName as 用户名,Password as 密码,case when IsAdmin = 'Y' then '管理员' else '普通用户' end as 用户身份 from Users";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.UserdataGridView.DataSource = this.searchTable;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.UserNameTBox.Clear();
            this.SearchAll();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这些用户吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DR == DialogResult.No)
                return;
            if (this.UserdataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.UserdataGridView.SelectedRows.Count; i++)
                {
                    string user = this.UserdataGridView.SelectedRows[i].Cells["用户名"].Value.ToString();
                    string sqlcmd = string.Format("delete from Users where UserName = '{0}'", user);
                    if (!DBModel.DeleteCommand.delete(sqlcmd))
                    {
                        MessageBox.Show("删除用户：" + user + "时出错!");
                        continue;
                    }
                }
            }
            this.SearchAll();
        }

        private void UserNameTBox_TextChanged(object sender, EventArgs e)
        {
            string user = this.UserNameTBox.Text.Trim();
            this.SearchByUser(user);
        }

        private void SearchByUser(string user)
        {
            string sqlcmd = string.Format(@"select UserName as 用户名,Password as 密码,
                        case when IsAdmin = 'Y' then '管理员' else '普通用户' end as 用户身份 
                        from Users where UserName like '%{0}%'",user);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.UserdataGridView.DataSource = this.searchTable;
        }
    }
}
