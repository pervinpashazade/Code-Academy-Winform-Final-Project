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
    public partial class AddPositionForm : Form
    {
        private LibraryDbContext _db;
        private Position _selectedPosition;

        public AddPositionForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillPositions();
        }

        #region fillMethods

        public void FillPositions()
        {
            dgvPositions.Rows.Clear();

            List<Position> positions = _db.Positions.ToList();

            foreach (var item in positions)
            {
                dgvPositions.Rows.Add(item.Id, item.Name, item.Status ? "Active" : "Disabled");
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
                Position position = new Position();

                position.Name = txtName.Text;
                position.Status = rBtnStatusActive.Checked ? true : false;
                position.CreatedAt = DateTime.Now;

                _db.Positions.Add(position);
                _db.SaveChanges();

                MessageBox.Show("Position added : " + txtName.Text, "New Position");
                txtName.Clear();
                rBtnStatusActive.Checked = false;
                rBtnStatusDisabled.Checked = false;

                FillPositions();
            }

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
                DialogResult dialog = MessageBox.Show("Selected position will be updated", "Update Position", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    _selectedPosition.Name = txtName.Text;
                    _selectedPosition.Status = rBtnStatusActive.Checked ? true : false;

                    _db.SaveChanges();

                    FillPositions();
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
            if (_selectedPosition == null)
            {
                MessageBox.Show("Select position", "Error");
                return;
            }

            DialogResult dialog = MessageBox.Show("Selected position will be deleted permanently", "Delete Position", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                _db.Positions.Remove(_selectedPosition);

                _db.SaveChanges();

                FillPositions();
                ResetForm();
            }
            else
            {
                ResetForm();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
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

        private void DgvPositions_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lblErrorName.Visible || lblErrorStatus.Visible)
            {
                lblErrorName.Hide();
                lblErrorStatus.Hide();
            }

            int id = Convert.ToInt32(dgvPositions.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedPosition = _db.Positions.Find(id);

            lblTitleSelected.Show();
            lblSelectedFullname.Show();
            lblSelectedFullname.Text = _selectedPosition.Name;

            btnUpdate.Show();
            btnDelete.Show();

            txtName.Text = _selectedPosition.Name;
            if (_selectedPosition.Status == false)
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
