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
        private Order _currentOrder;
        private OrderItem _selectedItem;

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
                                          item.Language.Name, item.PriceSale, item.PriceRent, 
                                          item.Count);
            }
        }

        public void FillCheckOutItems()
        {
            if (_currentOrder != null)
            {
                dgvCheckOutItems.Rows.Clear();

                List<OrderItem> orderItems = _db.OrderItems.Include("Book")
                                                         .Where(o => o.OrderId == _currentOrder.Id)
                                                         .ToList();

                foreach (var item in orderItems)
                {
                    dgvCheckOutItems.Rows.Add(item.Id, item.Book.Name, item.Count,
                                              item.IsTypeSale == true? "Sale" : "Rent" ,
                                              item.Price, item.Amount, 
                        item.ReturnDate == null? "SALED" : item.ReturnDate.ToString());
                }
            }
        }

        public void ResetForm()
        {
            _selectedCustomer = null;
            _selectedBook = null;
            _currentOrder = null;
            _selectedItem = null;


            lblSeller.Hide();
            lblCustomer.Text = "";
            lblCustomerId.Text = "";
            lblCustomerEmail.Text = "";
            lblCustomerPhone.Text = "";

            txtSearchCustCrtOrder.Clear();
            txtSearchBookCrtOrder.Clear();

            rBtnRentOrder.Checked = true;
            rBtnSaleOrder.Hide();
            rBtnRentOrder.Hide();

            lblSlctBookName.Text = "";
            lblSlctBookName.Hide();
            lblBookPrice.Text = "";
            lblBookPrice.Hide();
            ntxtCountOrder.Value = 0;
            ntxtCountOrder.Hide();
            dateReturnOrder.Value = DateTime.Now;
            dateReturnOrder.Hide();

            lbltitleTotal.Hide();
            lblOrderTotalPrice.Text = "";
            lblOrderTotalPrice.Hide();

            dgvCustomers.Enabled = true;

            btnCreateCrtOrder.Hide();
            btnCancelCrtOrder.Hide();

            iconDeleteItem.Hide();
            lblSelectedItem.Hide();
        }

        #endregion


        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            //validations start
            if (_selectedCustomer == null)
            {
                DialogResult dialog = MessageBox.Show("Please, select customer!", "Oops, Error!", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            if (_selectedBook == null || ntxtCountOrder.Value < 1)
            {
                DialogResult dialog = MessageBox.Show("Please, select minimum one book!", "Oops, Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
            //validations end

            if (_currentOrder == null)
            {
                _currentOrder = new Order();

                _currentOrder.SellerId = 1; //static
                _currentOrder.CustomerId = _selectedCustomer.Id;
                _currentOrder.TotalPrice = 0;
                _currentOrder.CreatedAt = DateTime.Now;
                _currentOrder.Status = false; //default: False, if checkout:true

                _db.Orders.Add(_currentOrder);
                _db.SaveChanges();
            }
            
            if(_currentOrder != null)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.OrderId = _currentOrder.Id;
                orderItem.BookId = _selectedBook.Id;
                orderItem.IsTypeSale = rBtnSaleOrder.Checked == true ? true : false;

                decimal priceItem = 0;

                if (rBtnSaleOrder.Checked == true)
                {
                    orderItem.Price = _selectedBook.PriceSale;
                    priceItem = _selectedBook.PriceSale;
                }
                if (rBtnRentOrder.Checked == true)
                {
                    orderItem.Price = _selectedBook.PriceRent;
                    priceItem = _selectedBook.PriceRent;
                }

                orderItem.Count = Convert.ToInt32(ntxtCountOrder.Value);
                orderItem.Amount = Convert.ToInt32(priceItem * ntxtCountOrder.Value);

                orderItem.OrderDate = DateTime.Now;

                if (dateReturnOrder.Visible == true)
                {
                    orderItem.ReturnDate = dateReturnOrder.Value;
                }

                if (dateReturnOrder.Visible == false)
                {
                    orderItem.ReturnDate = null;
                }

                _currentOrder.TotalPrice += Convert.ToInt32(priceItem * ntxtCountOrder.Value);

                _db.OrderItems.Add(orderItem);
                _db.SaveChanges();

                MessageBox.Show("Book successfully added to shopping cart !", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbltitleTotal.Show();
                lblOrderTotalPrice.Text = _currentOrder.TotalPrice.ToString() + "  AZN";
                lblOrderTotalPrice.Show();

                dgvCustomers.Enabled = false;
                btnCreateCrtOrder.Show();
                _selectedBook = null;

                //clear old datas for new orderItem
                #region ClearOldDatas
                rBtnSaleOrder.Checked = false;
                rBtnSaleOrder.Hide();
                rBtnRentOrder.Checked = true;
                rBtnRentOrder.Hide();
                lblSlctBookName.Text = "";
                lblBookPrice.Text = "";
                lblBookPrice.Hide();
                ntxtCountOrder.Hide();
                ntxtCountOrder.Value = 0;
                dateReturnOrder.Hide();
                #endregion

                //fill Chech out list
                FillCheckOutItems();
            }

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
            if (btnCancelCrtOrder.Visible == false)
            {
                btnCancelCrtOrder.Show();
            }

            int customerId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedCustomer = _db.Customers.Find(customerId);

            if (_selectedCustomer != null)
            {
                lblCustomer.Text = _selectedCustomer.Name + " " + _selectedCustomer.Surname;
                lblCustomerId.Text = "# " + _selectedCustomer.Id;
                lblCustomerEmail.Text = _selectedCustomer.Email;
                lblCustomerPhone.Text = _selectedCustomer.Phone;

                lblSeller.Show();

            }
        }

        private void DgvBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (btnCancelCrtOrder.Visible == false)
            {
                btnCancelCrtOrder.Show();
            }

            int bookId = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedBook = _db.Books.Find(bookId);

            if (rBtnRentOrder.Checked == true)
            {
                if (_selectedBook != null)
                {
                    lblSlctBookName.Text = _selectedBook.Name;
                    lblBookPrice.Text = _selectedBook.PriceRent.ToString() + "   AZN";

                    rBtnSaleOrder.Show();
                    rBtnRentOrder.Show();
                    lblSlctBookName.Show();
                    lblBookPrice.Show();
                    ntxtCountOrder.Show();
                    dateReturnOrder.Show();
                }
            }

            if (rBtnSaleOrder.Checked == true)
            {
                if (_selectedBook != null)
                {
                    lblSlctBookName.Text = _selectedBook.Name;
                    lblBookPrice.Text = _selectedBook.PriceSale.ToString() + "   AZN";
                }
            }

        }


        //radio button toggle datetimepicker start
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
        //radio button toggle datetimepicker end



        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            dateReturnOrder.MinDate = DateTime.Now;
            dateReturnOrder.MaxDate = DateTime.Now.AddDays(15);
        }

        private void BtnCancelCrtOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to cancel the process ?", "Cancel Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialog == DialogResult.OK)
            {
                if (_currentOrder != null)
                {
                    int orderId = _currentOrder.Id;

                    _db.OrderItems.RemoveRange(_db.OrderItems.Where(o => o.OrderId == orderId));
                    _db.Orders.Remove(_currentOrder);
                    _db.SaveChanges();

                    FillCheckOutItems();
                    ResetForm();
                }
                if (_currentOrder == null)
                {
                    ResetForm();
                }

            }

        }

        private void DgvCheckOutItems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvCheckOutItems.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedItem = _db.OrderItems.Find(id);

            iconDeleteItem.Show();
            lblSelectedItem.Show();

            lblSelectedItem.Text = _selectedItem.Book.Name;
        }

        private void IconDeleteItem_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }

            iconDeleteItem.Show();
            lblSelectedItem.Show();
            lblSelectedItem.Text = _selectedItem.Book.Name;

            DialogResult dialog = MessageBox.Show("Selected item ' " + _selectedItem.Book.Name +  " ' will be removed from check out list", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                _db.OrderItems.Remove(_selectedItem);

                _db.SaveChanges();

                FillCheckOutItems();

                iconDeleteItem.Hide();
                lblSelectedItem.Text = "";
                lblSelectedItem.Hide();

                _currentOrder.TotalPrice -= _selectedItem.Amount;
                lblOrderTotalPrice.Text = _currentOrder.TotalPrice.ToString() + "  AZN";
            }
            else
            {
                iconDeleteItem.Hide();
                lblSelectedItem.Text = "";
                lblSelectedItem.Hide();

                _selectedItem = null;
            }
        }

        private void BtnCreateCrtOrder_Click(object sender, EventArgs e)
        {
            if (dgvCheckOutItems.Rows.Count < 1)
            {
                DialogResult d = MessageBox.Show("Order list is empty! Cancel the request ?", "Cancel Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (d == DialogResult.OK)
                {
                    if (_currentOrder != null)
                    {
                        int orderId = _currentOrder.Id;

                        _db.OrderItems.RemoveRange(_db.OrderItems.Where(o => o.OrderId == orderId));
                        _db.Orders.Remove(_currentOrder);
                        _db.SaveChanges();

                        FillCheckOutItems();
                        ResetForm();

                        MessageBox.Show("Request has been aborted!", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return;
                    }

                }
            }

            DialogResult dialog = MessageBox.Show("Do you want to complete the shopping ?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                _currentOrder.Status = true;

                MessageBox.Show("Request has been successfully completed", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                dgvCheckOutItems.Rows.Clear();
            };

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
