using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StuScoreManagement.Forms;

namespace StuScoreManagement
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
            LoginForm.loginForm = new LoginForm();
            LoginForm.loginForm.ShowDialog();
            if (LoginForm.stuMainForm != null)
            {
                Application.Run(LoginForm.stuMainForm);
            }
            if (LoginForm.adminMainForm != null)
            {
                Application.Run(LoginForm.adminMainForm);
            }
            //Application.Run(new AdminScoreForm());
            //if()
            
        }
    }
}
