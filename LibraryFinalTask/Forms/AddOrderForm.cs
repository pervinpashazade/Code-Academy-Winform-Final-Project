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
    public partial class AddOrderForm : Form
    {
        private readonly LibraryDbContext _db;
        private Customer _selectedCustomer;
        private Book _selectedBook;
        public AddOrderForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillCustomers();
            FillBooks();
        }

        #region Methods

        public void FillCustomers()
        {
            dgvCustomers.Rows.Clear();

            List<Customer> customers = _db.Customers.ToList();

            foreach (var item in customers)
            {
                dgvCustomers.Rows.Add(item.Id, item.Name, item.Surname,
                                              item.Email, item.Phone);
            }
        }

        public void FillBooks()
        {
            dgvBooks.Rows.Clear();

            List<Book> books = _db.Books.Include("Genre")
                                        .Include("Author")
                                        .Include("Language")
                                        .ToList();

            foreach (var item in books)
            {
                dgvBooks.Rows.Add(item.Id, item.Name, 
                                          item.Author.Name + " " + item.Author.Surname,
                                          item.PriceSale, item.PriceRent, 
                                          item.Count);
            }
        }

        #endregion


        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            //panelCreateOrder.Hide();
        }

        private void IcnSearchCustCrtOrder_Click(object sender, EventArgs e)
        {
            if (cmbSrchFilterCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select customer search filter!", "Oops, Warning!");
                return;
            }

            if (string.IsNullOrEmpty(txtSearchCustCrtOrder.Text))
            {
                MessageBox.Show("Input can't be empty for search somethings!", "Oops, Error!");
            }
        }

        private void IcnClearTxtSearchCust_Click(object sender, EventArgs e)
        {
            txtSearchCustCrtOrder.Clear();
        }

        private void IcnSearchBookCrtOrder_Click(object sender, EventArgs e)
        {
            if (cmbSrchFilterBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select book search filter!", "Oops, Warning!");
                return;
            }

            if (string.IsNullOrEmpty(txtSearchBookCrtOrder.Text))
            {
                MessageBox.Show("Input can't be empty for search somethings!", "Oops, Error!");
            }
        }


        //dgv customers row header double click
        private void DgvCustomersCrtOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int customerId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedCustomer = _db.Customers.Find(customerId);

            lblCustomer.Text = _selectedCustomer.Name + " " + _selectedCustomer.Surname;
            lblCustomerId.Text = "# " + _selectedCustomer.Id;
            lblCustomerEmail.Text = _selectedCustomer.Email;
            lblCustomerPhone.Text = _selectedCustomer.Phone;
        }

        private void DgvBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int bookId = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedBook = _db.Books.Find(bookId);

            if (rBtnRentOrder.Checked == true)
            {
                lblSlctBookName.Text = _selectedBook.Name;
                lblBookPrice.Text = _selectedBook.PriceRent.ToString() + "   AZN";
            }

            if (rBtnSaleOrder.Checked == true)
            {
                lblSlctBookName.Text = _selectedBook.Name;
                lblBookPrice.Text = _selectedBook.PriceSale.ToString() + "   AZN";
            }

        }


        private void RBtnSaleOrder_CheckedChanged(object sender, EventArgs e)
        {
            rBtnSaleOrder.ForeColor = Color.FromArgb(133, 240, 240);
            rBtnRentOrder.ForeColor = Color.WhiteSmoke;
            lblReturnDate.Hide();
            dateReturnOrder.Hide();

            if (_selectedBook != null)
            {
                lblBookPrice.Text = _selectedBook.PriceSale.ToString() + "   AZN";
            }
        }

        private void RBtnRentOrder_CheckedChanged(object sender, EventArgs e)
        {
            rBtnRentOrder.ForeColor = Color.FromArgb(133, 240, 240);
            rBtnSaleOrder.ForeColor = Color.WhiteSmoke;

            lblReturnDate.Show();
            dateReturnOrder.Show();

            if (_selectedBook != null)
            {
                lblBookPrice.Text = _selectedBook.PriceRent.ToString() + "   AZN";
            }

        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            dateReturnOrder.MinDate = DateTime.Now;
            dateReturnOrder.MaxDate = DateTime.Now.AddDays(15);
        }
    }
}
