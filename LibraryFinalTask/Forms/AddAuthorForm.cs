using System;
using System.Collections.Generic;
using LibraryFinalTask.Data;
using System.Windows.Forms;
using LibraryFinalTask.Models;

namespace LibraryFinalTask.Forms
{
    public partial class AddAuthorForm : Form
    {
        private readonly LibraryDbContext _db;
        public AddAuthorForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //validation start
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
                lblerrorSurname.Show();
            }
            else
            {
                lblerrorSurname.Hide();
            }

            if (!(rBtnStatusActive.Checked) && !(rBtnStatusDisabled.Checked))
            {
                lblErrorStatus.Show();
            }
            else
            {
                lblErrorStatus.Hide();
            }
            //validation end

            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) 
                                                    && !string.IsNullOrEmpty(txtSurname.Text)
                                                    && (rBtnStatusActive.Checked || 
                                                        rBtnStatusDisabled.Checked))
            {
                Author author = new Author();

                author.Name = txtName.Text;
                author.Surname = txtSurname.Text;
                author.Status = rBtnStatusActive.Checked ? true : false;
                author.CreatedAt = DateTime.Now;

                _db.Authors.Add(author);
                _db.SaveChanges();

                MessageBox.Show("Author added : " + txtName.Text + " " + txtSurname.Text, "New Author");
                txtName.Clear();
                txtSurname.Clear();
                rBtnStatusActive.Checked = false;
                rBtnStatusDisabled.Checked = false;
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtSearch.Clear();
            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;

            lblErrorName.Hide();
            lblerrorSurname.Hide();
            lblErrorStatus.Hide();
        }

        private void IconBackspace_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
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
    }
}
