using System;
using System.Windows.Forms;
using RosiesLibraryApp.Models;

namespace RosiesLibraryApp.UI
{
    public partial class UserDashboardForm : Form
    {
        private readonly User _currentUser;

        public UserDashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            currentUserText.Text = $"Logged in as: {_currentUser.Username}";


        }

        private void rentBookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rent book feature will go here!");
        }

        private void reviewBookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Review book feature will go here!");
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
