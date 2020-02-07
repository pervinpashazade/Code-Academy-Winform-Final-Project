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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
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

            if (cmbPositions.SelectedItem == null)
            {
                lblErrorPositions.Show();
            }
            else
            {
                lblErrorPositions.Hide();
            }

            if (ntxtSallary.Value == 0)
            {
                lblErrorSallary.Show();
            }
            else
            {
                lblErrorSallary.Hide();
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
            cmbPositions.DataSource = null;
            ntxtSallary.Value = 0;
            txtEmail.Clear();
            txtPhone.Clear();
            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;

            lblErrorName.Hide();
            lblErrorSurname.Hide();
            lblErrorPositions.Hide();
            lblErrorSallary.Hide();
            lblErrorEmail.Hide();
            lblErrorPhone.Hide();
            lblErrorStatus.Hide();

            txtSearch.Clear();
        }

        private void IconSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Input can't be empty for search somethings!", "Oops, Error!");
                return;
            }
        }
    }
}
