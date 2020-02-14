using System;
using System.Collections.Generic;
using System.Linq;
using LibraryFinalTask.Data;
using System.Windows.Forms;
using LibraryFinalTask.Models;

namespace LibraryFinalTask.Forms
{
    public partial class AddAuthorForm : Form
    {
        private  LibraryDbContext _db;
        private Author _selectedAuthor;
        public AddAuthorForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillAuthors();
        }

        #region fillMethods

        public void FillAuthors()
        {
            dgvAuthors.Rows.Clear();

            List<Author> authors = _db.Authors.ToList();

            foreach (var item in authors)
            {
                dgvAuthors.Rows.Add(item.Id, item. Name, item.Surname, 
                    item.Status? "Active" : "Disabled");
            }
        }

        public void ResetForm()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtSearch.Clear();
            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;

            lblErrorName.Hide();
            lblErrorSurname.Hide();
            lblErrorStatus.Hide();

            lblTitleSelected.Hide();
            lblSelectedFullname.Text = "";
            lblSelectedFullname.Hide();

            btnUpdate.Hide();
            btnDelete.Hide();

            if (btnCreate.Enabled == false)
            {
                btnCreate.Enabled = true;
            }
        }

        #endregion

        #region buttonClicks

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
                lblErrorSurname.Show();
            }
            else
            {
                lblErrorSurname.Hide();
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

            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtName.Text)
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

                FillAuthors();
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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
                lblErrorSurname.Show();
            }
            else
            {
                lblErrorSurname.Hide();
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
                DialogResult dialog = MessageBox.Show("Selected autor will be updated", "Update Author", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    _selectedAuthor.Name = txtName.Text;
                    _selectedAuthor.Surname = txtSurname.Text;
                    _selectedAuthor.Status = rBtnStatusActive.Checked ? true : false;

                    _db.SaveChanges();

                    FillAuthors();
                    ResetForm();
                }
                else
                {
                    ResetForm();
                }
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Selected autor will be deleted permanently", "Delete Author", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                _db.Authors.Remove(_selectedAuthor);

                _db.SaveChanges();

                FillAuthors();
                ResetForm();
            }
            else
            {
                ResetForm();
            }
        }



        #endregion

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


        private void DgvAuthors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lblErrorName.Visible || lblErrorSurname.Visible || lblErrorStatus.Visible)
            {
                lblErrorName.Hide();
                lblErrorSurname.Hide();
                lblErrorStatus.Hide();
            }

            int id = Convert.ToInt32(dgvAuthors.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedAuthor = _db.Authors.Find(id);

            lblTitleSelected.Show();
            lblSelectedFullname.Show();
            lblSelectedFullname.Text = _selectedAuthor.Name + " " + _selectedAuthor.Surname;

            btnUpdate.Show();
            btnDelete.Show();

            txtName.Text = _selectedAuthor.Name;
            txtSurname.Text = _selectedAuthor.Surname;
            if (_selectedAuthor.Status == false)
            {
                rBtnStatusDisabled.Checked = true;
            }
            else
            {
                rBtnStatusActive.Checked = true;
            }

            btnCreate.Enabled = false;
        }

    }
}
