using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosiesLibraryApp.Data
{
    public class RentalRepository
    {
        private readonly Database _db;
        public RentalRepository(Database db) => _db = db;

        public bool RentBook(int userId, int bookId)
        {
            using var conn = new SqliteConnection(_db.ConnectionString);
            conn.Open();

            using var trans = conn.BeginTransaction();

            var check = new SqliteCommand("SELECT Copies FROM Books WHERE Id=@Id", conn, trans);
            check.Parameters.AddWithValue("@Id", bookId);
            var copies = Convert.ToInt32(check.ExecuteScalar() ?? 0);
            if (copies <= 0)
            {
                trans.Rollback();
                return false;
            }

            var update = new SqliteCommand("UPDATE Books SET Copies = Copies - 1 WHERE Id = @Id", conn, trans);
            update.Parameters.AddWithValue("@Id", bookId);
            update.ExecuteNonQuery();

            var rent = new SqliteCommand(
                "INSERT INTO Rentals (UserId, BookId, RentDate) VALUES (@UserId, @BookId, @RentDate)", conn, trans);
            rent.Parameters.AddWithValue("@UserId", userId);
            rent.Parameters.AddWithValue("@BookId", bookId);
            rent.Parameters.AddWithValue("@RentDate", DateTime.Now.ToString("yyyy-MM-dd"));
            rent.ExecuteNonQuery();

            trans.Commit();
            return true;
        }

        public void ReturnBook(int userId, int bookId)
        {
            using var conn = new SqliteConnection(_db.ConnectionString);
            conn.Open();

            using var trans = conn.BeginTransaction();

            var updateRental = new SqliteCommand(
                "UPDATE Rentals SET ReturnDate=@ReturnDate WHERE UserId=@UserId AND BookId=@BookId AND ReturnDate IS NULL", conn, trans);
            updateRental.Parameters.AddWithValue("@UserId", userId);
            updateRental.Parameters.AddWithValue("@BookId", bookId);
            updateRental.Parameters.AddWithValue("@ReturnDate", DateTime.Now.ToString("yyyy-MM-dd"));
            updateRental.ExecuteNonQuery();

            var updateBook = new SqliteCommand("UPDATE Books SET Copies = Copies + 1 WHERE Id=@Id", conn, trans);
            updateBook.Parameters.AddWithValue("@Id", bookId);
            updateBook.ExecuteNonQuery();

            trans.Commit();
        }
    }
}
