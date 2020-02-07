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
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {

            InitializeComponent();
        }


        private void TxtNameReg_Click(object sender, EventArgs e)
        {
            txtNameReg.Clear();
            txtNameReg.ForeColor = Color.FromArgb(133, 240, 240);
            pnlNameReg.BackColor = Color.FromArgb(133, 240, 240);

            txtSurnameReg.ForeColor = Color.WhiteSmoke;
            pnlSurnameReg.BackColor = Color.WhiteSmoke;

            txtEmailReg.ForeColor = Color.WhiteSmoke;
            pnlEmailReg.BackColor = Color.WhiteSmoke;

            txtPassReg.ForeColor = Color.WhiteSmoke;
            pnlPassReg.BackColor = Color.WhiteSmoke;
        }

        private void TxtSurnameReg_Click(object sender, EventArgs e)
        {
            txtSurnameReg.Clear();
            txtSurnameReg.ForeColor = Color.FromArgb(133, 240, 240);
            pnlSurnameReg.BackColor = Color.FromArgb(133, 240, 240);

            txtNameReg.ForeColor = Color.WhiteSmoke;
            pnlNameReg.BackColor = Color.WhiteSmoke;

            txtEmailReg.ForeColor = Color.WhiteSmoke;
            pnlEmailReg.BackColor = Color.WhiteSmoke;

            txtPassReg.ForeColor = Color.WhiteSmoke;
            pnlPassReg.BackColor = Color.WhiteSmoke;
        }

        private void TxtEmailReg_Click(object sender, EventArgs e)
        {
            txtEmailReg.Clear();
            txtEmailReg.ForeColor = Color.FromArgb(133, 240, 240);
            pnlEmailReg.BackColor = Color.FromArgb(133, 240, 240);

            txtNameReg.ForeColor = Color.WhiteSmoke;
            pnlNameReg.BackColor = Color.WhiteSmoke;

            txtSurnameReg.ForeColor = Color.WhiteSmoke;
            pnlSurnameReg.BackColor = Color.WhiteSmoke;

            txtPassReg.ForeColor = Color.WhiteSmoke;
            pnlPassReg.BackColor = Color.WhiteSmoke;
        }

        private void TxtPassReg_Click(object sender, EventArgs e)
        {
            txtPassReg.Clear();
            txtPassReg.PasswordChar = '*';
            txtPassReg.ForeColor = Color.FromArgb(133, 240, 240);
            pnlPassReg.BackColor = Color.FromArgb(133, 240, 240);

            txtNameReg.ForeColor = Color.WhiteSmoke;
            pnlNameReg.BackColor = Color.WhiteSmoke;

            txtSurnameReg.ForeColor = Color.WhiteSmoke;
            pnlSurnameReg.BackColor = Color.WhiteSmoke;

            txtEmailReg.ForeColor = Color.WhiteSmoke;
            pnlEmailReg.BackColor = Color.WhiteSmoke;
        }



        private void BtnLoginRegF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BtnRegisterRegF_Click(object sender, EventArgs e)
        {
            if (txtNameReg.Text == "Name" || string.IsNullOrEmpty(txtNameReg.Text))
            {
                lblErrorName.Show();
                pnlNameReg.BackColor = Color.Red;
            }
            else
            {
                lblErrorName.Hide();
            }

            if (txtSurnameReg.Text == "Surname" || string.IsNullOrEmpty(txtSurnameReg.Text))
            {
                lblErrorSurname.Show();
                pnlSurnameReg.BackColor = Color.Red;
            }
            else
            {
                lblErrorSurname.Hide();
            }

            if (txtEmailReg.Text == "Email" || string.IsNullOrEmpty(txtEmailReg.Text))
            {
                lblErrorEmail.Show();
                pnlEmailReg.BackColor = Color.Red;
            }
            else
            {
                lblErrorEmail.Hide();
            }

            if (txtPassReg.Text == "Password" || string.IsNullOrEmpty(txtPassReg.Text))
            {
                lblErrorPass.Show();
                pnlPassReg.BackColor = Color.Red;
            }
            else
            {
                lblErrorPass.Hide();
            }

            if (!(txtNameReg.Text == "Name" || string.IsNullOrEmpty(txtNameReg.Text)) ||
                !(txtSurnameReg.Text == "Surname" || string.IsNullOrEmpty(txtSurnameReg.Text)) ||
                !(txtEmailReg.Text == "Email" || string.IsNullOrEmpty(txtEmailReg.Text)) ||
                !(txtPassReg.Text == "Password" || string.IsNullOrEmpty(txtPassReg.Text))
                )
            {
                if (!(checkboxTermsReg.Checked))
                {
                    MessageBox.Show("You must accept our Terms & Conditions", "Oops, Warning!");
                    return;
                }
            }

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
                "PageMaker including versions of Lorem Ipsum."+" ";

            return content;
        }

        private void LblTermsLink_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FillTermsAndConditions(), "Library App Terms & Conditions");
        }
    }
}
