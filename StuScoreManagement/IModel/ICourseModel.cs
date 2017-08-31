using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuScoreManagement
{
    public interface ICourseModel
    {
        void saveCourse(string courseCode,string courseName,int stuCredit,string type);
        Course load(string courseCode);//查
    }
}
