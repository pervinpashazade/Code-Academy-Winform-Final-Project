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
    public partial class ViewReturnsForm : Form
    {
        private readonly LibraryDbContext _db;
        private readonly Order _order;
        public ViewReturnsForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillReturnsToday();
        }

        #region fillMethods

        public void FillReturnsToday()
        {
            dgvToday.Rows.Clear();

            List<OrderItem> orderItems = _db.OrderItems.Include("Customer")
                                                       .Include("Order")
                                                       .Where(o => o.ReturnDate == DateTime.Now)
                                                       .ToList();



            foreach (var item in orderItems)
            {
                dgvToday.Rows.Add(item.Id, item.Order.CustomerId, item.Order.Customer.Name,
                                  item.Order.Customer.Surname,
                                  item.ReturnDate,
                                  item.Order.Customer.Email, item.Order.Customer.Phone);
            }
        }

        #endregion

        private void BtnTomorrow_Click(object sender, EventArgs e)
        {
            btnToday.ForeColor = Color.WhiteSmoke;
            dgvToday.Hide();

            btnTomorrow.ForeColor = Color.FromArgb(133, 240, 240);
            dgvTomorrow.Show();

            btnDelayed.ForeColor = Color.WhiteSmoke;
            dgvDelayed.Hide();
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {

            //toggle effect start
            #region clickToggleEffect
            btnToday.ForeColor = Color.FromArgb(133, 240, 240);
            dgvToday.Show();

            btnTomorrow.ForeColor = Color.WhiteSmoke;
            dgvTomorrow.Hide();

            btnDelayed.ForeColor = Color.WhiteSmoke;
            dgvDelayed.Hide();
            #endregion
            //toggle effect start


        }

        private void BtnDelayed_Click(object sender, EventArgs e)
        {
            btnDelayed.ForeColor = Color.FromArgb(133, 240, 240);
            dgvDelayed.Show();

            btnTomorrow.ForeColor = Color.WhiteSmoke;
            dgvTomorrow.Hide();

            btnToday.ForeColor = Color.WhiteSmoke;
            dgvToday.Hide();
        }
    }
}
