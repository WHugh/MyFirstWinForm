using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace StuScoreManagement
{
    public class CoursePresenter
    {
        private ICourseModel courseModel;
        private ICourseView courseView;

        public CoursePresenter() { this.courseModel = new CourseModel(); }
        public CoursePresenter(ICourseView courseView)
        {
            this.courseView = courseView;
            this.courseModel = new CourseModel();
        }

        public void ShowCourseInfo(string courseCode)
        {
            Course course = courseModel.load(courseCode);
            courseView.ShowCourse(course);
        }
        public List<List<string>> GetCourseCode(string userCode,string type)
        {
            string sqlAllCode = "select COU_CODE from TD_COURSE";
            string sqlNotChosen =
                "select COU_CODE from TD_Course where TD_Course.COU_CODE not in (select SOR_COUCODE from TD_Score where SOR_STUCODE='"+userCode+"')";
            string sqlHasChosen = "select SOR_COUCODE from TD_Score where SOR_STUCODE='" + userCode + "'";
            List<List<string>> courseCode = new List<List<string>>();
            if(type.Equals("allCode"))
            {
                courseCode = CommonFunction.ExecuteSqlReader(sqlAllCode);
            }
            else if(type.Equals("notChosen"))
            {
                courseCode = CommonFunction.ExecuteSqlReader(sqlNotChosen);
            }
            else
            {
                courseCode = CommonFunction.ExecuteSqlReader(sqlHasChosen);
            }
            return courseCode;
        }
        public void ChooseCourse(List<List<string>> chooseRows,string userCode)
        {
            string tmp = "','";
            string hasChosen = "";//选择成功的课程名称
            int chooseSuccessCount = 0;//选择成功的课程数量
            int isChooseOne = 0;//用来标记一门课是否选择成功，==0表示不成功
            foreach (List<string> courseRow in chooseRows)
            {
                string sqlChooseCourse = "insert into TD_Score values('"+userCode+tmp+courseRow[0]+"','0')";
                string sqlChosenCount =
                    "update TD_Course set CHOSEN_COUNT=CHOSEN_COUNT+1 where COU_CODE='"+courseRow[0]+"'";
                isChooseOne = CommonFunction.ExecuteSqlNonQuery(sqlChooseCourse);
                if(isChooseOne > 0)
                {
                    chooseSuccessCount++;
                    hasChosen += (courseRow[1]+"  ");
                }
                if( isChooseOne == 0)
                {
                    MessageBox.Show("成功选课"+chooseSuccessCount+"门：\n"+hasChosen+"\n其他课程选课失败。");
                    return;
                }
                CommonFunction.ExecuteSqlNonQuery(sqlChosenCount);//
            }
            MessageBox.Show("成功选课" + chooseSuccessCount + "门：\n" + hasChosen);
        }
        public void DropCourse(List<List<string>> chooseRows, string userCode)
        {
            string hasDrop = "";//退课成功的课程名称
            int dropSuccessCount = 0;//退课成功的课程数量
            int isDropOne = 0;//用来标记一门课是否退课成功，==0表示不成功
            foreach (List<string> courseRow in chooseRows)
            {
                string sqlDropCourse =
                    "delete from TD_Score where SOR_COUCODE='"+courseRow[0]+"' and SOR_STUCODE='"+userCode+"'";
                string sqlChosenCount =
                    "update TD_Course set CHOSEN_COUNT=CHOSEN_COUNT-1 where COU_CODE='"+courseRow[0]+"'";
                isDropOne = CommonFunction.ExecuteSqlNonQuery(sqlDropCourse);
                if(isDropOne > 0)
                {
                    hasDrop += (courseRow[1] + "  ");
                    dropSuccessCount++;
                }
                if(isDropOne == 0)
                {
                    MessageBox.Show("成功退课" + dropSuccessCount + "门：\n" + hasDrop + "\n其他课程退课失败。");
                    return;
                }
                CommonFunction.ExecuteSqlNonQuery(sqlChosenCount);
            }
            MessageBox.Show("成功退课" + dropSuccessCount + "门：\n" + hasDrop);
        }
        
        public void CreateCourse(string courseName,string creditString)
        {
            int credit = Convert.ToInt32(creditString);
            //找出最大课程编号
            string sqlMaxCode = "select max(convert(int,COU_CODE)) from TD_Course";
            //新的课程编号=最大课程编号+1
            string courseCode = (Convert.ToInt32(CommonFunction.ExecuteSqlReader(sqlMaxCode)[0][0]) + 1).ToString("00");
            courseModel.saveCourse(courseCode, courseName, credit, "insert");
        }

        //方法写在此行以上
    }
}

