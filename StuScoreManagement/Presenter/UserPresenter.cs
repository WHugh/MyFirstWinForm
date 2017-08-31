using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace StuScoreManagement
{
    public class UserPresenter
    {
        private IUserView userView;
        private IUserModel userModel;

        public UserPresenter() { this.userModel = new UserModel(); }
        public UserPresenter(IUserView view)
        {
            this.userView = view;
            this.userModel = new UserModel();
        }

        /// <summary>
        /// 新建一个学生用户，如果表中有stu_statu为0的数据，
        /// 则将该学号给这个学生，保证不断号
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="birth"></param>
        /// <param name="native"></param>
        public void CreateUser(string name, string genderString, string shortDateString, string native)
        {
            string code = "";//学生编号
            string psw = CommonFunction.MD5Encrypt32("aaaaaa");//默认密码aaaaaa，加密存储
            char gender = (genderString.Equals("男") ? '0' : '1');
            string birth = CommonFunction.DateString8(shortDateString);
            char statu = '1';
            char isAdmin = '0';
            string type = "";
            //string tmp = ",";

            //先查找出最小的被删除的学生号码，被删除statu会被置为0，
            string sqlMinNonCode = "select min(convert(int,STU_CODE)) from TD_Student where STU_STATU='0'";
            
            //所有学生的statu值都为1时，说明没有断号，则找到最大的号码
            string sqlMaxCode = "select max(convert(int,STU_CODE)) from TD_Student";
            
            //无论表里有没有数据，resultList里都有数据
            //有数据时resultList[0]为第一条数据，以此类推
            //无数据时resultList[0]==""，即空字符串
            List<List<string>> resultList = CommonFunction.ExecuteSqlReader(sqlMinNonCode);
            if (resultList[0][0]!="")//有断号
            {
                //从表里挑出的最小被删除学生编号，是int类型，需要转换成"0000"格式的字符串
                code = Convert.ToInt32(resultList[0][0]).ToString("0000");
                type = "update";
                userModel.SaveUser(code,name,psw,gender,birth,native ,statu,isAdmin ,type);
            }
            else//无断号,resultList[0][0]=="";
            {
                resultList = CommonFunction.ExecuteSqlReader(sqlMaxCode);
                if (resultList[0][0]!="")//表里有数据，已存在学生
                {
                    code = (Convert.ToInt32(resultList[0][0].ToString()) + 1).ToString("0000");
                    type = "insert";
                    userModel.SaveUser(code, name, psw, gender, birth, native, statu, isAdmin, type);
                }
                else//表里无数据,resultList[0][0]=="";
                {
                    code = "0001";
                    type = "insert";
                    userModel.SaveUser(code, name, psw, gender, birth, native, statu, isAdmin, type);
                }
            }
        }
        public void ShowUserInfo(string userCode)
        {
            User user = userModel.load(userCode);
            userView.ShowUser(user);
            userView.ShowUserScore(user.GetCourse());
        }
        public void SaveUserInfoChange()
        {
            User user = userView.GetUser();
            char gender = (user.Gender.Equals("男") ? '0' : '1');
            
            string sqlSaveInfoChange = "update TD_Student set STU_NAME=N'"+user.Name+"',STU_GENDER='"+
                gender+"',STU_BIRTH='"+user.Birth+"',STU_NATIVE=N'"+user.Native+"' where STU_CODE='"+user.Code+"'";
            CommonFunction.ExecuteSave(sqlSaveInfoChange);
        }
        public void SaveUserScoreAlter()
        {
            //获得列表上用户从左至右的课程编号、用户编号、成绩及课程名称
            List<List<string>> scoreInfo = userView.GetScore();

            int alterSuccessCount = 0;//成功录入成绩的课程门数
            string hasAlter = "";//录入成功的课程名称
            int isAlterOne = 0;//用来标记一门课是否成功录入成绩，==0表示不成功

            foreach(List<string> scoreItem in scoreInfo)
            {
                //检测输入是否为数字
                if (!CommonFunction.IsNumString(scoreItem[2], "decimal"))
                {
                    MessageBox.Show("请正确输入成绩！");
                    return;
                }
                string sqlUpdateScore = "update TD_Score set SOR_GRADE="+scoreItem[2]+" where SOR_COUCODE='"+
                    scoreItem[0]+"' and SOR_STUCODE='"+scoreItem[1]+"'";
                isAlterOne = CommonFunction.ExecuteSqlNonQuery(sqlUpdateScore);
                if( isAlterOne == 0)
                {
                    MessageBox.Show("成功录入" + alterSuccessCount + "门成绩：\n" + hasAlter + "\n其他成绩录入失败。");
                    return;
                }
                alterSuccessCount++;
                hasAlter += (scoreItem[3] + "  ");
            }
            MessageBox.Show("成功录入" + alterSuccessCount + "门成绩：\n" + hasAlter);
        }
        public void SavePswChange(string userCode,string pswText1,string pswText2)
        {
            if(pswText1.Equals(pswText2))
            {
                string psw = CommonFunction.MD5Encrypt32(pswText1);
                string sqlPswChange = "update TD_Student set STU_PASSWORD='"+psw+"'";
                CommonFunction.ExecuteSave(sqlPswChange);
            }
            else
            {
                MessageBox.Show("两次输入不一致，请检查输入！");
            }
        }
        public bool[] SignIn(string userCode,string psw)
        {
            string sqlSignIn = "select STU_PASSWORD,STU_IS_ADMIN from TD_Student where STU_CODE='"+userCode+"'";
            List<List<string>> pswString = CommonFunction.ExecuteSqlReader(sqlSignIn);
            if(pswString.Count==0)
            {
                bool[] noUser = { false,false};
                return noUser;
            }
            bool isSignIn = ((CommonFunction.MD5Encrypt32(psw).Equals(pswString[0][0])) ? true : false);
            bool isAdmin = ((pswString[0][1].Equals("1")) ? true : false);
            bool[] signInResult = { isSignIn, isAdmin };
            return signInResult;
        }
        public DataTable AllCourseTable()
        {
            DataTable courseDT = new DataTable();
            //编号、姓名列
            DataColumn codeDC = new DataColumn("编号",System.Type.GetType("System.String"));
            courseDT.Columns.Add(codeDC);
            DataColumn nameDC = new DataColumn("姓名",System.Type.GetType("System.String"));
            courseDT.Columns.Add(nameDC);
            //课程列
            string sqlGetCourseInfo = "select COU_NAME from TD_Course";
            List<List<string>> courseInfo = CommonFunction.ExecuteSqlReader(sqlGetCourseInfo);
            foreach(List<string> courseItem in courseInfo)
            {
                DataColumn courseDC = new DataColumn(courseItem[0], System.Type.GetType("System.Decimal"));
                courseDT.Columns.Add(courseDC);
            }

            //成绩合计列、学分合计列
            DataColumn scoreTotalDC = new DataColumn("成绩合计",System.Type.GetType("System.Decimal"));
            courseDT.Columns.Add(scoreTotalDC);
            DataColumn creditTotalDC = new DataColumn("学分合计",System.Type.GetType("System.Int32"));
            courseDT.Columns.Add(creditTotalDC);

            //添加行
            //查找所有的人，有多少人就有多少行
            string sqlAllUserCode = "select STU_CODE,STU_NAME from TD_Student where STU_CODE!='0000'";
            List<List<string>> allUserCode = CommonFunction.ExecuteSqlReader(sqlAllUserCode);
            foreach(List<string> userCodeItem in allUserCode)
            {
                DataRow row = courseDT.NewRow();
                row[0] = userCodeItem[0];//编号列
                row[1] = userCodeItem[1];//姓名列

                decimal scoreTotal = 0;//成绩合计
                int creditTotal = 0;//学分合计

                //查找该用户的所有成绩
                string sqlScore = "select SOR_COUCODE,SOR_GRADE from TD_Score where SOR_STUCODE='"+userCodeItem[0]+"'";
                List<List<string>> scoreList = CommonFunction.ExecuteSqlReader(sqlScore);
                foreach(List<string> scoreItem in scoreList)//把成绩赋值到该行对应的列
                {
                    //确定每一个成绩对应的课程名字，即应该赋值到哪一列
                    string sqlCourseName = "select COU_NAME,STU_CREDIT from TD_Course where COU_CODE='"+scoreItem[0]+"'";
                    List<List<string>> courseName = CommonFunction.ExecuteSqlReader(sqlCourseName);//课程名称为courseName[0][0]
                    row[courseName[0][0]] = Convert.ToDecimal(scoreItem[1]);

                    scoreTotal += Convert.ToDecimal(scoreItem[1]);//成绩合计
                    //计算该门课程学分
                    creditTotal += (Convert.ToDecimal(scoreItem[1]) < 60 ? 0 : Convert.ToInt32(courseName[0][1]));
                }
                //成绩合计列
                row["成绩合计"] = scoreTotal;
                row["学分合计"] = creditTotal;
                //学分合计列

                courseDT.Rows.Add(row);
            }
            
            return courseDT;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseDT"></param>
        /// <param name="minScore"></param>
        /// <param name="maxScore"></param>
        /// <param name="screenColumnName">要过滤的列名</param>
        /// <returns></returns>
        public DataView ScreenScore(DataTable courseDT,decimal minScore,decimal maxScore,string screenColumnName)
        {
            DataView dataView = new DataView(courseDT);
            string str = screenColumnName + " >= " + minScore + " and " + screenColumnName + " <= " + maxScore;
            dataView.RowFilter = str;
            return dataView;
        }
        /// <summary>
        /// 给管理员界面的DataGridView返回一个datatable
        /// </summary>
        /// <returns></returns>
        public DataTable AllUserTable()
        {
            DataTable allUserDT = new DataTable();
            //DataTable添加列
            DataColumn codeDC = new DataColumn("编号", System.Type.GetType("System.String"));
            allUserDT.Columns.Add(codeDC);
            DataColumn nameDC = new DataColumn("姓名", System.Type.GetType("System.String"));
            allUserDT.Columns.Add(nameDC);
            DataColumn genderDC = new DataColumn("性别", System.Type.GetType("System.String"));
            allUserDT.Columns.Add(genderDC);
            DataColumn nativeDC = new DataColumn("籍贯", System.Type.GetType("System.String"));
            allUserDT.Columns.Add(nativeDC);
            //添加行
            //先找出除管理员所有的用户，有多少用户就有多少行
            string sqlAllUser =
                "select STU_CODE,STU_NAME,STU_GENDER,STU_NATIVE from TD_Student where STU_IS_ADMIN!='1'";
            List<List<string>> allUserList = CommonFunction.ExecuteSqlReader(sqlAllUser);
            foreach(List<string> userItem in allUserList)
            {
                DataRow row = allUserDT.NewRow();
                row[0] = userItem[0];
                row[1] = userItem[1];
                row[2] = (userItem[2].Equals("0") ? "男" : "女");
                row[3] = userItem[3];
                allUserDT.Rows.Add(row);
            }
            return allUserDT;
        }
    }
}
