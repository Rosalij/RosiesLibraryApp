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

        using var checkCmd = new SqliteCommand("SELECT Id, Copies FROM Books WHERE ISBN = @ISBN", conn);
        checkCmd.Parameters.AddWithValue("@ISBN", book.ISBN);


        using var reader = checkCmd.ExecuteReader();
        if (reader.Read())
        {
            int id = reader.GetInt32(0);
            int copies = reader.GetInt32(1);

            reader.Close();

            //Update existing record
            using var updateCmd = new SqliteCommand("UPDATE Books SET Copies = @Copies WHERE Id = @Id", conn);
            updateCmd.Parameters.AddWithValue("@Id", id);
            updateCmd.Parameters.AddWithValue("@Copies", copies + 1);
            updateCmd.ExecuteNonQuery();
        }
        else
        {
            //Add new book
            reader.Close();

            using var cmd = new SqliteCommand(
                "INSERT INTO Books (Title, Author, ISBN, Year, Copies) VALUES (@Title, @Author, @ISBN, @Year, @Copies)", conn);

            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd.Parameters.AddWithValue("@Year", book.Year);
            cmd.Parameters.AddWithValue("@Copies", book.Copies);
            cmd.ExecuteNonQuery();
        }
    } 

    public void DeleteBook(int id)
    {
        using var conn = new SqliteConnection(_db.ConnectionString);
        conn.Open();
        using var cmd = new SqliteCommand("DELETE FROM Books WHERE Id=@Id", conn);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.ExecuteNonQuery();
    }

    public void UpdateBook(Book book)
    {
        using var conn = new SqliteConnection(_db.ConnectionString);
        conn.Open();
        using var cmd = new SqliteCommand(
            "UPDATE Books SET Title=@Title, Author=@Author, ISBN=@ISBN, Year=@Year, Copies=@Copies WHERE Id=@Id", conn);
        cmd.Parameters.AddWithValue("@Id", book.Id);
        cmd.Parameters.AddWithValue("@Title", book.Title);
        cmd.Parameters.AddWithValue("@Author", book.Author);
        cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
        cmd.Parameters.AddWithValue("@Year", book.Year);
        cmd.Parameters.AddWithValue("@Copies", book.Copies);
        cmd.ExecuteNonQuery();
    }

    public List<Book> GetAllBooks()
    {
        var books = new List<Book>();
        using var conn = new SqliteConnection(_db.ConnectionString);
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
        return books;
    }


}