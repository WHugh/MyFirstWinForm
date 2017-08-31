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
    public partial class ChangePswForm : Form
    {
        private UserPresenter presenter = new UserPresenter();
        private string userCode;
        public ChangePswForm()
        {
            InitializeComponent();
        }
        public ChangePswForm(string userCode)
        {
            InitializeComponent();
            this.userCode = userCode;
        }

        private void ChangePsw_Load(object sender, EventArgs e)
        {

        }

        private void savePswChangeBt_Click(object sender, EventArgs e)
        {
            presenter.SavePswChange(userCode, newPswTB1.Text, newPswTB2.Text);
            this.Close();
        }
    }
}
