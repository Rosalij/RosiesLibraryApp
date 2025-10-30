/* This code defines a BookRepository class that manages CRUD operations for books in a SQLite database.
   It includes methods to add, update, delete, and retrieve books, 
   ensuring that duplicate ISBNs are handled by updating the copy count. */
using Microsoft.Data.Sqlite;
using RosiesLibraryApp.Models;
using System.Collections.Generic;

namespace RosiesLibraryApp.Data
{
    public class BookRepository
    {
        private readonly Database _db;

        public BookRepository(Database db)
        {
            _db = db;
        }

        // Method to add a new book or update copies if ISBN exists, database interaction
        public bool Add(Book book)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            // Check if a book with the same ISBN already exists
            using var checkCmd = new SqliteCommand("SELECT Id, Copies FROM Books WHERE ISBN = @ISBN", conn);
            checkCmd.Parameters.AddWithValue("@ISBN", book.ISBN);

            using var reader = checkCmd.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                int copies = reader.GetInt32(1);
                reader.Close();
                // Update the existing book's copies
                using var updateCmd = new SqliteCommand("UPDATE Books SET Copies = @Copies WHERE Id = @Id", conn);
                updateCmd.Parameters.AddWithValue("@Id", id);
                updateCmd.Parameters.AddWithValue("@Copies", copies + book.Copies);
                return updateCmd.ExecuteNonQuery() > 0;
            }
            else
            {// Insert the new book
                reader.Close();
                using var cmd = new SqliteCommand(
                    "INSERT INTO Books (Title, Author, ISBN, Year, Copies) VALUES (@Title, @Author, @ISBN, @Year, @Copies)", conn);

                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                cmd.Parameters.AddWithValue("@Year", book.Year);
                cmd.Parameters.AddWithValue("@Copies", book.Copies);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Method to update an existing book, database interaction
        public bool Update(Book book)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            using var cmd = new SqliteCommand(
                "UPDATE Books SET Title=@Title, Author=@Author, ISBN=@ISBN, Year=@Year, Copies=@Copies WHERE Id=@Id", conn);
            
            cmd.Parameters.AddWithValue("@Id", book.Id);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd.Parameters.AddWithValue("@Year", book.Year);
            cmd.Parameters.AddWithValue("@Copies", book.Copies);

            return cmd.ExecuteNonQuery() > 0;
        }

        // Method to delete a book by ID, database interaction
        public bool Delete(int id)
        {
            using var conn = _db.GetConnection();
            conn.Open();
            // Delete the book with the specified ID
            using var cmd = new SqliteCommand("DELETE FROM Books WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        // Method to get all books, database interaction
        public List<Book> GetAll()
        {
            // Retrieve all books from the database
            var books = new List<Book>();
            using var conn = _db.GetConnection();
            conn.Open();

            using var cmd = new SqliteCommand("SELECT Id, Title, Author, ISBN, Year, Copies FROM Books", conn);
            using var reader = cmd.ExecuteReader();

          
            while (reader.Read())
            { 
                books.Add(new Book
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Author = reader.GetString(2),
                    ISBN = reader.GetString(3),
                    Year = reader.GetInt32(4),
                    Copies = reader.GetInt32(5)
                });
            }
            // Return the list of books
            return books;
        }
    }
} 