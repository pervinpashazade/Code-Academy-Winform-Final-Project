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
    public partial class BooksForm : Form
    {
        public BooksForm()
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

            if (cmbGenre.SelectedItem == null)
            {
                lblErrorGenre.Show();
            }
            else
            {
                lblErrorGenre.Hide();
            }

            if (cmbAuthor.SelectedItem == null)
            {
                lblErrorAuthor.Show();
            }
            else
            {
                lblErrorAuthor.Hide();
            }

            if (cmbLanguage.SelectedItem == null)
            {
                lblErrorLang.Show();
            }
            else
            {
                lblErrorLang.Hide();
            }

            if (ntxtSale.Value == 0)
            {
                lblErrorSale.Show();
            }
            else
            {
                lblErrorSale.Hide();
            }

            if (ntxtRent.Value == 0)
            {
                lblErrorRent.Show();
            }
            else
            {
                lblErrorRent.Hide();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            cmbGenre.DataSource = null;
            cmbAuthor.DataSource = null;
            cmbLanguage.DataSource = null;
            ntxtSale.Value = 0;
            ntxtRent.Value = 0;

            lblErrorName.Hide();
            lblErrorGenre.Hide();
            lblErrorAuthor.Hide();
            lblErrorLang.Hide();
            lblErrorSale.Hide();
            lblErrorRent.Hide();
        }
    }
}
