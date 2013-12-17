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
    public partial class AddUserUC : UserControl
    {
        private DataTable searchTable = null;
        private event MyDelegate MyDG;

        public AddUserUC(mainForm mf)
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

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (this.IsInputLegal())
            {
                string user = this.UserTBox.Text.Trim();
                string pwd = this.PassTBox.Text.Trim();
                string isadmin = "N";
                if (this.UserTypeCBox.Text == "管理员")
                    isadmin = "Y";
                string sqlcmd = string.Format("insert into Users(UserName,Password,IsAdmin) values('{0}','{1}','{2}')", user, pwd, isadmin);
                if (DBModel.InsertCommand.insert(sqlcmd))
                {
                    MessageBox.Show("添加新用户成功！");
                    this.SearchAll();
                    return;
                }
                MessageBox.Show("添加新用户失败！");
            }
        }

        private void DrawBackBtn_Click(object sender, EventArgs e)
        {
            this.UserTBox.Clear();
            this.PassTBox.Clear();
        }

        private void SearchAll()
        {
            string sqlcmd = "select UserName as 用户名,Password as 密码,case when IsAdmin = 'Y' then '管理员' else '普通用户' end as 用户身份 from Users";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.UserdataGridView.DataSource = this.searchTable;
        }

        private bool IsInputLegal()
        {
            if (this.UserTBox.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！");
                this.UserTBox.Focus();
                return false;
            }
            if (this.PassTBox.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！");
                this.PassTBox.Focus();
                return false;
            }
            if (this.UserTypeCBox.Text == "")
            {
                MessageBox.Show("用户身份不能为空！");
                return false;
            }
            return true;
        }
    }
}
