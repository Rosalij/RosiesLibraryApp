using Microsoft.Data.Sqlite;

namespace RosiesLibraryApp.Data;

public class Database
{
    public string ConnectionString { get; }

    public Database(string databaseFile)
    {
        ConnectionString = $"Data Source={databaseFile}";
        Initialize();
    }

    private void Initialize()
    {
        using var conn = new SqliteConnection(ConnectionString); 
        conn.Open();

        string createBooksTable = @"
            CREATE TABLE IF NOT EXISTS Books (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL,
                Author TEXT NOT NULL,
                ISBN TEXT NOT NULL UNIQUE,
                Year INTEGER NOT NULL,
                Copies INTEGER NOT NULL DEFAULT 1 
             );";

        string createUsersTable = @"
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL 
             );";

        string createBorrowedBooksTable = @"
    CREATE TABLE IF NOT EXISTS BorrowedBooks (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        UserId INTEGER NOT NULL,
        BookId INTEGER NOT NULL,
        BorrowDate TEXT NOT NULL,
        ReturnDate TEXT,
        FOREIGN KEY(UserId) REFERENCES Users(Id),
        FOREIGN KEY(BookId) REFERENCES Books(Id)
    );";

            CREATE TABLE IF NOT EXISTS Reviews (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                BookId INTEGER NOT NULL,
                UserId INTEGER NOT NULL,
                Rating INTEGER NOT NULL CHECK(Rating >= 1 AND Rating <= 5),
                Comment TEXT,
                FOREIGN KEY(BookId) REFERENCES Books(Id),
                FOREIGN KEY(UserId) REFERENCES Users(Id)
             );";

        using var cmd = new SqliteCommand(createBooksTable, conn); 
        cmd.ExecuteNonQuery();
        
        using var cmd2 = new SqliteCommand(createUsersTable, conn);
        cmd2.ExecuteNonQuery();

        using var cmd3 = new SqliteCommand(createBorrowedBooksTable, conn);
        cmd3.ExecuteNonQuery();

        using var cmd4 = new SqliteCommand(createReviewsTable, conn);
        cmd4.ExecuteNonQuery();
    }
}