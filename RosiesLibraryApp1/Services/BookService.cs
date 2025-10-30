/* This service class provides methods to manage books in the library. */

using RosiesLibraryApp.Data;
using RosiesLibraryApp.Models;
using System.Collections.Generic;

namespace RosiesLibraryApp.Services
{
    public class BookService
    {
        private readonly BookRepository _repo;

        
        public BookService(BookRepository repo)
        {
            _repo = repo;
        }

        // Method to add a new book
        public bool AddBook(Book book, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(book.Title) ||
                string.IsNullOrWhiteSpace(book.Author) ||
                string.IsNullOrWhiteSpace(book.ISBN) ||
                book.Year <= 0)
            {
                errorMessage = "Please provide valid Title, Author, ISBN and Year.";
                return false;
            }
            // Ensure at least one copy is added
            bool success = _repo.Add(book);
            errorMessage = success ? "" : "Failed to add book.";
            return success;
        }

        // Method to update an existing book
        public bool UpdateBook(Book book, out string errorMessage)
        {
            if (book.Id <= 0)
            {
                errorMessage = "Invalid book ID.";
                return false;
            }
            
            bool success = _repo.Update(book);
            errorMessage = success ? "" : "Failed to update book.";
            return success; 
        }

        // Method to delete a book by ID
        public bool DeleteBook(int id, out string errorMessage)
        {
            if (id <= 0)
            {
                errorMessage = "Invalid book ID.";
                return false;
            }
            
            bool success = _repo.Delete(id);
            errorMessage = success ? "" : "Failed to delete book.";
            return success;
        }

        // Method to retrieve all books
        public List<Book> GetAllBooks()
        { // Retrieves all books from the repository
            return _repo.GetAll();
        }
    }
}