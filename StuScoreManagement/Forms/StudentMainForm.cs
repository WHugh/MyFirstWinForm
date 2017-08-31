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
    public partial class StudentMainForm : Form,IUserView
    {
        private UserPresenter presenter;
        private string userCode;
        private bool isAdmin = false;//是否是管理员打开的这个界面，不同人打开的该界面的效果不同，true表示是管理员打开的界面
        private string type = "";//管理员打开该界面的方式：view或edit
        private bool isAlterScore = false;//为saveBt标识出现在要保存的修改是修改个人信息还是成绩信息，true表示正在修改成绩
        //private int indexRowScore;
        //private int indexRowCredit;

        public StudentMainForm()
        {
            InitializeComponent();
            
        }
        public StudentMainForm(string userCode)
        {
            InitializeComponent();
            this.userCode = userCode;
            
        }
        public StudentMainForm(string userCode,bool isAdmin,string type)
        {
            InitializeComponent();
            this.userCode = userCode;
            this.isAdmin = isAdmin;
            this.type = type;
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {

            presenter = new UserPresenter(this);
            presenter.ShowUserInfo(userCode);
            
            if(isAdmin)
            {
                ChooseCourseBt.Enabled = false;
                DropCourseBt.Enabled = false;
                ChangePswBt.Enabled = false;
                SignOutBt.Enabled = false;
                AlterScoreBt.Enabled = true;
                if(type.Equals("view"))
                {
                    EditUserInfoBt.Enabled = false;
                    AlterScoreBt.Enabled = false;
                }
            }
            
        }
        private void StudentMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void SaveBt_Click(object sender, EventArgs e)
        {
            if(isAlterScore)//保存成绩录入修改
            {
                scoreDataGridView.ReadOnly = true;
                EditUserInfoBt.Enabled = true;
                SaveBt.Enabled = false;
                AlterScoreBt.Enabled = true;
                
                presenter.SaveUserScoreAlter();
            }
            else//保存个人信息修改
            {
                presenter.SaveUserInfoChange();
                NameTB.Enabled = false;
                GenderComboBox.Enabled = false;
                BirthDateTimePicker.Enabled = false;
                NativeTB.Enabled = false;
                SaveBt.Enabled = false;
                EditUserInfoBt.Enabled = true;
                if(isAdmin)
                {
                    AlterScoreBt.Enabled = true;
                }
                else
                {
                    ChooseCourseBt.Enabled = true;
                    DropCourseBt.Enabled = true;
                    ChangePswBt.Enabled = true;
                    SignOutBt.Enabled = true;
                }
            }
            StudentMainForm_Load(null, null);//重新加载界面
        }

        private void ChooseCourseBt_Click(object sender, EventArgs e)
        {
            ChooseCourseForm chooseCourseForm = new ChooseCourseForm(userCode, "choose");
            chooseCourseForm.ShowDialog();
            StudentMainForm_Load(null,null);
        }

        private void DropCourseBt_Click(object sender, EventArgs e)
        {
            ChooseCourseForm chooseCourseForm = new ChooseCourseForm(userCode, "drop");
            chooseCourseForm.ShowDialog();
            StudentMainForm_Load(null, null);
        }

        private void EditUserInfoBt_Click(object sender, EventArgs e)
        {
            //CodeTB.Enabled = true;
            isAlterScore = false;//标识：不是修改成绩
            SaveBt.Enabled = true;
            NameTB.Enabled = true;
            GenderComboBox.Enabled = true;
            BirthDateTimePicker.Enabled = true;
            NativeTB.Enabled = true;
            ChooseCourseBt.Enabled = false;
            DropCourseBt.Enabled = false;
            ChangePswBt.Enabled = false;
            SignOutBt.Enabled = false;
            EditUserInfoBt.Enabled = false;
            AlterScoreBt.Enabled = false;
        }

        private void ChangePswBt_Click(object sender, EventArgs e)
        {
            ChangePswForm changePswForm = new ChangePswForm(userCode);
            changePswForm.ShowDialog();
        }

        void IUserView.ShowUser(User user)
        {
            CodeTB.Text = user.Code;
            NameTB.Text = user.Name;
            GenderComboBox.Items.Add("男");
            GenderComboBox.Items.Add("女");
            if (user.Gender.Equals("男"))
                GenderComboBox.SelectedIndex = 0;
            else
                GenderComboBox.SelectedIndex = 1;
            DateTime birthDT = DateTime.Parse(user.Birth);
            BirthDateTimePicker.Value = birthDT;
            NativeTB.Text = user.Native;
            //throw new NotImplementedException();
        }

        void IUserView.ShowUserScore(List<Course> course)
        {
            scoreDataGridView.Columns.Clear();//为了在选课退课后刷新表格，将表格clear后重写画，重新加载数据

            DataGridViewTextBoxColumn columnCourse = new DataGridViewTextBoxColumn();
            columnCourse.Name = "course";
            columnCourse.HeaderText = "课程";
            columnCourse.SortMode = DataGridViewColumnSortMode.NotSortable;
            scoreDataGridView.Columns.Add(columnCourse);
            int indexRowScore = scoreDataGridView.Rows.Add();
            int indexRowCredit = scoreDataGridView.Rows.Add();
            scoreDataGridView.Rows[indexRowScore].Cells[0].Value = "成绩";
            scoreDataGridView.Rows[indexRowCredit].Cells[0].Value = "学分";

            int i = 1;//课程科目计数，跳出循环时比科目总数大1
            int creditTotal = 0;//学分合计
            decimal scoreTotal = 0;//成绩合计
            foreach (Course cou in course)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = cou.Name;
                column.HeaderText = cou.Name;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                scoreDataGridView.Columns.Add(column);
                scoreDataGridView.Rows[indexRowScore].Cells[i].Value = cou.Score;
                if (cou.Score < 60)
                    cou.Credit = 0;
                scoreDataGridView.Rows[indexRowCredit].Cells[i].Value = cou.Credit;
                creditTotal += cou.Credit;
                scoreTotal += cou.Score;
                i++;
            }
            //合计列
            DataGridViewTextBoxColumn totalColumn = new DataGridViewTextBoxColumn();
            totalColumn.Name = "total";
            totalColumn.HeaderText = "合计";
            totalColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            scoreDataGridView.Columns.Add(totalColumn);
            //合计列赋值
            scoreDataGridView.Rows[indexRowScore].Cells[i].Value = scoreTotal;
            scoreDataGridView.Rows[indexRowCredit].Cells[i].Value = creditTotal;
            //throw new NotImplementedException();
        }

        User IUserView.GetUser()
        {
            User user = new User();
            user.Code = userCode;
            user.Name = NameTB.Text;
            user.Gender = GenderComboBox.Text;
            user.Birth = CommonFunction.DateString8(BirthDateTimePicker.Value.ToShortDateString());
            user.Native = NativeTB.Text;
            return user;
            //throw new NotImplementedException();
        }


        private void SignOutBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);

        }

        private void AlterScoreBt_Click(object sender, EventArgs e)
        {
            isAlterScore = true;//标识：是在修改成绩
            EditUserInfoBt.Enabled = false;
            SaveBt.Enabled = true;
            AlterScoreBt.Enabled = false;
            //scoreDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;//鼠标单击修改
            scoreDataGridView.ReadOnly = false;
            scoreDataGridView.Rows[1].ReadOnly = true;
            scoreDataGridView.Columns[0].ReadOnly = true;
            scoreDataGridView.Columns[scoreDataGridView.Columns.Count-1].ReadOnly = true;//写Columns["合计"]貌似无法识别，用数字索引

        }

        List<List<string>> IUserView.GetScore()
        {
            //存放该用户的列表上从左至右所有课程的编号、用户编号、成绩及课程名称
            List<List<string>> scoreInfo = new List<List<string>>();

            for(int i = 1;i <= (scoreDataGridView.Columns.Count-2);i++)
            {
                //找到第i列的课程的编号
                string sqlCourseCode =
                    "select COU_CODE from TD_Course where COU_NAME=N'"+scoreDataGridView.Columns[i].HeaderText+"'";
                string courseCode = CommonFunction.ExecuteSqlReader(sqlCourseCode)[0][0];
                
                List<string> scoreItem = new List<string>();//存放第i列的课程编号、用户编号、成绩及课程名称
                scoreItem.Add(courseCode);//scoreItem[0]课程编号
                scoreItem.Add(userCode);//scoreItem[1]用户编号
                scoreItem.Add(scoreDataGridView.Rows[0].Cells[i].Value.ToString());//scoreItem[2]课程成绩
                scoreItem.Add(scoreDataGridView.Columns[i].HeaderText);//scoreItem[3]课程名称
                
                //把第i列的课程编号、用户编号、成绩及课程名称加到scoreInfo里
                scoreInfo.Add(scoreItem);
            }
            return scoreInfo;
            //throw new NotImplementedException();
        }

        
    }
}
