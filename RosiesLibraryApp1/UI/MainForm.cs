using RosiesLibraryApp.Data;
using RosiesLibraryApp.Models;

namespace RosiesLibraryApp
{


    public partial class MainForm : Form
    {
        private readonly BookRepository _bookRepo;

        public MainForm()
        {
            InitializeComponent();
            var db = new Database("library.db");
            DatabaseSeeder.Seed(db);
            _bookRepo = new BookRepository(db);
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;


            LoadBooks();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(titleText.Text) ||
                string.IsNullOrEmpty(authorText.Text) ||
                string.IsNullOrEmpty(ISBNText.Text) ||
                string.IsNullOrEmpty(yearText.Text))
            {

                MessageBox.Show("Please fill in all fields before adding a book.",
                           "Validation Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(yearText.Text, out int year) || year <= 0)
            {
                MessageBox.Show("Please enter a valid year",
                                "Invalid Year",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }




            var book = new Book
            {
                Title = titleText.Text,
                Author = authorText.Text,
                ISBN = ISBNText.Text,
                Year = year,
                Copies = 1
            };

            _bookRepo.AddBook(book);
            LoadBooks();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Book selectedBook)
            {
                _bookRepo.DeleteBook(selectedBook.Id);
                LoadBooks();
            }
        }

        private void LoadButton_Click(object sender, EventArgs e) => LoadBooks();

        private void LoadBooks()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _bookRepo.GetAllBooks();
        }

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
                if (result == DialogResult.OK)
                {
                    selectedBook.Title = newTitle;
                    selectedBook.Author = newAuthor;
                    selectedBook.ISBN = newISBN;
                    selectedBook.Year = newYear;
                    selectedBook.Copies = newCopies;

                    _bookRepo.UpdateBook(selectedBook);
                    LoadBooks();

                    MessageBox.Show("Book updated", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Book selectedBook)
            {
                titleUpdate.Text = selectedBook.Title;
                authorUpdate.Text = selectedBook.Author;
                ISBNUpdate.Text = selectedBook.ISBN;
                yearUpdate.Text = selectedBook.Year.ToString();
                copiesUpdate.Text = selectedBook.Copies.ToString();
            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Book selectedBook)
            {
                string deleteTitle = selectedBook.Title;
                string deleteAuthor = selectedBook.Author;
                string deleteISBN = selectedBook.ISBN;
                int deleteYear = selectedBook.Year;
                int deleteCopies = selectedBook.Copies;

                var result = MessageBox.Show(
                    $"Are you sure you want to delete this book?\n\n" +
                    $"Title: {deleteTitle}\n" +
                    $"Author: {deleteAuthor}\n" +
                    $"ISBN: {deleteISBN}\n" +
                    $"Year: {deleteYear}\n" +
                    $"Copies: {deleteCopies}",
                    "Confirm Delete",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    _bookRepo.DeleteBook(selectedBook.Id);
                    LoadBooks();
                    MessageBox.Show("Book deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}