/* Form for logging in as a registered user */
using System;
using System.Windows.Forms;
using RosiesLibraryApp.Services;
using RosiesLibraryApp.Models;

namespace RosiesLibraryApp.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        private readonly BookService _bookService;
        private readonly BorrowService _borrowService;

        // Constructor injection of services
        public LoginForm(UserService userService, BookService bookService, BorrowService borrowService)
        {
            InitializeComponent();
            _userService = userService;
            _bookService = bookService;
            _borrowService = borrowService;
        }

        // Event handler for the Register button click
        private void registerButton_Click(object sender, EventArgs e)
        { // Open the registration form
            var registerForm = new RegisterForm(_userService);
            registerForm.ShowDialog();
        }


        // Event handler for the Login button click
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text.Trim();
            string password = passwordText.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var user = _userService.Login(username, password);

            // If login is successful, open the user dashboard
            if (user != null)
            {
                var userDashboardForm = new UserDashboardForm(user, _bookService, _borrowService, _userService);
                userDashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}