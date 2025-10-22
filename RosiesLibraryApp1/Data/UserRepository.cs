﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using RosiesLibraryApp.Models;

namespace RosiesLibraryApp.Data
{
    public class UserRepository
    {
        private readonly Database _db;
        public UserRepository(Database db) => _db = db;

        public bool Register(string username, string password, string email)
        {  
            using var conn = new SqliteConnection(_db.ConnectionString);
            conn.Open();

            using var checkCmd = new SqliteCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", conn);
            checkCmd.Parameters.AddWithValue("@Username", username);
            long userCount = (long)checkCmd.ExecuteScalar();
            if (userCount > 0)
            {
                return false; //Username already exists
            }
            using var cmd = new SqliteCommand("INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)", conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password); //In production, hash the password
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.ExecuteNonQuery();

            return true; //Registration successful
        }

        public User? Login(string username, string password)
        {
            using var conn = new SqliteConnection(_db.ConnectionString);
            conn.Open();

            using var cmd = new SqliteCommand(
                "SELECT Id, Username, Password, Email FROM Users WHERE Username = @Username AND Password = @Password",
                conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Email = reader.GetString(3)
                };
            }

            return null; //Login failed
        }

    }
}
