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
        public AddOrderForm()
        {
            InitializeComponent();
        }

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
    }
}
