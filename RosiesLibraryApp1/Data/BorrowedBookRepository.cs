/* This code defines a repository class for managing borrowed books in a library application. */
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using RosiesLibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosiesLibraryApp.Data
{
    public class BorrowedBookRepository
    {
        private readonly Database _db;
        public BorrowedBookRepository(Database db) => _db = db;

        // Method to get all borrowed books for a specific user
        public List<BorrowedBook> GetBorrowedBooks(int userId)
        {
            var Borrowed = new List<BorrowedBook>();
            using var conn = _db.GetConnection();
            conn.Open();

            
            using var cmd = new SqliteCommand(@"
        SELECT 
            r.Id, 
            r.UserId, 
            r.BookId, 
            r.BorrowDate, 
            r.ReturnDate, 
            b.Author, 
            b.Title,
            b.ISBN
        FROM BorrowedBooks r
        JOIN Books b ON r.BookId = b.Id
        WHERE r.UserId = @UserId", conn);

            cmd.Parameters.AddWithValue("@UserId", userId);
            
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            { 
                Borrowed.Add(new BorrowedBook // Populate BorrowedBook object
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UserId = Convert.ToInt32(reader["UserId"]),
                    BookId = Convert.ToInt32(reader["BookId"]),
                    BorrowDate = DateTime.Parse(reader["BorrowDate"].ToString()),
                    ReturnDate = reader["ReturnDate"] == DBNull.Value ? null : DateTime.Parse(reader["ReturnDate"].ToString()),
                    Author = reader["Author"].ToString(),
                    Title = reader["Title"].ToString(),
                    ISBN = reader["ISBN"].ToString()

                });
            }

            return Borrowed; // Return list of borrowed books
        }


        // Method to borrow a book, database interaction.
        public bool BorrowBook(int userId, int bookId)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            using var trans = conn.BeginTransaction();

            // check user exists
            using var checkUser = new SqliteCommand("SELECT 1 FROM Users WHERE Id = @UserId", conn, trans);
            checkUser.Parameters.AddWithValue("@UserId", userId);
            if (checkUser.ExecuteScalar() == null) { trans.Rollback(); return false; }

            // check copies
            using var copiesCmd = new SqliteCommand("SELECT Copies FROM Books WHERE Id = @BookId", conn, trans);
            copiesCmd.Parameters.AddWithValue("@BookId", bookId);
            var copies = Convert.ToInt32(copiesCmd.ExecuteScalar() ?? 0);
            if (copies <= 0) { trans.Rollback(); return false; }

            //decrement and check update affected 1 row
            using var updateCmd = new SqliteCommand("UPDATE Books SET Copies = Copies - 1 WHERE Id = @BookId", conn, trans);
            updateCmd.Parameters.AddWithValue("@BookId", bookId);
            if (updateCmd.ExecuteNonQuery() != 1) { trans.Rollback(); return false; }


            //insert borrow record
            using var insertCmd = new SqliteCommand(
                "INSERT INTO BorrowedBooks (UserId, BookId, BorrowDate) VALUES (@UserId, @BookId, @BorrowDate)", conn, trans);
            insertCmd.Parameters.AddWithValue("@UserId", userId);
            insertCmd.Parameters.AddWithValue("@BookId", bookId);
            insertCmd.Parameters.AddWithValue("@BorrowDate", DateTime.Now.ToString("yyyy-MM-dd"));
          
            insertCmd.ExecuteNonQuery();

            trans.Commit();
            return true;
        }

        public void ReturnBook(int userId, int borrowedBookId)
        {
            using var conn = _db.GetConnection();
            conn.Open();


            //Get the book ID associated with this borrowed record
            var selectCmd = conn.CreateCommand();
            selectCmd.CommandText = "SELECT BookId FROM BorrowedBooks WHERE Id = @borrowedBookId AND UserId = @userId";
            selectCmd.Parameters.AddWithValue("@borrowedBookId", borrowedBookId);
            selectCmd.Parameters.AddWithValue("@userId", userId);
            var bookId = Convert.ToInt32(selectCmd.ExecuteScalar());

            if (bookId == 0)
                throw new Exception("Book not found or not borrowed by this user.");

            //Mark the borrowed record as returned
            var deleteCmd = conn.CreateCommand();
            deleteCmd.CommandText = "DELETE FROM BorrowedBooks WHERE Id = @borrowedBookId AND UserId = @userId";
            deleteCmd.Parameters.AddWithValue("@borrowedBookId", borrowedBookId);
            deleteCmd.Parameters.AddWithValue("@userId", userId);
            deleteCmd.ExecuteNonQuery();

            //Increase book copy count
            var updateCmd = conn.CreateCommand();
            updateCmd.CommandText = "UPDATE Books SET Copies = Copies + 1 WHERE Id = @bookId";
            updateCmd.Parameters.AddWithValue("@bookId", bookId);
            updateCmd.ExecuteNonQuery();
        }

    }
}


