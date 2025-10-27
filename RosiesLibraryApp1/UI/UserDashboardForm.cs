using RosiesLibraryApp.Data;
using RosiesLibraryApp.Models;
using System;
using System.Windows.Forms;

namespace RosiesLibraryApp.UI
{
    public partial class UserDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly BorrowedBookRepository _BorrowedBookRepo;
        private readonly BookRepository _BookRepo;

        public UserDashboardForm(User user)
        {
            InitializeComponent();

            //Set to current user
            _currentUser = user;
            currentUserText.Text = $"Logged in as: {_currentUser.Username}";

            //Initialize database and repositories
            var db = new Database("library.db");
            DatabaseSeeder.Seed(db);

            _BookRepo = new BookRepository(db);
            _BorrowedBookRepo = new BorrowedBookRepository(db);

            //Load data
            LoadBooks();
            LoadBorrowedBooks();
        }

        //Load all available books in library
        private void LoadBooks()
        {
            var books = _BookRepo.GetAllBooks();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;

            //Disable columns id and copies of users
            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].Visible = false;

            if (dataGridView1.Columns.Contains("Copies"))
                dataGridView1.Columns["Copies"].Visible = false;
        }

        //Load all books borrowed by the current user
        private void LoadBorrowedBooks()
        {
            var borrowed = _BorrowedBookRepo.GetBorrowedBooks(_currentUser.Id);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = borrowed;

            if (dataGridView2.Columns.Contains("Id"))
                dataGridView2.Columns["Id"].Visible = false;

            if (dataGridView2.Columns.Contains("UserId"))
                dataGridView2.Columns["UserId"].Visible = false;
        }



        //Handle borrow button click
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

            string BorrowInfo = $"You are about to borrow this book:\n\n" +
                              $"Title: {selectedBook.Title}\n" +
                              $"Author: {selectedBook.Author}\n" +
                              $"ISBN: {selectedBook.ISBN}\n" +
                              $"Year: {selectedBook.Year}\n\n" +
                              "Do you want to proceed?";

            var result = MessageBox.Show(BorrowInfo, "Confirm book", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _BorrowedBookRepo.BorrowBook(_currentUser.Id, selectedBook.Id);
              

                LoadBooks();
                LoadBorrowedBooks();
            }
            else
            {
                MessageBox.Show("Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow?.DataBoundItem is not BorrowedBook borrowedBook)
            {
                MessageBox.Show("Please select a borrowed book first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string info = $"You are about to return this book:\n\n" +
                          $"Title: {borrowedBook.Title}\n" +
                          $"Author: {borrowedBook.Author}\n\n" +
                          "Do you want to proceed?";

            var result = MessageBox.Show(info, "Confirm Return", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _BorrowedBookRepo.ReturnBook(_currentUser.Id, borrowedBook.Id);
              

                LoadBooks();
                LoadBorrowedBooks();
            }
        }

        // Placeholder for book reviews
        private void reviewBookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Review book feature will go here!");
        }

        // Logout
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
};