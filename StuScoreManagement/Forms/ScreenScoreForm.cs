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
    public partial class ScreenScoreForm : Form
    {
        private string type = "";//筛选固定单门成绩，还是筛选所有课程中的一门成绩
        private string courseName = "";//筛选固定单门成绩时，要传入课程名称,实际意义为要过滤的列名
        private List<string> allCourse;
        UserPresenter presenter;
        public DataView dv;
        private DataTable courseCodeDT;
        public ScreenScoreForm()
        {
            InitializeComponent();
        }
        public ScreenScoreForm(DataTable courseCodeDT, string type,string courseName)
        {
            InitializeComponent();
            this.type = type;
            this.courseName = courseName;
            presenter = new UserPresenter();
            this.courseCodeDT = courseCodeDT;
        }
        private void ScreenScore_Load(object sender, EventArgs e)
        {
            this.allCourse = GetAllCourseName();
            //给NameComboBox添加元素
            foreach(string courseName in allCourse)
            {
                NameComboBox.Items.Add(courseName);
            }
            if(this.type.Equals("one"))
            {
                NameComboBox.Enabled = false;
                NameComboBox.Text = courseName;
            }
            if(this.type.Equals("all"))
            {

            }
        }

        public List<string> GetAllCourseName()
        {
            List<string> allCourseName = new List<string>();
            //找出所有的课程名称
            List<List<string>> allNameList = CommonFunction.ExecuteSqlReader("select COU_NAME from TD_Course");
            foreach(List<string> nameItem in allNameList)
            {
                allCourseName.Add(nameItem[0]);
            }
            return allCourseName;
        }

        private void ScreenBt_Click(object sender, EventArgs e)
        {
            if(type.Equals("one"))
            {
                if (MinTB.Text.Equals("") || MaxTB.Text.Equals("") ||
                    !CommonFunction.IsNumString(MinTB.Text, "decimal") ||
                    !CommonFunction.IsNumString(MaxTB.Text, "decimal"))
                {
                    MessageBox.Show("请正确输入成绩！");
                    return;
                }
                dv = presenter.ScreenScore(courseCodeDT, Convert.ToDecimal(MinTB.Text), Convert.ToDecimal(MaxTB.Text), "成绩");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            if(type.Equals("all"))
            {
                if(NameComboBox.Text.Equals(""))
                {
                    MessageBox.Show("请选择一门课程！");
                    return;
                }
                if (MinTB.Text.Equals("") || MaxTB.Text.Equals("")||
                    !CommonFunction.IsNumString(MinTB.Text,"decimal")||
                    !CommonFunction.IsNumString(MaxTB.Text,"decimal"))
                {
                    MessageBox.Show("请正确输入成绩！");
                    return;
                }
                
                dv = presenter.ScreenScore(courseCodeDT, Convert.ToDecimal(MinTB.Text), Convert.ToDecimal(MaxTB.Text), NameComboBox.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
       
    }
}
