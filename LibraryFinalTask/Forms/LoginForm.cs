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
        public LoginForm()
        {
            InitializeComponent();
        }

        public string FillTermsAndConditions()
        {
            string content = "Lorem Ipsum is simply dummy text of the printing and typesetting" +
                "industry. Lorem Ipsum has been the industry's standard dummy text ever since" +
                "the 1500s, when an unknown printer took a galley of type and scrambled it to" +
                "make a type specimen book. It has survived not only five centuries, but also" +
                "the leap into electronic typesetting, remaining essentially unchanged. It was" +
                "popularised in the 1960s with the release of Letraset sheets containing Lorem" +
                "Ipsum passages, and more recently with desktop publishing software like Aldus" +
                "PageMaker including versions of Lorem Ipsum." + " ";

            return content;
        }

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

        private void IconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/pervin.pashazade");
            Process.Start(sInfo);
        }

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

            }
            else
            {
                lblErrorPass.Hide();
            }

            AddOrderForm addOrderForm = new AddOrderForm();

            addOrderForm.ShowDialog();
        }

    }
}
