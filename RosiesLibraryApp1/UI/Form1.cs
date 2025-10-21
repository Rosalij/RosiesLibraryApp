using RosiesLibraryApp.Data;
using RosiesLibraryApp.Models;

namespace RosiesLibraryApp1
{


    public partial class Form1 : Form
    {
        private readonly BookRepository _bookRepo;

        public Form1()
        {
            InitializeComponent();
            var db = new Database("library.db");
            _bookRepo = new BookRepository(db);

            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            loadButton.Click += LoadButton_Click;

            LoadBooks();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = titleText.Text,
                Author = authorText.Text,
                ISBN = ISBNText.Text,
                Year = int.TryParse(yearText.Text, out int y) ? y : 0
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

        private void addButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}