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
    public partial class AdminStuForm : Form
    {
        private DataTable allUserDT;
        private UserPresenter presenter;
        public AdminStuForm()
        {
            InitializeComponent();
            presenter = new UserPresenter();
        }

        private void AdminStuForm_Load(object sender, EventArgs e)
        {
            allUserDT = presenter.AllUserTable();
            AllUserDataGridView.DataSource = allUserDT;
        }

        private void AdminStuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ViewBt_Click(object sender, EventArgs e)
        {
            if (AllUserDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要查看的行。");
                return;
            }
            string userCode = AllUserDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取到选中行的userCode
            StudentMainForm stuMainForm = new StudentMainForm(userCode, true, "view");//以管理员查看方式打开界面
            stuMainForm.ShowDialog();
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            if (AllUserDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要编辑的行。");
                return;
            }
            string userCode = AllUserDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取到选中行的userCode
            StudentMainForm stuMainForm = new StudentMainForm(userCode, true, "edit");//以管理员编辑方式打开界面
            stuMainForm.ShowDialog();
            AdminStuForm_Load(null, null);
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (AllUserDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要删除的行。");
                return;
            }
            string userCode = AllUserDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            //删除student表里该学生的数据
            string sqlDeleteUser = "delete from TD_Student where STU_CODE='" + userCode + "'";
            //判断score表里有没有该学生对应的成绩
            string sqlIsHasScore = "select SOR_STUCODE from TD_Score where SOR_STUCODE='" + userCode + "'";
            //如果有则删除score表里对应的成绩
            string sqlDeleteScore = "delete from TD_Score where SOR_STUCODE='" + userCode + "'";
            if(CommonFunction.ExecuteSqlReader(sqlIsHasScore).Count > 0)//该学生有成绩，有选的课程
            {
                if(CommonFunction.ExecuteSqlNonQuery(sqlDeleteUser) > 0 && 
                    CommonFunction.ExecuteSqlNonQuery(sqlDeleteScore) > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else//没有选课，直接删除user表的数据即可
            {
                if(CommonFunction.ExecuteSqlNonQuery(sqlDeleteUser) > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            AdminStuForm_Load(null, null);//重新加载界面
        }

        private void CreateBt_Click(object sender, EventArgs e)
        {
            CreateStuForm createStuForm = new CreateStuForm();
            createStuForm.ShowDialog();
            AdminStuForm_Load(null, null);//重新加载界面
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            SearchStuForm searchForm = new SearchStuForm(allUserDT);
            if(searchForm.ShowDialog() == DialogResult.OK)
            {
                AllUserDataGridView.DataSource = searchForm.dv;
            }
        }

        private void ResetBt_Click(object sender, EventArgs e)
        {
            AllUserDataGridView.DataSource = allUserDT;
        }



        //代码写在该行以上
    }
}
