using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuScoreManagement
{
    public class User
    {
        private string code;
        private string name;
        private string password;
        private string gender;
        private string birth;//生日
        private string native;//籍贯
        private List<Course> course = new List<Course>();
        private string statu;//用户状态，1正常，0被删除
        private string isAdmin;//用户是否为管理员,1是，0否
        public User() { }
        public string Code
        {
            set { this.code = value; }
            get { return this.code; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
        public string Gender
        {
            set { this.gender = value; }
            get { return this.gender; }
        }
        public string Birth
        {
            set { this.birth = value; }
            get { return this.birth; }
        }
        public string Native
        {
            set { this.native = value; }
            get { return this.native; }
        }
        public string Statu
        {
            set { this.statu = value; }
            get { return this.statu; }
        }
        public string IsAdmin
        {
            set { this.isAdmin = value; }
            get { return this.isAdmin; }
        }
        public void AddCourse(Course course)
        {
            this.course.Add(course);
        }
        public List<Course> GetCourse()
        {
            return this.course;
        }
    }
}
