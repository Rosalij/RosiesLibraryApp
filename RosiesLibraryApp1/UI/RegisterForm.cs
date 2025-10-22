using RosiesLibraryApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosiesLibraryApp.UI
{
    public partial class RegisterForm : Form
    {
        private readonly UserRepository _userRepo;

        public RegisterForm(UserRepository userRepo)
        {
            InitializeComponent();
            _userRepo = userRepo;
        }

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

            bool success = _userRepo.Register(username, password, email);

            if (success)
            {
                MessageBox.Show("Registration successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists!");
            }
        }

    }
}