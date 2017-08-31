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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void SignOutBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);

        }

        private void ScoreBt_Click(object sender, EventArgs e)
        {
            AdminScoreForm adminScoreForm = new AdminScoreForm();
            this.Hide();
            if(adminScoreForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }         
        }

        private void CourseBt_Click(object sender, EventArgs e)
        {
            ChooseCourseForm adminCourseForm = new ChooseCourseForm("", "admin");
            this.Hide();
            if (adminCourseForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void StuBt_Click(object sender, EventArgs e)
        {
            AdminStuForm adminStuForm = new AdminStuForm();
            this.Hide();
            if(adminStuForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
