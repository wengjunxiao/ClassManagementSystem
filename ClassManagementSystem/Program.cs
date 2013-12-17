using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagementSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginFrm = new LoginForm();
            loginFrm.ShowDialog();
            if (loginFrm.IsLogined)
            {
                Application.Run(new mainForm());
            }
        }
    }
}
