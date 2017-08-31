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
    public partial class ChooseCourseForm : Form,ICourseView
    {
        private CoursePresenter presenter;
        private string userCode = "";
        private string type = "";//以学生的选课、退课 和 管理员三种方式打开该界面
        public ChooseCourseForm()
        {
            InitializeComponent();

        }
        public ChooseCourseForm(string userCode, string type)
        {
            InitializeComponent();
            this.userCode = userCode;
            this.type = type;
        }
        private void ChooseCourse_Load(object sender, EventArgs e)
        {
            presenter = new CoursePresenter(this);
            courseDataGridView.Rows.Clear();//清除所有的行，重新加载

            List<List<string>> courseCode = new List<List<string>>();
            if (type.Equals("choose"))//选课方式打开界面
            {
                courseDataGridView.MultiSelect = true;//可以同时选择多门课程
                courseCode = presenter.GetCourseCode(userCode, "notChosen");
                SaveBt.Text = "选课";
                ViewBt.Enabled = false;
                EditBt.Enabled = false;
                CreatCourseBt.Enabled = false;
                DeleteCourseBt.Enabled = false;
            }
            if (type.Equals("drop"))//退课方式打开界面
            {
                courseDataGridView.MultiSelect = true;//可以同时退掉多门课程
                courseCode = presenter.GetCourseCode(userCode, "hasChosen");
                SaveBt.Text = "退课";
                ViewBt.Enabled = false;
                EditBt.Enabled = false;
                CreatCourseBt.Enabled = false;
                DeleteCourseBt.Enabled = false;
            }
            if(type.Equals("admin"))//管理员方式打开界面
            {
                courseCode = presenter.GetCourseCode(userCode, "allCode");
                SaveBt.Enabled = false;
                courseDataGridView.MultiSelect = false;//管理员只能单行查看、编辑或删除
            }
            
            foreach(List<string> codeItem in courseCode)
            {
                presenter.ShowCourseInfo(codeItem[0]);
            }
            
        }

        void ICourseView.ShowCourse(Course course)
        {
            int index = courseDataGridView.Rows.Add();
            courseDataGridView.Rows[index].Cells[0].Value = course.Code;
            courseDataGridView.Rows[index].Cells[1].Value = course.Name;
            courseDataGridView.Rows[index].Cells[2].Value = course.Credit;
            courseDataGridView.Rows[index].Cells[3].Value = course.ChosenCount;
            //throw new NotImplementedException();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            if (SaveBt.Text.Equals("选课"))//选课
            {
                //chooseRows用来装多行的课程信息，每行包含courseCode和courseName
                List<List<string>> chooseRows = new List<List<string>>();
                foreach (DataGridViewRow row in courseDataGridView.Rows)
                {
                    //courseRow用来装一行的课程信息，包含courseCode和courseName
                    List<string> courseRow = new List<string>();
                    if (row.Selected == true)
                    {
                        courseRow.Add(row.Cells[0].Value.ToString());
                        courseRow.Add(row.Cells[1].Value.ToString());
                        chooseRows.Add(courseRow);
                    }
                }
                presenter.ChooseCourse(chooseRows, userCode);
                this.Close();
                //LoginForm.stuMainForm.StudentMainForm_Load(object sender, EventArgs e);
            }
            if (SaveBt.Text.Equals("退课"))//退课
            {
                //chooseRows用来装多行的课程信息，每行包含courseCode和courseName
                List<List<string>> chooseRows = new List<List<string>>();
                foreach (DataGridViewRow row in courseDataGridView.Rows)
                {
                    //courseRow用来装一行的课程信息，包含courseCode和courseName
                    List<string> courseRow = new List<string>();
                    if (row.Selected == true)
                    {
                        courseRow.Add(row.Cells[0].Value.ToString());
                        courseRow.Add(row.Cells[1].Value.ToString());
                        chooseRows.Add(courseRow);
                    }
                }
                presenter.DropCourse(chooseRows, userCode);
                this.Close();
            }
        }

        private void ViewBt_Click(object sender, EventArgs e)
        {
            if (courseDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要查看的课程所在行。");
                return;
            }
            //打开某门课程的详细信息界面
            string courseCode = courseDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取到选中行的courseCode
            CourseInfoForm courseInfoForm = new CourseInfoForm(courseCode, "view");
            this.Hide();//打开新界面是隐藏该界面
            if (courseInfoForm.ShowDialog() == DialogResult.OK)
            {
                ChooseCourse_Load(null, null);//重新加载界面
                this.Show();//退出新界面时显示该界面
            }
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            if (courseDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要编辑的课程所在行。");
                return;
            }
            //打开某门课程的详细信息界面
            string courseCode = courseDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取到选中行的courseCode
            CourseInfoForm courseInfoForm = new CourseInfoForm(courseCode, "edit");
            this.Hide();//打开新界面是隐藏该界面
            if (courseInfoForm.ShowDialog() == DialogResult.OK)
            {
                ChooseCourse_Load(null, null);//重新加载界面
                this.Show();//退出新界面时显示该界面
            }
        }

        private void CreatCourseBt_Click(object sender, EventArgs e)
        {
            CreateCourseForm createCourseForm = new CreateCourseForm();
            createCourseForm.ShowDialog();
            ChooseCourse_Load(null, null);//重新加载界面
        }

        private void DeleteCourseBt_Click(object sender, EventArgs e)
        {
            if (courseDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要删除的课程所在行。");
                return;
            }
            string courseCode = courseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string sqlDeleteCourse = "delete from TD_Course where COU_CODE='" + courseCode + "'";//删除course表里的课程
            string sqlIsHasScore = "select * from TD_Score where SOR_COUCODE='" + courseCode + "'";//判断score表里是否有该课程的成绩
            string sqlDeleteScore = "delete from TD_Score where SOR_COUCODE='" + courseCode + "'";//如果有对应成绩则删除score表对应的数据
            if(CommonFunction.ExecuteSqlReader(sqlIsHasScore).Count > 0)//有成绩
            {
                if (CommonFunction.ExecuteSqlNonQuery(sqlDeleteCourse) > 0 && 
                    CommonFunction.ExecuteSqlNonQuery(sqlDeleteScore) > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {
                if (CommonFunction.ExecuteSqlNonQuery(sqlDeleteCourse) > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
           
            ChooseCourse_Load(null, null);//重新加载界面
        }

        private void ChooseCourseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        
    }
}
