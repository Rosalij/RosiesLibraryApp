/*Windows Form for registering a new user */
using RosiesLibraryApp.Services;
using System;
using System.Windows.Forms;

namespace RosiesLibraryApp.UI
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService;
        // Constructor injection of UserService
        public RegisterForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        // Event handler for the Register button click
        private void RegisterNewButton_Click(object sender, EventArgs e)
        {
            string username = newUsernameText.Text.Trim();
            string password = newPasswordText.Text.Trim();
            string email = emailText.Text.Trim();
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            // Attempt to register the new user via the UserService
            if (_userService.Register(username, password, email, out var errorMessage))
            {
                MessageBox.Show("Registration successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}