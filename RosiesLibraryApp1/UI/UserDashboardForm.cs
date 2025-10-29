using RosiesLibraryApp.Data;
using RosiesLibraryApp.Models;
using System;
using System.Windows.Forms;

namespace RosiesLibraryApp.UI
{
    public partial class UserDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly BorrowedBookRepository _borrowedBookRepo;
        private readonly BookRepository _bookRepo;
        private readonly Database _db;

        public UserDashboardForm(User user)
        {
            InitializeComponent();

            _currentUser = user;
            currentUserText.Text = $"Logged in as: {_currentUser.Username}";

            //Initialize database and repositories
            var db = new Database("library.db");
            DatabaseSeeder.Seed(db);

            _BookRepo = new BookRepository(db);
            _BorrowedBookRepo = new BorrowedBookRepository(db);

            LoadBooks();
            LoadBorrowedBooks();
        }

        #region Load & Display

        private void LoadBooks()
        {
            _allBooks = _bookRepo.GetAllBooks();
            DisplayBooks(_allBooks);
        }

        private void DisplayBooks(List<Book> books)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;

            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].Visible = false;
            if (dataGridView1.Columns.Contains("Copies"))
                dataGridView1.Columns["Copies"].Visible = false;
        }

        private void LoadBorrowedBooks()
        {
            var borrowed = _BorrowedBookRepo.GetBorrowedBooks(_currentUser.Id);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = borrowed;

            if (dataGridView2.Columns.Contains("Id"))
                dataGridView2.Columns["Id"].Visible = false;

            if (dataGridView2.Columns.Contains("UserId"))
                dataGridView2.Columns["UserId"].Visible = false;



        private void BorrowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Book selectedBook)
            {
                MessageBox.Show("Please select a book first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (selectedBook.Copies <= 0)
            {
                MessageBox.Show("No copies left for this book.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"You are about to borrow:\n\nTitle: {selectedBook.Title}\nAuthor: {selectedBook.Author}\nISBN: {selectedBook.ISBN}\nYear: {selectedBook.Year}\n\nProceed?",
                "Confirm Borrow",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _BorrowedBookRepo.BorrowBook(_currentUser.Id, selectedBook.Id);
              

                LoadBooks();
                LoadBorrowedBooks();
            }
            }
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow?.DataBoundItem is not BorrowedBook borrowedBook)
            {
                MessageBox.Show("Please select a borrowed book first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        #endregion

            var result = MessageBox.Show(info, "Confirm Return", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _BorrowedBookRepo.ReturnBook(_currentUser.Id, borrowedBook.Id);
              

                LoadBooks();
                LoadBorrowedBooks();
            }
        }
        */
        #endregion

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
};