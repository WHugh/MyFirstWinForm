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
    public partial class CourseInfoForm : Form,ICourseView
    {
        private string courseCode;
        private string type;//以查看还是编辑的方式进入该界面
        private CoursePresenter presenter;
        private DataTable courseInfoDT;
        public CourseInfoForm()
        {
            InitializeComponent();
        }
        public CourseInfoForm(string courseCode,string type)
        {
            InitializeComponent();
            this.courseCode = courseCode;
            this.type = type;
            presenter = new CoursePresenter(this);
            courseInfoDT = MakeCourseScoreDT(courseCode);
        }

        private void CourseInfoForm_Load(object sender, EventArgs e)
        {
            if(type.Equals("view"))
            {
                SaveBt.Enabled = false;
                CreditTB.Enabled = false;
                NameTB.Enabled = false;
            }
            if(type.Equals("edit"))
            {
                ScreenBt.Enabled = false;
                ResetBt.Enabled = false;
            }
            presenter.ShowCourseInfo(courseCode);
            CourseScoreDataGridView.DataSource = courseInfoDT;
        }



        void ICourseView.ShowCourse(Course course)
        {
            CodeTB.Text = course.Code;
            NameTB.Text = course.Name;
            CreditTB.Text = course.Credit.ToString();
            ChosenCountTB.Text = course.ChosenCount.ToString();
            //throw new NotImplementedException();
        }
        /// <summary>
        /// 将该课程的所有成绩制作成一个DataTable
        /// </summary>
        /// <param name="courseCode"></param>
        public DataTable MakeCourseScoreDT(string courseCode)
        {
            DataTable courseScoreDT = new DataTable();
            //添加列
            DataColumn userCodeDC = new DataColumn("学生编号", System.Type.GetType("System.String"));
            courseScoreDT.Columns.Add(userCodeDC);
            DataColumn userNameDC = new DataColumn("学生姓名", System.Type.GetType("System.String"));
            courseScoreDT.Columns.Add(userNameDC);
            DataColumn courseScoreDC = new DataColumn("成绩", System.Type.GetType("System.Decimal"));
            courseScoreDT.Columns.Add(courseScoreDC);
            //添加行
            string sqlScoreInfo = "select SOR_STUCODE,SOR_GRADE from TD_Score where SOR_COUCODE='"+courseCode+"'";
            List<List<string>> scoreInfo = CommonFunction.ExecuteSqlReader(sqlScoreInfo);//所有学生编号、成绩
            foreach(List<string> item in scoreInfo)//item -> 一个学生编号、成绩
            {
                string sqlUserName = "select STU_NAME from TD_Student where STU_CODE='"+item[0]+"'";
                string userName = CommonFunction.ExecuteSqlReader(sqlUserName)[0][0];//一个学生姓名
                DataRow row = courseScoreDT.NewRow();
                row[0] = item[0];//code
                row[1] = userName;//name
                row[2] = Convert.ToDecimal(item[1]);//score
                courseScoreDT.Rows.Add(row);
            }
            //默认视图排序
            //DataView dv = courseScoreDT.DefaultView;

            return courseScoreDT;
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            if (!CommonFunction.IsNumString(CreditTB.Text, "int"))
            {
                MessageBox.Show("学分请输入整数！");
                return;
            }
            string sqlUpdate = "update TD_Course set COU_NAME=N'"+
                NameTB.Text+"',STU_CREDIT="+CreditTB.Text+" where COU_CODE='"+courseCode+"'";//保存修改后的课程信息
            CommonFunction.ExecuteSave(sqlUpdate);
            this.Close();
        }

        private void ScreenBt_Click(object sender, EventArgs e)
        {
            ScreenScoreForm screenForm = new ScreenScoreForm(courseInfoDT, "one", NameTB.Text);
            if(screenForm.ShowDialog() == DialogResult.OK)
            {
                CourseScoreDataGridView.DataSource = screenForm.dv;
            }
        }

        private void ResetBt_Click(object sender, EventArgs e)
        {
            CourseScoreDataGridView.DataSource = courseInfoDT;
        }

        private void CourseInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
