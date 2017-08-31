using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StuScoreManagement
{
    public class CommonFunction
    {
        public static string MD5Encrypt32(string password)
        {
            string psw = "";
            MD5 md5 = MD5.Create();
            // 加密后是一个字节类型的数组
            //需要将传入密码字符串转化为字节数组，这里要注意编码UTF8/Unicode等的选择
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            psw = BitConverter.ToString(s).Replace("-", "");
            return psw;
        }
        /// <summary>
        /// 连接数据库StuScore
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ConnectDB()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                "server=localhost;database=StuScore;uid=wangkang;pwd=aaaaaa";
            return con;
        }
        /// <summary>
        /// 增、删、改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>返回值result>0说明执行成功
        public static int ExecuteSqlNonQuery(string sql)
        {
            SqlConnection con = ConnectDB();
            con.Open();
            SqlCommand sCmd = new SqlCommand(sql,con);
            int result = sCmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// 直接返回stringList二维结果集，不要返回SqlDataReader
        public static List<List<string>> ExecuteSqlReader(string sql)
        {
            SqlConnection con = ConnectDB();
            con.Open();
            SqlCommand sCmd = new SqlCommand(sql, con);
            SqlDataReader sqldr = sCmd.ExecuteReader();
            List<List<string>> result = new List<List<string>>();
            while(sqldr.Read())
            {
                List<string> resultItem = new List<string>();
                //sqldr.VisibleFieldCount  ->  未隐藏的字段的数目
                for (int count = 0; count < sqldr.VisibleFieldCount; count++)
                {
                    resultItem.Add(sqldr[count].ToString());
                }
                result.Add(resultItem);
            }
            sqldr.Close();
            con.Close();
            return result;
        }
        /// <summary>
        /// 将DateTimePicker.toShortDateString得到的字符串（如：2017/8/11）
        /// 转换为8位数字的字符串（如：20170811）
        /// </summary>
        /// <param name="shortDateString"></param>
        /// <returns></returns>
        public static string DateString8(string shortDateString)
        {
            string[] str = shortDateString.Split('/');
            string date = str[0];
            for (int i = 1; i <= 2;i++ )
            {
                if(str[i].Length==1)
                {
                    date = date + "0" + str[i];
                }
                else
                {
                    date = date + str[i];
                }
            }
            return date;
        }
        /// <summary>
        /// 将8位的字符串转化成对应的时间格式字符串
        /// 如19951229 -> 1995.12.29
        /// </summary>
        /// <param name="dateString8"></param>8位的数字字符串
        /// <returns></returns>
        public static string DateStringFormat(string dateString8)
        {
            string dateString = "";
            char[] date = dateString8.ToCharArray();
            int i = 0;
            foreach(char c in date)
            {
                if(i==4||i==6)
                    dateString += ".";
                dateString += c.ToString();
                i++;
            }
            return dateString;
        }
        /// <summary>
        /// 以更新或者插入的方式将数据保存
        /// </summary>
        /// <param name="sqlUpdate"></param>
        /// <param name="sqlInsert"></param>
        /// <param name="type"></param>
        public static void ExecuteSave(string sqlSave)
        {
            if (CommonFunction.ExecuteSqlNonQuery(sqlSave) > 0)
            {
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
            
        }
        /// <summary>
        /// 判断输入框里的内容是否为数字
        /// </summary>
        /// <param name="numString">输入框.Text</param>
        /// <param name="numType">输入的数字类型：int还是decimal</param>
        /// <returns>是数字返回true否则false</returns>
        public static bool IsNumString(string numString,string numType)
        {
            if(numType.Equals("int"))
            {
                int tmp;
                if(!int.TryParse(numString,out tmp))
                {
                    //MessageBox.Show("请正确输入成绩！");
                    return false;
                }
                return true;
            }
            decimal tmp1;
            if (!decimal.TryParse(numString, out tmp1))
            {
                //MessageBox.Show("请正确输入成绩！");
                return false;
            }
            return true;
        }
    }
}
