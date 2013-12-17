using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassManagementSystem.UserManage
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
            this.UserTBox.Text = UserInfo.User.UserName;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.Modify();
        }

        private bool IsInputLegal()
        {
            if (this.OldPwdTBox.Text.Trim() == "")
            {
                MessageBox.Show("旧密码不能为空！");
                this.OldPwdTBox.Focus();
                return false;
            }
            if (this.PassTBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入新密码！");
                this.PassTBox1.Focus();
                return false;
            }
            if (this.PassTBox2.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！");
                this.PassTBox2.Focus();
                return false;
            }
            if (this.PassTBox1.Text.Trim() != this.PassTBox2.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一样！");
                return false;
            }
            return true;
        }

        private void PassTBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.Modify();
            }
        }

        private void Modify()
        {
            if (this.IsInputLegal())
            {
                string user = UserInfo.User.UserName;
                string oldpwd = this.OldPwdTBox.Text.Trim();
                string sql = string.Format("select Password from Users where UserName = '{0}'",user);
                string res = DBModel.SelectCommand.getValue(sql);
                if (res == null || res != oldpwd)
                {
                    MessageBox.Show("旧密码输入错误！");
                    return;
                }
                string pwd = this.PassTBox1.Text.Trim();
                string sqlcmd = string.Format("update Users set Password = '{0}' where UserName = '{1}'", pwd, user);
                if (DBModel.UpdateCommand.update(sqlcmd))
                {
                    MessageBox.Show("密码修改成功！");
                    this.Close();
                }
                else
                    MessageBox.Show("密码修改失败！");
            }
        }
    }
}
