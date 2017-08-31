using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuScoreManagement
{
    public interface IUserView
    {
        void ShowUser(User user);
        void ShowUserScore(List<Course> course);
        User GetUser();
        List<List<string>> GetScore();
    }
}
