using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StuScoreManagement
{
    public class UserModel:IUserModel
    {
        void IUserModel.SaveUser(string code, string name, string psw, char gender,
            string birth, string native, char statu, char isAdmin, string type)
        {
            string tmp = "','";
            string sqlInsert =
                "insert into TD_Student values ('" + code +"',N'"+name + tmp + 
                psw + tmp + gender + tmp + birth +"',N'"+ native + tmp + statu + tmp + isAdmin + "')";
            
            string sqlUpdate =
                "update TD_Student set STU_NAME=N'" + name + "',STU_PASSWORD='"+psw+"',STU_GENDER='" + 
                gender + "',STU_BIRTH='" + birth + "',STU_NATIVE=N'" + native + "',STU_STATU='1' where STU_CODE='" + code+"'";

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

        User IUserModel.load(string userCode)
        {
            User user = new User();
            string sqlUser = "select * from TD_Student where STU_CODE='"+userCode+"'";
            string sqlCourse =
                "select * from TD_Course where COU_CODE in (select SOR_COUCODE from TD_Score where SOR_STUCODE='"+userCode+"')";
            string sqlScore = "select * from TD_Score where SOR_STUCODE='"+userCode+"'";

            List<List<string>> userList = CommonFunction.ExecuteSqlReader(sqlUser);
            List<List<string>> scoreList = CommonFunction.ExecuteSqlReader(sqlScore);
            List<List<string>> courseList = CommonFunction.ExecuteSqlReader(sqlCourse);

            //设置user的基础属性
            user.Code = userList[0][0];
            user.Name = userList[0][1];
            user.Gender = (userList[0][3] == '0'.ToString()?"男":"女");
            user.Birth = CommonFunction.DateStringFormat(userList[0][4]);
            user.Native = userList[0][5];
            user.Statu = userList[0][6];
            user.IsAdmin = userList[0][7];
            //为user的List<Course>添加元素
            foreach(List<string> courseItem in courseList)
            {
                Course course = new Course();
                course.Code = courseItem[0];
                course.Name = courseItem[1];
                course.Credit = Convert.ToInt32(courseItem[2]);
                course.ChosenCount = Convert.ToInt32(courseItem[3]);
                //设置course的成绩
                foreach(List<string> scoreItem in scoreList)
                {
                    if(course.Code.Equals(scoreItem[1]))
                    {
                        course.Score = Convert.ToDecimal(scoreItem[2]);
                    }
                }
                user.AddCourse(course);
            }
            
            return user;
        }
    }
}
