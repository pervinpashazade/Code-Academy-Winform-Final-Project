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
    public partial class CustomersForm : Form
    {
        private LibraryDbContext _db;
        private Customer _selectedCustomer;
        public CustomersForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillCustomers();
        }

        #region fillMethods

        public void FillCustomers()
        {
            dgvCustomers.Rows.Clear();

            List<Customer> customers = _db.Customers.ToList();

            foreach (var item in customers)
            {
                dgvCustomers.Rows.Add(item.Id, item.Name, item.Surname, item.Email,
                                      item.Phone ,item.Status ? "Active" : "Disabled");
            }
        }

        public void ResetForm()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            txtSearch.Clear();

            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;

            lblErrorName.Hide();
            lblErrorSurname.Hide();
            lblErrorEmail.Hide();
            lblErrorPhone.Hide();
            lblErrorStatus.Hide();

            lblErrorSearchFilter.Hide();

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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
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
            //validation end

            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text)
                                                    && !string.IsNullOrEmpty(txtEmail.Text)
                                                    && !string.IsNullOrEmpty(txtPhone.Text)
                                                    && (rBtnStatusActive.Checked ||
                                                    rBtnStatusDisabled.Checked))
            {
                Customer customer = new Customer();

                customer.Name = txtName.Text;
                customer.Surname = txtSurname.Text;
                customer.Email = txtEmail.Text;
                customer.Phone = txtPhone.Text;
                customer.Status = rBtnStatusActive.Checked ? true : false;
                customer.CreatedAt = DateTime.Now;

                _db.Customers.Add(customer);
                _db.SaveChanges();

                MessageBox.Show("Customer added : " + txtName.Text + " " + txtSurname.Text, "New Customer");

                ResetForm();
                FillCustomers();
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
            //validation end


            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text)
                                                    && !string.IsNullOrEmpty(txtEmail.Text)
                                                    && !string.IsNullOrEmpty(txtPhone.Text)
                                                    && (rBtnStatusActive.Checked ||
                                                    rBtnStatusDisabled.Checked))
            {
                DialogResult dialog = MessageBox.Show("Selected customer will be updated", "Update Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    _selectedCustomer.Name = txtName.Text;
                    _selectedCustomer.Surname = txtSurname.Text;
                    _selectedCustomer.Email = txtEmail.Text;
                    _selectedCustomer.Phone = txtPhone.Text;
                    _selectedCustomer.Status = rBtnStatusActive.Checked ? true : false;

                    _db.SaveChanges();

                    FillCustomers();
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
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Select customer", "Error");
                return;
            }

            DialogResult dialog = MessageBox.Show("Selected customer will be deleted permanently", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                _db.Customers.Remove(_selectedCustomer);

                _db.SaveChanges();

                FillCustomers();
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
        private void IconBackspace_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }


        private void DgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (lblErrorName.Visible || lblErrorSurname.Visible || lblErrorStatus.Visible)
            //{
            //    lblErrorName.Hide();
            //    lblErrorSurname.Hide();
            //    lblErrorStatus.Hide();
            //}
            ResetForm();

            int id = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedCustomer = _db.Customers.Find(id);

            lblTitleSelected.Show();
            lblSelectedFullname.Show();
            lblSelectedFullname.Text = _selectedCustomer.Name + " " + _selectedCustomer.Surname;

            btnUpdate.Show();
            btnDelete.Show();

            txtName.Text = _selectedCustomer.Name;
            txtSurname.Text = _selectedCustomer.Surname;
            txtEmail.Text = _selectedCustomer.Email;
            txtPhone.Text = _selectedCustomer.Phone;
            if (_selectedCustomer.Status == false)
            {
                rBtnStatusDisabled.Checked = true;
            }
            else
            {
                rBtnStatusActive.Checked = true;
            }

            btnCreate.Enabled = false;
        }

        private void IconGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
