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
    public partial class SearchStuForm : Form
    {
        private DataTable dt;
        public DataView dv;
        public SearchStuForm()
        {
            InitializeComponent();
        }
        public SearchStuForm(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }
        private void SearchStuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            string sqlSearch = "select STU_CODE from TD_Student where STU_CODE='"+UserCodeTB.Text+"'";
            if(CommonFunction.ExecuteSqlReader(sqlSearch).Count == 0)
            {
                MessageBox.Show("查无此人！");
                return;
            }
            dv = new DataView(dt);
            string str = "编号=" + UserCodeTB.Text;
            dv.RowFilter = str;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
