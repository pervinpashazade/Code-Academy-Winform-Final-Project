using LibraryFinalTask.Data;
using LibraryFinalTask.Models;
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
    public partial class AddBookGenreForm : Form
    {
        private LibraryDbContext _db;
        private Genre _selectedGenre;
        public AddBookGenreForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillAuthors();
        }

        #region fillMethods

        public void FillAuthors()
        {
            dgvGenres.Rows.Clear();

            List<Genre> genres = _db.Genres.ToList();

            foreach (var item in genres)
            {
                dgvGenres.Rows.Add(item.Id, item.Name, item.Status ? "Active" : "Disabled");
            }
        }

        public void ResetForm()
        {
            txtName.Clear();
            txtSearch.Clear();
            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;

            lblErrorName.Hide();
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
                                                    && (rBtnStatusActive.Checked ||
                                                        rBtnStatusDisabled.Checked))
            {
                Genre genre = new Genre();

                genre.Name = txtName.Text;
                genre.Status = rBtnStatusActive.Checked ? true : false;
                genre.CreatedAt = DateTime.Now;

                _db.Genres.Add(genre);
                _db.SaveChanges();

                MessageBox.Show("Genre added : " + txtName.Text, "New Genre");
                txtName.Clear();
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

            if (!(rBtnStatusActive.Checked) && !(rBtnStatusDisabled.Checked))
            {
                lblErrorStatus.Show();
            }
            else
            {
                lblErrorStatus.Hide();
            }
            //validation end

            if (!string.IsNullOrEmpty(txtName.Text) && (rBtnStatusActive.Checked ||
                                                        rBtnStatusDisabled.Checked))
            {
                DialogResult dialog = MessageBox.Show("Selected genre will be updated", "Update Genre", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    _selectedGenre.Name = txtName.Text;
                    _selectedGenre.Status = rBtnStatusActive.Checked ? true : false;

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
            DialogResult dialog = MessageBox.Show("Selected genre will be deleted permanently", "Delete Author", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                _db.Genres.Remove(_selectedGenre);

                _db.SaveChanges();

                FillAuthors();
                ResetForm();
            }
            else
            {
                ResetForm();
            }
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

        private void DgvGenres_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lblErrorName.Visible || lblErrorStatus.Visible)
            {
                lblErrorName.Hide();
                lblErrorStatus.Hide();
            }

            int id = Convert.ToInt32(dgvGenres.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedGenre = _db.Genres.Find(id);

            lblTitleSelected.Show();
            lblSelectedFullname.Show();
            lblSelectedFullname.Text = _selectedGenre.Name;

            btnUpdate.Show();
            btnDelete.Show();

            txtName.Text = _selectedGenre.Name;
            if (_selectedGenre.Status == false)
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
