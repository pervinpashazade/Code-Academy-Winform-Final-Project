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


        RegisterForm registerForm = new RegisterForm();

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



        private void BtnRegisterLoginF_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            registerForm.Left += 10;
            if (registerForm.Left >= 850)
            {
                timer1.Stop();
                this.TopMost = false;
                registerForm.TopMost = true;
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            registerForm.Left -= 10;
            if (registerForm.Left <= 520)
            {
                timer2.Stop();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            registerForm.Show();
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblTermsLink_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FillTermsAndConditions(), "Library App Terms & Conditions");
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
        }
    }
}
