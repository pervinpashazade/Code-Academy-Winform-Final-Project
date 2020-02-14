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
    public partial class BooksForm : Form
    {
        private readonly LibraryDbContext _db;
        private readonly Book _selectedBook;
        public BooksForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillGenreDatas();
            FillAuthorDatas();
            FillLanguageDatas();
        }


        #region methods
        public void FillBooks()
        {
            dgvBooks.Rows.Clear();

            List<Book> books = _db.Books.ToList();

            foreach (var item in books)
            {
                dgvBooks.Rows.Add(item.Id, item.Name, item.Genre.Name, item.Author.Name,
                                  item.Language.Name, item.Count, item.PriceSale,
                                  item.PriceRent, item.Status ? "Active" : "Disabled");
            }
        }
        public void FillGenreDatas()
        {
            cmbGenre.Items.Clear();

            List<Genre> genres = _db.Genres.OrderBy(g=>g.Name).ToList();

            foreach (var item in genres.Where(g=> g.Status == true))
            {
                ComboboxItem comboboxItem = new ComboboxItem
                {
                    firstName = item.Name,
                    Value = item.Id
                };

                cmbGenre.Items.Add(comboboxItem);
            }
        }

        public void FillAuthorDatas()
        {
            cmbAuthor.Items.Clear();

            List<Author> authors = _db.Authors.Where(a => a.Status == true).ToList();

            foreach (var item in authors)
            {
                ComboboxItem comboboxItem = new ComboboxItem
                {
                    firstName = item.Name,
                    secondName = item.Surname,
                    Value = item.Id
                };

                cmbAuthor.Items.Add(comboboxItem);
            }
        }

        public void FillLanguageDatas()
        {
            cmbLanguage.Items.Clear();

            List<Language> languages = _db.Languages.Where(l => l.Status == true).ToList();

            foreach (var item in languages)
            {
                ComboboxItem comboboxItem = new ComboboxItem
                {
                    firstName = item.Name,
                    Value = item.Id
                };

                cmbLanguage.Items.Add(comboboxItem);
            }
        }

        public void ResetForm()
        {
            txtName.Clear();

            cmbGenre.ResetText();
            cmbAuthor.ResetText();
            cmbLanguage.ResetText();

            ntxtSale.Value = 0;
            ntxtRent.Value = 0;
            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;

            lblErrorName.Hide();
            lblErrorGenre.Hide();
            lblErrorAuthor.Hide();
            lblErrorLang.Hide();
            lblErrorSale.Hide();
            lblErrorRent.Hide();
            lblErrorStatus.Hide();

            lblTitleBook.Hide();
            lblSelectedBookName.Text = "";
            lblSelectedBookName.Hide();

            btnUpdate.Hide();
            btnDelete.Hide();

            if (btnCreate.Enabled == false)
            {
                btnCreate.Enabled = true;
            }
        }

        #endregion

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //validation start
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorName.Show();
            }
            else
            {
                lblErrorName.Hide();
            }

            if (cmbGenre.SelectedItem == null)
            {
                lblErrorGenre.Show();
            }
            else
            {
                lblErrorGenre.Hide();
            }

            if (cmbAuthor.SelectedItem == null)
            {
                lblErrorAuthor.Show();
            }
            else
            {
                lblErrorAuthor.Hide();
            }

            if (cmbLanguage.SelectedItem == null)
            {
                lblErrorLang.Show();
            }
            else
            {
                lblErrorLang.Hide();
            }

            if (ntxtSale.Value == 0)
            {
                lblErrorSale.Show();
            }
            else
            {
                lblErrorSale.Hide();
            }

            if (ntxtRent.Value == 0)
            {
                lblErrorRent.Show();
            }
            else
            {
                lblErrorRent.Hide();
            }
            //validation end

            if (!string.IsNullOrEmpty(txtName.Text) && cmbGenre.SelectedItem != null
                                                    && cmbAuthor.SelectedItem != null
                                                    && cmbLanguage.SelectedItem != null
                                                    && (rBtnStatusActive.Checked ||
                                                    rBtnStatusDisabled.Checked))
            {
                ComboboxItem selectedGenre = cmbGenre.SelectedItem as ComboboxItem;
                ComboboxItem selectedAuthor = cmbAuthor.SelectedItem as ComboboxItem;
                ComboboxItem selectedLanguage = cmbLanguage.SelectedItem as ComboboxItem;

                Book book = new Book();

                book.Name = txtName.Text;
                book.GenreId = selectedGenre.Value;
                book.AuthorId = selectedAuthor.Value;
                book.LanguageId = selectedLanguage.Value;
                book.Status = rBtnStatusActive.Checked ? true : false;
                book.CreatedAt = DateTime.Now;

                _db.Books.Add(book);
                _db.SaveChanges();

                MessageBox.Show("Book added : " + txtName.Text, "New Book");
                txtName.Clear();
                rBtnStatusActive.Checked = false;
                rBtnStatusDisabled.Checked = false;

                FillBooks();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            cmbGenre.DataSource = null;
            cmbAuthor.DataSource = null;
            cmbLanguage.DataSource = null;
            ntxtSale.Value = 0;
            ntxtRent.Value = 0;

            lblErrorName.Hide();
            lblErrorGenre.Hide();
            lblErrorAuthor.Hide();
            lblErrorLang.Hide();
            lblErrorSale.Hide();
            lblErrorRent.Hide();
        }

        private void IconAddGenre_Click(object sender, EventArgs e)
        {
            AddBookGenreForm addBookGenreForm = new AddBookGenreForm();
            addBookGenreForm.ShowDialog();
        }

        private void IconAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm addAuthorForm = new AddAuthorForm();
            addAuthorForm.ShowDialog();
        }

        private void IconAddLang_Click(object sender, EventArgs e)
        {
            AddLanguageForm addLanguageForm = new AddLanguageForm();
            addLanguageForm.ShowDialog();
        }


        private void IconRefresh_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Refresh Form datas?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                FillAuthorDatas();
                FillGenreDatas();
                FillLanguageDatas();
            }
        }

        //combobox get
        public class ComboboxItem
        {
            public string firstName { get; set; }
            public string secondName { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return firstName + " " + secondName;
            }
        }
    }
}
