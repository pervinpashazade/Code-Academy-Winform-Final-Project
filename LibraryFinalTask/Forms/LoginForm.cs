using LibraryFinalTask.Data;
using LibraryFinalTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFinalTask.Forms
{
    public partial class LoginForm : Form
    {
        private readonly LibraryDbContext _db;
        public LoginForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();
        }



        //input effets start
        #region inputEffects

        private void TxtPassLogin_Click(object sender, EventArgs e)
        {
            txtPassLogin.Clear();
            txtPassLogin.PasswordChar = '*';
            txtPassLogin.ForeColor = Color.FromArgb(133, 240, 240);
            pnlPassLogin.BackColor = Color.FromArgb(133, 240, 240);

            txtEmailLogin.ForeColor = Color.WhiteSmoke;
            pnlEmailLogin.BackColor = Color.WhiteSmoke;
        }
        private void TxtEmailLogin_Click(object sender, EventArgs e)
        {
            txtEmailLogin.Clear();
            txtEmailLogin.ForeColor = Color.FromArgb(133, 240, 240);
            pnlEmailLogin.BackColor = Color.FromArgb(133, 240, 240);

            txtPassLogin.ForeColor = Color.WhiteSmoke;
            pnlPassLogin.BackColor = Color.WhiteSmoke;
        }

        #endregion
        //input effets end

        // exit icon
        private void IconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //copyright :)
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/pervin.pashazade");
            Process.Start(sInfo);
        }


        //Login process
        private void BtnLoginLoginF_Click(object sender, EventArgs e)
        {
            if (txtEmailLogin.Text == "Email" || string.IsNullOrEmpty(txtEmailLogin.Text))
            {
                lblErrorEmail.Show();
                pnlEmailLogin.BackColor = Color.Red;
            }
            else
            {
                lblErrorEmail.Hide();
            }

            if (txtPassLogin.Text == "Password" || string.IsNullOrEmpty(txtPassLogin.Text))
            {
                lblErrorPass.Show();
                pnlPassLogin.BackColor = Color.Red;
                return;
            }
            else
            {
                lblErrorPass.Hide();
            }


            Employee employee = _db.Employees.FirstOrDefault(x=>x.Email == txtEmailLogin.Text);

            if (employee !=null && employee.Password == txtPassLogin.Text)
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                DialogResult d = MessageBox.Show("Email or password not valid", "Oops, Error !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

    }
}
