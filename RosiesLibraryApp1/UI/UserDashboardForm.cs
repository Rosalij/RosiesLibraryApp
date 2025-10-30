/* Windows Forms UI for the User Dashboard, for renting and borrowing books as a logged in user */ 
using RosiesLibraryApp.Models;
using RosiesLibraryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RosiesLibraryApp.UI
{
    public partial class UserDashboardForm : Form
    { // get the current logged in user, book service and borrow service via constructor injection
        private readonly User _currentUser;
        private readonly BookService _bookService;
        private readonly BorrowService _borrowService;
        // store all books and borrowed books in private lists for filtering and display
        private List<Book> _allBooks = new List<Book>();
        private List<BorrowedBook> _allBorrowedBooks = new List<BorrowedBook>();
        private readonly UserService _userService;

        public UserDashboardForm(User user, BookService bookService, BorrowService borrowService, UserService userService)
        {
            InitializeComponent();
            _currentUser = user;
            _bookService = bookService;
            _borrowService = borrowService;
            _userService = userService;
            
            currentUserText.Text = $"Logged in as: {_currentUser.Username}";
            // load books and borrowed books on form load
            LoadBooks();
            LoadBorrowedBooks();
        }

        // method to load all books from the book service
        private void LoadBooks()
        {
            _allBooks = _bookService.GetAllBooks();
            DisplayBooks(_allBooks);
        }

        // method to display books in the first data grid view
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
            _allBorrowedBooks = _borrowService.GetBorrowedBooks(_currentUser.Id);
            DisplayBorrowedBooks(_allBorrowedBooks);
        }

        // method to display borrowed books in the second data grid view
        private void DisplayBorrowedBooks(List<BorrowedBook> borrowedBooks)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = borrowedBooks;

            if (dataGridView2.Columns.Contains("Id"))
                dataGridView2.Columns["Id"].Visible = false;
            if (dataGridView2.Columns.Contains("BookId"))
                dataGridView2.Columns["BookId"].Visible = false;
            if (dataGridView2.Columns.Contains("UserId"))
                dataGridView2.Columns["UserId"].Visible = false;
            if (dataGridView2.Columns.Contains("ReturnDate"))
                dataGridView2.Columns["ReturnDate"].Visible = false;
        }

        // event handler for borrow button click
        private void BorrowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Book selectedBook)
            {
                MessageBox.Show("Please select a book first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            var result = MessageBox.Show(
                $"You are about to borrow:\n\nTitle: {selectedBook.Title}\nAuthor: {selectedBook.Author}\nISBN: {selectedBook.ISBN}\nYear: {selectedBook.Year}\n\nProceed?",
                "Confirm Borrow",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            // if user confirms, attempt to borrow the book via the borrow service
            if (result == DialogResult.OK)
            {
                if (_borrowService.BorrowBook(_currentUser.Id, selectedBook.Id, out var errorMessage))
                {// refresh the book and borrowed book lists
                    LoadBooks();
                    LoadBorrowedBooks();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // event handler for return button click
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow?.DataBoundItem is not BorrowedBook borrowedBook)
            {
                MessageBox.Show("Please select a borrowed book first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            var result = MessageBox.Show(
                $"You are about to return:\n\nTitle: {borrowedBook.Title}\nAuthor: {borrowedBook.Author}\n\nProceed?",
                "Confirm Return",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            // if user confirms, attempt to return the book via the borrow service
            if (result == DialogResult.OK)
            {
                if (_borrowService.ReturnBook(_currentUser.Id, borrowedBook.Id, out var errorMessage))
                {
                    LoadBooks();
                    LoadBorrowedBooks();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Return Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // event handler for text change in the search box
        private void textSearchBookToBorrow_TextChanged(object sender, EventArgs e)
        {
            string search = textSearchBookToBorrow.Text.Trim().ToLower();
            // filter the book list based on the search text
            var filtered = string.IsNullOrEmpty(search)
                ? _allBooks
                : _allBooks.Where(b =>
                    b.Title.ToLower().Contains(search) ||
                    b.Author.ToLower().Contains(search) ||
                    b.ISBN.ToLower().Contains(search))
                  .ToList();

            DisplayBooks(filtered);
        }

        // event handler for logout button click
        private void LogoutButton_Click(object sender, EventArgs e)
        {// show the login form and close the current dashboard form
            var loginForm = new LoginForm(_userService, _bookService, _borrowService);
            loginForm.Show();
            
            this.Close();
        }
    }
}
