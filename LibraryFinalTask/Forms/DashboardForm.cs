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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customers = new CustomersForm();
            customers.ShowDialog();
        }

        private void BtnGenres_Click(object sender, EventArgs e)
        {
            AddBookGenreForm genreForm = new AddBookGenreForm();
            genreForm.ShowDialog();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm orderForm = new AddOrderForm();
            orderForm.ShowDialog();
        }

        private void BtnAuthors_Click(object sender, EventArgs e)
        {
            AddAuthorForm authorForm = new AddAuthorForm();
            authorForm.ShowDialog();
        }

        private void BtnReturns_Click(object sender, EventArgs e)
        {
            ViewReturnsForm returnsForm = new ViewReturnsForm();
            returnsForm.ShowDialog();
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm employees = new EmployeesForm();
            employees.ShowDialog();
        }

        private void BtnPositions_Click(object sender, EventArgs e)
        {
            AddPositionForm positionForm = new AddPositionForm();
            positionForm.ShowDialog();
        }

        private void BtnLanguages_Click(object sender, EventArgs e)
        {
            AddLanguageForm languageForm = new AddLanguageForm();
            languageForm.ShowDialog();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.ShowDialog();
        }
    }
}
