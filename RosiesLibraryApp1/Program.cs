/*This is a c#.NET Windows Forms application representing a library system. 
It contains an Admin dashboard for searching, deleting, updating and adding books in the library, and a User dashboard
where a user can register, log in and borrow and return books that are available in the library. 
The library can carry multiple copies of the same book in the system.*/

using RosiesLibraryApp.Data;
using RosiesLibraryApp.Services;
using RosiesLibraryApp.UI;
using System;
using System.Windows.Forms;

namespace RosiesLibraryApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize application
            ApplicationConfiguration.Initialize();

            // Create database and seed if necessary
            var db = new Database("library.db");
            DatabaseSeeder.Seed(db);

            // Create repositories
            var bookRepo = new BookRepository(db);
            var userRepo = new UserRepository(db);
            var borrowedBookRepo = new BorrowedBookRepository(db);

            // Create services
            var bookService = new BookService(bookRepo);
            var userService = new UserService(userRepo);
            var borrowService = new BorrowService(borrowedBookRepo, bookRepo);

            // Start the app with MainForm (AdminDashboardForm)
            var mainForm = new MainForm(bookService, userService, borrowService);
            Application.Run(mainForm);
        }
    }
}