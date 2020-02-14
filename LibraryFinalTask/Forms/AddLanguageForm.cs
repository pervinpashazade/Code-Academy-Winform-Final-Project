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
    public partial class AddLanguageForm : Form
    {
        private LibraryDbContext _db;
        private Language _selectedLanguage;

        public AddLanguageForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillLanguages();
        }

        #region fillMethods

        public void FillLanguages()
        {
            dgvLanguages.Rows.Clear();

            List<Language> languages = _db.Languages.ToList();

            foreach (var item in languages)
            {
                dgvLanguages.Rows.Add(item.Id, item.Name, item.Status ? "Active" : "Disabled");
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

        #region btnClicks

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
                Language language = new Language();

                language.Name = txtName.Text;
                language.Status = rBtnStatusActive.Checked ? true : false;
                language.CreatedAt = DateTime.Now;

                _db.Languages.Add(language);
                _db.SaveChanges();

                MessageBox.Show("Language added : " + txtName.Text, "New Language");
                txtName.Clear();
                rBtnStatusActive.Checked = false;
                rBtnStatusDisabled.Checked = false;

                FillLanguages();
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
                DialogResult dialog = MessageBox.Show("Selected language will be updated", "Update Genre", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    _selectedLanguage.Name = txtName.Text;
                    _selectedLanguage.Status = rBtnStatusActive.Checked ? true : false;

                    _db.SaveChanges();

                    FillLanguages();
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
            if (_selectedLanguage == null)
            {
                MessageBox.Show("Select language", "Error");
                return;
            }

            DialogResult dialog = MessageBox.Show("Selected language will be deleted permanently", "Delete Position", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                _db.Languages.Remove(_selectedLanguage);

                _db.SaveChanges();

                FillLanguages();
                ResetForm();
            }
            else
            {
                ResetForm();
            }
        }

        #endregion

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


        private void DgvLanguages_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lblErrorName.Visible || lblErrorStatus.Visible)
            {
                lblErrorName.Hide();
                lblErrorStatus.Hide();
            }

            int id = Convert.ToInt32(dgvLanguages.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedLanguage = _db.Languages.Find(id);

            lblTitleSelected.Show();
            lblSelectedFullname.Show();
            lblSelectedFullname.Text = _selectedLanguage.Name;

            btnUpdate.Show();
            btnDelete.Show();

            txtName.Text = _selectedLanguage.Name;
            if (_selectedLanguage.Status == false)
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
