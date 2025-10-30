
/*This service class provides methods to manage borrowing and returning books in the library.*/
using RosiesLibraryApp.Data;
using RosiesLibraryApp.Models;
using System;
using System.Collections.Generic;

namespace RosiesLibraryApp.Services
{
    public class BorrowService
    {
        private readonly BorrowedBookRepository _borrowRepo;
        private readonly BookRepository _bookRepo;

        
        public BorrowService(BorrowedBookRepository borrowRepo, BookRepository bookRepo)
        {
            _borrowRepo = borrowRepo;
            _bookRepo = bookRepo;
        }

        // Method to get all borrowed books for a user
        public List<BorrowedBook> GetBorrowedBooks(int userId)
        {
            return _borrowRepo.GetBorrowedBooks(userId);
        }

        // Method to borrow a book
        public bool BorrowBook(int userId, int bookId, out string errorMessage)
        {
            var book = _bookRepo.GetAll().Find(b => b.Id == bookId);
            if (book == null)
            {
                errorMessage = "Book not found.";
                return false;
            }

            if (book.Copies <= 0)
            {
                errorMessage = "No copies available.";
                return false;
            }

            bool success = _borrowRepo.BorrowBook(userId, bookId);
            errorMessage = success ? "" : "Failed to borrow book.";
            return success;
        }


        // Method to return a borrowed book
        public bool ReturnBook(int userId, int borrowedBookId, out string errorMessage)
        {
            try
            {
                _borrowRepo.ReturnBook(userId, borrowedBookId);
                errorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}