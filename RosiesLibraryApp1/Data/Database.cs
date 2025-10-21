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

        string createTable = @"
            CREATE TABLE IF NOT EXISTS Books (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL,
                Author TEXT NOT NULL,
                ISBN TEXT NOT NULL,
                Year INTEGER NOT NULL
            );";

        using var cmd = new SqliteCommand(createTable, conn); 
        cmd.ExecuteNonQuery();
    }
}