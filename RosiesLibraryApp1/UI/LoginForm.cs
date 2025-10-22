using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosiesLibraryApp.Data;


namespace RosiesLibraryApp.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepo;

        public LoginForm()
        {
            InitializeComponent();

            //Initialize database and user repository
            var db = new Database("library.db");
            _userRepo = new UserRepository(db);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_userRepo);
            registerForm.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text.Trim();
            string password = passwordText.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var user = _userRepo.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {username}!");
                               var userDashboardForm = new UserDashboardForm(user);
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