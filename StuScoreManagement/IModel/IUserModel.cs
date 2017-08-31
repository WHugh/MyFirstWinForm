using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuScoreManagement
{
    public interface IUserModel
    {
        
        void SaveUser(string code,string name,string psw,char gender,
            string birth,string native,char statu,char isAdmin,string type);
        User load(string userCode);//查
    }
}
