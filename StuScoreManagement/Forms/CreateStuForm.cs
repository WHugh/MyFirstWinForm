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
    public partial class CreateStuForm : Form
    {
        private UserPresenter presenter;
        public CreateStuForm()
        {
            InitializeComponent();
            this.presenter = new UserPresenter();
        }

        private void CreateStuForm_Load(object sender, EventArgs e)
        {
            GenderComboBox.Items.Add("男");
            GenderComboBox.Items.Add("女");
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            presenter.CreateUser(NameTB.Text, GenderComboBox.Text, BirthDateTimePicker.Value.ToShortDateString(), NativeTB.Text);
            this.Close();
        }
    }
}
