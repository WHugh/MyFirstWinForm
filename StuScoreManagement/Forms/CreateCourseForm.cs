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
    public partial class CreateCourseForm : Form
    {
        private CoursePresenter presenter;
        public CreateCourseForm()
        {
            InitializeComponent();
            this.presenter = new CoursePresenter();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            //判断新增的课程是否已存在
            string sqlCourseIsExist = "select COU_NAME from TD_Course where COU_NAME=N'" + CourseNameTB.Text + "'";
            if (CommonFunction.ExecuteSqlReader(sqlCourseIsExist).Count != 0)//如果有数据，那么count！=0，即课程重复了
            {
                MessageBox.Show("该课程已存在！");
                return;
            }
            //NumericUpDown.text不可见，但是其父类UpDownBase.text可见，向上转型取得text
            UpDownBase creditUpDownBase = (UpDownBase)CreditNumericUpDown;
            presenter.CreateCourse(CourseNameTB.Text, creditUpDownBase.Text);
            this.Close();
        }

        
    }
}
