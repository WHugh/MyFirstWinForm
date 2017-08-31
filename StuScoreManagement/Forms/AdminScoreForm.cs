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
    public partial class AdminScoreForm : Form
    {
        private UserPresenter presenter = new UserPresenter();
        private DataTable allCourseDT;
        public AdminScoreForm()
        {
            InitializeComponent();
            //allCourseDT = presenter.AllCourseTable();
        }

        private void AdminScoreForm_Load(object sender, EventArgs e)
        {
            allScoreDataGridView.ReadOnly = true;
            allCourseDT = presenter.AllCourseTable();
            allScoreDataGridView.DataSource = allCourseDT;
        }

        private void screenBt_Click(object sender, EventArgs e)
        {
            ScreenScoreForm screenForm = new ScreenScoreForm(allCourseDT, "all", "");
            if(screenForm.ShowDialog() == DialogResult.OK)
            {
                allScoreDataGridView.DataSource = screenForm.dv;
            }
        }

        private void viewBt_Click(object sender, EventArgs e)
        {
            if (allScoreDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要查看的行。");
                return;
            }
            string userCode = allScoreDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取到选中行的userCode
            StudentMainForm stuMainForm = new StudentMainForm(userCode, true,"view");//以管理员查看方式打开界面
            stuMainForm.ShowDialog();
        }

        private void alterBt_Click(object sender, EventArgs e)
        {
            if (allScoreDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要修改的行。");
                return;
            }
            string userCode = allScoreDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取到选中行的userCode
            StudentMainForm stuMainForm = new StudentMainForm(userCode, true,"edit");//以管理员编辑方式打开界面
            stuMainForm.ShowDialog();
            AdminScoreForm_Load(null, null);
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            SearchStuForm searchForm = new SearchStuForm(allCourseDT);
            if(searchForm.ShowDialog() == DialogResult.OK)
            {
                allScoreDataGridView.DataSource = searchForm.dv;
            }
        }

        private void ResetBt_Click(object sender, EventArgs e)
        {
            allScoreDataGridView.DataSource = allCourseDT;
        }

        private void AdminScoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        
    }
}
