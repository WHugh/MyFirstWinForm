using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuScoreManagement
{
    public class CourseModel:ICourseModel
    {
        void ICourseModel.saveCourse(string courseCode, string courseName, 
            int stuCredit,string type)
        {
            int chosenCount = 0;//新增的话chosenCount肯定是0，更新的话和chosenCount无关，也不用更新chosenCount
            string tmp = "','";
            string sqlInsert =
                "insert into TD_Course values ('"+courseCode+"',N'"+courseName+tmp+stuCredit+tmp+chosenCount+"')";
            string sqlUpdate =
                "update TD_Course set COU_NAME=N'"+courseName+"',STU_CREDIT='"+stuCredit+"' where COU_CODE='"+
                courseCode+"'";
            if(type.Equals("update"))
            {
                CommonFunction.ExecuteSave(sqlUpdate);
            }
            else
            {
                CommonFunction.ExecuteSave(sqlInsert);
            }
            //throw new NotImplementedException();
        }

        Course ICourseModel.load(string courseCode)
        {
            Course course = new Course();
            string sqlShowCourse = "select * from TD_Course where COU_CODE='"+courseCode+"'";
            List<List<string>> courseData = CommonFunction.ExecuteSqlReader(sqlShowCourse);
            course.Code = courseData[0][0];
            course.Name = courseData[0][1];
            course.Credit = Convert.ToInt32(courseData[0][2]);
            course.ChosenCount = Convert.ToInt32(courseData[0][3]);
            return course;
            //throw new NotImplementedException();
        }

    }
}
