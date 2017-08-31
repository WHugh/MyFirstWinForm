using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuScoreManagement.Forms
{
    public partial class LoginForm : Form
    {
        private UserPresenter presenter = new UserPresenter();
        public static LoginForm loginForm = null;//static，用来在注销后显示登录界面
        public static StudentMainForm stuMainForm = null;//普通用户主界面
        public static AdminMainForm adminMainForm = null;//管理员用户主界面
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            bool[] signInResult = presenter.SignIn(userCodeTB.Text,pswTB.Text);
            if(signInResult[0])
            {
                if(signInResult[1])//管理员
                {
                    LoginForm.adminMainForm = new AdminMainForm();
                    this.Close();
                }
                else//普通用户
                {
                    LoginForm.stuMainForm = new StudentMainForm(userCodeTB.Text);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误，\n请检查输入！");
            }
        }

        

       
    }
}
