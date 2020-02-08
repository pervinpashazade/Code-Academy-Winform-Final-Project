using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFinalTask.Forms
{
    public partial class AddLanguageForm : Form
    {
        public AddLanguageForm()
        {
            InitializeComponent();
        }

        private void IconSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show("Input can't be empty for search somethings!", "Oops, Error!");
                }
            }
        }

        private void IconBackspace_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorName.Show();
            }
            else
            {
                lblErrorName.Hide();
            }

            if (!(rBtnStatusActive.Checked) && !(rBtnStatusDisabled.Checked))
            {
                lblErrorStatus.Show();
            }
            else
            {
                lblErrorStatus.Hide();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;
            txtSearch.Clear();

            lblErrorName.Hide();
            lblErrorStatus.Hide();
        }
    }
}
