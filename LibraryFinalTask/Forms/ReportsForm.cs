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
    public partial class ReportsForm : Form
    {
        private readonly LibraryDbContext _db;
        public ReportsForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (dateEnd.Value > dateStart.Value)
            {
                DialogResult d = MessageBox.Show("The end date cannot be smaller than the start date", "Oops, Search Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            dgvReports.Rows.Clear();

            var query = _db.OrderItems.Include("Order")
                                       .Include("Book")
                                       .Where(o => (o.OrderDate.Year == dateStart.Value.Year &&
                                        o.OrderDate.Month == dateStart.Value.Month &&
                                        o.OrderDate.Day == dateStart.Value.Day)
                                        &&
                                        (o.OrderDate.Year <= dateEnd.Value.Year &&
                                        o.OrderDate.Month <= dateEnd.Value.Month &&
                                        o.OrderDate.Day <= dateEnd.Value.Day))
                                        .ToList();

            List<OrderItem> orders = query;

            foreach (var item in orders)
            {
                dgvReports.Rows.Add(item.Id, item.OrderId, item.Book.Name, item.Count,
                                    item.Amount, item.OrderDate, item.ReturnDate);
            }

        }

        private void IconRefresh_Click(object sender, EventArgs e)
        {
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            dgvReports.Rows.Clear();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
