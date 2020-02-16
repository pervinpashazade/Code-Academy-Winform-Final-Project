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
        private Book _selectedBook;
        public BooksForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();

            FillBooks();
            FillGenreDatas();
            FillAuthorDatas();
            FillLanguageDatas();
        }

        //methods start
        #region methods
        public void FillBooks()
        {
            dgvBooks.Rows.Clear();

            List<Book> books = _db.Books.Include("Genre")
                                        .Include("Author")
                                        .Include("Language")
                                        .ToList();

            foreach (var item in books)
            {
                dgvBooks.Rows.Add(item.Id, item.Name, item.Genre.Name, 
                                  item.Author.Name + " " + item.Author.Surname,
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

            cmbGenre.SelectedItem = null;
            cmbGenre.Text = "";
            cmbAuthor.SelectedItem = null;
            cmbAuthor.Text = "";
            cmbLanguage.SelectedItem = null;
            cmbLanguage.Text = "";

            ntxtSale.Value = 0;
            ntxtRent.Value = 0;
            ntxtCount.Value = 0;
            rBtnStatusActive.Checked = false;
            rBtnStatusDisabled.Checked = false;

            lblErrorName.Hide();
            lblErrorGenre.Hide();
            lblErrorAuthor.Hide();
            lblErrorLang.Hide();
            lblErrorSale.Hide();
            lblErrorRent.Hide();
            lblErrorCount.Hide();
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
        //methods end

        //btn clicks (CRUD) start
        #region btnClicks

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

            if (ntxtCount.Value == 0)
            {
                lblErrorCount.Show();
            }
            else
            {
                lblErrorCount.Hide();
            }

            if (rBtnStatusActive.Checked == false && rBtnStatusDisabled.Checked == false)
            {
                lblErrorStatus.Show();
            }
            else
            {
                lblErrorStatus.Hide();
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
                book.PriceSale = ntxtSale.Value;
                book.PriceRent = ntxtRent.Value;
                book.Count = Convert.ToInt32(ntxtCount.Value);
                book.Status = rBtnStatusActive.Checked ? true : false;
                book.CreatedAt = DateTime.Now;

                _db.Books.Add(book);
                _db.SaveChanges();

                MessageBox.Show("Book added : " + txtName.Text, "New Book");
                txtName.Clear();
                rBtnStatusActive.Checked = false;
                rBtnStatusDisabled.Checked = false;

                FillBooks();
                ResetForm();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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

            if (ntxtCount.Value == 0)
            {
                lblErrorCount.Show();
            }
            else
            {
                lblErrorCount.Hide();
            }

            if (rBtnStatusActive.Checked == false && rBtnStatusDisabled.Checked == false)
            {
                lblErrorStatus.Show();
            }
            else
            {
                lblErrorStatus.Hide();
            }
            //validation end

            if (!string.IsNullOrEmpty(txtName.Text) && cmbGenre.SelectedItem != null
                                                    && cmbAuthor.SelectedItem != null
                                                    && cmbLanguage.SelectedItem != null
                                                    && (rBtnStatusActive.Checked ||
                                                    rBtnStatusDisabled.Checked))
            {
                DialogResult dialog = MessageBox.Show("Selected book will be updated", "Update Book", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    ComboboxItem selectedGenre = cmbGenre.SelectedItem as ComboboxItem;
                    ComboboxItem selectedAuthor = cmbAuthor.SelectedItem as ComboboxItem;
                    ComboboxItem selectedLanguage = cmbLanguage.SelectedItem as ComboboxItem;

                    _selectedBook.Name = txtName.Text;
                    _selectedBook.GenreId = selectedGenre.Value;
                    _selectedBook.AuthorId = selectedAuthor.Value;
                    _selectedBook.LanguageId = selectedLanguage.Value;
                    _selectedBook.PriceSale = ntxtSale.Value;
                    _selectedBook.PriceRent = ntxtRent.Value;
                    _selectedBook.Count = Convert.ToInt32(ntxtCount.Value);
                    _selectedBook.Status = rBtnStatusActive.Checked ? true : false;

                    _db.SaveChanges();

                    FillBooks();
                    ResetForm();
                }
                else
                {
                    ResetForm();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Selected book will be deleted permanently", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                _db.Books.Remove(_selectedBook);

                _db.SaveChanges();

                FillBooks();
                ResetForm();
            }
            else
            {
                ResetForm();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        #endregion
        //btn clicks (CRUD) end



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
                FillBooks();
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

        private void DgvBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResetForm();

            int id = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());

            _selectedBook = _db.Books.Find(id);

            lblTitleBook.Show();
            lblSelectedBookName.Show();
            lblSelectedBookName.Text = _selectedBook.Name + " (" + _selectedBook.Language.Name + ")";

            btnUpdate.Show();
            btnDelete.Show();

            txtName.Text = _selectedBook.Name;
            cmbGenre.Text = _selectedBook.Genre.Name;
            cmbAuthor.Text = _selectedBook.Author.Name;
            cmbLanguage.Text = _selectedBook.Language.Name;

            ntxtSale.Value = Convert.ToInt32(_selectedBook.PriceSale);
            ntxtRent.Value = Convert.ToInt32(_selectedBook.PriceRent);

            ntxtCount.Value = Convert.ToInt32(_selectedBook.Count);

            if (_selectedBook.Status == false)
            {
                rBtnStatusDisabled.Checked = true;
            }
            else
            {
                rBtnStatusActive.Checked = true;
            }

            btnCreate.Enabled = false;
        }

        private void BooksForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
