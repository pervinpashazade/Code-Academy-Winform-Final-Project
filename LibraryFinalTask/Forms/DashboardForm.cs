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
            this.Hide();
            booksForm.ShowDialog();
        }
    }
}
