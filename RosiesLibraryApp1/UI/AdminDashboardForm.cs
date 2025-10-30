/*  This form allows administrators to manage books in the library. */
using RosiesLibraryApp.Models;
using RosiesLibraryApp.Services;
using RosiesLibraryApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RosiesLibraryApp
{
    public partial class MainForm : Form
    {
        private readonly BookService _bookService;
        private readonly UserService _userService;
        private readonly BorrowService _borrowService;
        // store all books in a private list for searching and display
        private List<Book> _allBooks = new();
        private readonly System.Windows.Forms.Timer _searchTimer;


        
        public MainForm(BookService bookService, UserService userService, BorrowService borrowService)
{
         InitializeComponent();
         _bookService = bookService;
         _userService = userService;
         _borrowService = borrowService;

            // Handle selection change to populate update fields
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // Initialize search timer for debounced searching
            _searchTimer = new System.Windows.Forms.Timer { Interval = 300 };
            _searchTimer.Tick += SearchTimer_Tick;

             LoadBooks();
}
        // Method to load all books from the book service
        private void LoadBooks()
        {
            _allBooks = _bookService.GetAllBooks();
            dataGridView1.DataSource = _allBooks;
        }

        // Event handler for the Add button click
        private void AddButton_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = titleText.Text,
                Author = authorText.Text,
                ISBN = ISBNText.Text,
                Year = int.TryParse(yearText.Text, out var y) ? y : 0,
                Copies = 1
            };

            // Validate and add the book
            if (_bookService.AddBook(book, out var errorMessage))
            {
                LoadBooks();
                MessageBox.Show("Book added successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for the Update button click
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Book selectedBook)
            {
                string newTitle = titleUpdate.Text;
                string newAuthor = authorUpdate.Text;
                string newISBN = ISBNUpdate.Text;
                int newYear = int.TryParse(yearUpdate.Text, out int y) ? y : selectedBook.Year;
                int newCopies = int.TryParse(copiesUpdate.Text, out int c) ? c : selectedBook.Copies;

                var result = MessageBox.Show(
                    $"Are you sure you want to update the book?\n\n" +
                    $"Title: {newTitle}\n" +
                    $"Author: {newAuthor}\n" +
                    $"ISBN: {newISBN}\n" +
                    $"Year: {newYear}\n" +
                    $"Copies: {newCopies}",
                    "Confirm Update",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                // if user confirms, attempt to update the book with new details
                if (result == DialogResult.OK)
                {
                    selectedBook.Title = newTitle;
                    selectedBook.Author = newAuthor;
                    selectedBook.ISBN = newISBN;
                    selectedBook.Year = newYear;
                    selectedBook.Copies = newCopies;

                    if (_bookService.UpdateBook(selectedBook, out var errorMessage))
                    {
                        LoadBooks();
                        MessageBox.Show("Book updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Update cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a book first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Event handler for the Delete button click
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Book selectedBook)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete this book?\n\n" +
                    $"Title: {selectedBook.Title}\n" +
                    $"Author: {selectedBook.Author}\n" +
                    $"ISBN: {selectedBook.ISBN}\n" +
                    $"Year: {selectedBook.Year}\n" +
                    $"Copies: {selectedBook.Copies}",
                    "Confirm Delete",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                // if user confirms, attempt to delete the selected book
                if (result == DialogResult.OK)
                {
                    if (_bookService.DeleteBook(selectedBook.Id, out var errorMessage))
                    {
                        LoadBooks();
                        MessageBox.Show("Book deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Delete cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a book first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Event handler for selection change in the data grid view
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Book selectedBook)
            {// Populate the update fields with the selected book's details
                titleUpdate.Text = selectedBook.Title;
                authorUpdate.Text = selectedBook.Author;
                ISBNUpdate.Text = selectedBook.ISBN;
                yearUpdate.Text = selectedBook.Year.ToString(); 
                copiesUpdate.Text = selectedBook.Copies.ToString();
            }
        }

        // Event handler for the User Dashboard button click
        private void userDashboardButton_Click(object sender, EventArgs e)
        {// Open the login form to access the user dashboard
            var dashboard = new LoginForm(_userService, _bookService, _borrowService);
            dashboard.Show();
        }


        // Event handler for text change in the search box
        private void searchText_TextChanged(object sender, EventArgs e)
        { // Restart the search timer on each text change for debounced searching
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        // Event handler for the search timer tick
        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();

            string search = searchText.Text.Trim();

            // If search box is empty, show all books
            if (string.IsNullOrWhiteSpace(search))
            {
                dataGridView1.DataSource = _allBooks;
                return;
            }

            // Filter books based on the search text (case-insensitive)
            var filtered = _allBooks
                .Where(b =>
                    b.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    b.Author.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    b.ISBN.Contains(search, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridView1.DataSource = filtered;
        }
    }
}