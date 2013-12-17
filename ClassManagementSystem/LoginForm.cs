using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassManagementSystem
{
    public partial class LoginForm : Form
    {
        private bool IsMouseDownInForm = false;
        private Point p;
        private bool is_logined;
        public bool IsLogined
        {
            get
            {
                return this.is_logined;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.IsMouseDownInForm = true;
            this.p = e.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.IsMouseDownInForm)
            {
                this.Left += e.Location.X - this.p.X;
                this.Top += e.Location.Y - this.p.Y;
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            this.IsMouseDownInForm = false;
        }

        //点击登录
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        //绑定回车键
        private void PassTBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.Login();
            }
        }

        //登录函数
        private void Login()
        {
            this.is_logined = false;
            if (this.IsInputLegal())
            {
                string username = this.UserTBox.Text.Trim();
                string password = this.PassTBox.Text.Trim();
                
                string sqlcmd = string.Format("select * from Users where UserName='{0}' and Password='{1}'", username, password);
                DataTable table = DBModel.SelectCommand.getTable(sqlcmd);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("用户名或密码错误，请检查输入是否有误！");
                    this.PassTBox.Clear();
                }
                else
                {
                    this.is_logined = true;
                    UserInfo.User.UserName = username;
                    UserInfo.User.PassWord = password;
                    if (table.Rows[0]["IsAdmin"].ToString() == "Y")
                        UserInfo.User.IsAdmin = true;
                    else
                        UserInfo.User.IsAdmin = false;
                    this.Close();
                }
            }
        }

        //判断输入是否合法
        private bool IsInputLegal()
        {
            if (this.UserTBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("用户名不能为空，请重新输入！");
                this.UserTBox.Focus();
                return false;
            }
            if (this.PassTBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("密码不能为空，请重新输入！");
                this.PassTBox.Focus();
                return false;
            }
            return true;
        }

        private void UserTBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.Login();
            }
        } 
    }
}
