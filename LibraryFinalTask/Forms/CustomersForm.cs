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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void IconSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchCategory.SelectedIndex == -1)
            {
                lblErrorSearchFilter.Show();
            }
            else
            {
                lblErrorSearchFilter.Hide();
            }

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show("Input can't be empty for search somethings!", "Oops, Error!");
                }
            }
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

            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                lblErrorSurname.Show();
            }
            else
            {
                lblErrorSurname.Hide();
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblErrorEmail.Show();
            }
            else
            {
                lblErrorEmail.Hide();
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                lblErrorPhone.Show();
            }
            else
            {
                lblErrorPhone.Hide();
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
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;

            lblErrorName.Hide();
            lblErrorSurname.Hide();
            lblErrorEmail.Hide();
            lblErrorPhone.Hide();
            lblErrorStatus.Hide();

            cmbSearchCategory.SelectedIndex = -1;
            lblErrorSearchFilter.Hide();
            txtSearch.Clear();
        }
    }
}
