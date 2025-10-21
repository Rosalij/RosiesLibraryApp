using Microsoft.Data.Sqlite;
using RosiesLibraryApp.Models;
using System;
using System.Collections.Generic;

namespace RosiesLibraryApp.Data;

public class BookRepository
{
    private readonly Database _db;

    public BookRepository(Database db)
    {
        _db = db;
    }

    public void AddBook(Book book)
    {
        using var conn = new SqliteConnection(_db.ConnectionString);
        conn.Open();

        using var cmd = new SqliteCommand(
            "INSERT INTO Books (Title, Author, ISBN, Year) VALUES (@Title, @Author, @ISBN, @Year)", conn);

        cmd.Parameters.AddWithValue("@Title", book.Title);
        cmd.Parameters.AddWithValue("@Author", book.Author);
        cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
        cmd.Parameters.AddWithValue("@Year", book.Year);

        cmd.ExecuteNonQuery();
    }

    public void DeleteBook(int id)
    {
        using var conn = new SqliteConnection(_db.ConnectionString);
        conn.Open();
        using var cmd = new SqliteCommand("DELETE FROM Books WHERE Id=@Id", conn);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.ExecuteNonQuery();
    }

    public List<Book> GetAllBooks()
    {
        var books = new List<Book>();
        using var conn = new SqliteConnection(_db.ConnectionString);
        conn.Open();
        using var cmd = new SqliteCommand("SELECT Id, Title, Author, ISBN, Year FROM Books", conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            books.Add(new Book
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Author = reader.GetString(2),
                ISBN = reader.GetString(3),
                Year = reader.GetInt32(4)
            });
        }
        return books;
    }
}