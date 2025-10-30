/* This code defines a Database class for managing a SQLite database connection
   and initializing the database schema for the library application.
*/
using Microsoft.Data.Sqlite;
using System;

namespace RosiesLibraryApp.Data
{
    public class Database
    {
        private readonly string _connectionString;

        public Database(string databaseFile)
        {
            if (string.IsNullOrWhiteSpace(databaseFile))
                throw new ArgumentException("Database file path cannot be null or empty.", nameof(databaseFile));

            _connectionString = $"Data Source={databaseFile}";
            Initialize();
        }
        
        public SqliteConnection GetConnection() => new SqliteConnection(_connectionString);

        private void Initialize()
        {
            using var conn = GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = GetCreateTablesSql();
            cmd.ExecuteNonQuery();
        }
        
        private string GetCreateTablesSql() => @"
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                Email TEXT NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Books (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL,
                Author TEXT NOT NULL,
                ISBN TEXT,
                Year INTEGER,
                Copies INTEGER DEFAULT 1
            );

            CREATE TABLE IF NOT EXISTS BorrowedBooks (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                UserId INTEGER NOT NULL,
                BookId INTEGER NOT NULL,
                BorrowDate TEXT DEFAULT (DATE('now')),
                ReturnDate TEXT,
                FOREIGN KEY (UserId) REFERENCES Users(Id),
                FOREIGN KEY (BookId) REFERENCES Books(Id)
            );
        ";
    }
}