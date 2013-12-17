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
    public partial class PersonInfoUC : UserControl
    {
        private event MyDelegate MyDG;

        public PersonInfoUC(mainForm mf)
        {
            InitializeComponent();
            this.MyDG += mf.SetPanel;
            this.InitContrls();
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string sname = this.SnameTBox.Text.Trim();
            if (sname == "")
            {
                MessageBox.Show("姓名不能为空！");
                this.SnameTBox.Focus();
                return;
            }
            string sex = this.SexCBox.Text;
            DateTime birth = Convert.ToDateTime(this.BirthDate.Text);
            string clas = this.ClassTBox.Text.Trim();
            string spec = this.SpecTBox.Text.Trim();
            string sqlcmd = string.Format(@"update Students set Sname = '{0}',Sex = '{1}',
                        BirthDate = '{2}',Class = '{3}',Specialty = '{4}' where Sno = '{5}'",
                     sname, sex, birth, clas, spec, UserInfo.User.UserName);
            if (DBModel.UpdateCommand.update(sqlcmd))
            {
                MessageBox.Show("信息保存成功！");
                return;
            }
            MessageBox.Show("信息保存失败！");

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (this.MyDG != null)
                this.MyDG();
        }

        private void InitContrls()
        {
            string sqlcmd = string.Format("select Sname,Sex,BirthDate,Class,Specialty from Students where Sno = '{0}'",UserInfo.User.UserName);
            DataTable table = DBModel.SelectCommand.getTable(sqlcmd);
            if (table == null)
                return;
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("无个人信息，请与管理员联系！");
                if (this.MyDG != null)
                    this.MyDG();
                return;
            }
            this.SnoTBox.Text = UserInfo.User.UserName;
            this.SnameTBox.Text = table.Rows[0]["Sname"].ToString();
            this.SexCBox.Text = table.Rows[0]["Sex"].ToString();
            this.BirthDate.Text = table.Rows[0]["BirthDate"].ToString();
            this.ClassTBox.Text = table.Rows[0]["Class"].ToString();
            this.SpecTBox.Text = table.Rows[0]["Specialty"].ToString();
        }
    }
}
