/* This service class provides methods to manage user registration and login. */

using RosiesLibraryApp.Data;
using RosiesLibraryApp.Models;

namespace RosiesLibraryApp.Services
{
    public class UserService
    {
        private readonly UserRepository _repo;

        public UserService(UserRepository repo) => _repo = repo;

        // Method to register a new user
        public bool Register(string username, string password, string email, out string errorMessage)
        {
            
            bool success = _repo.Register(username, password, email); 
            errorMessage = success ? "" : "Username already exists.";
            return success; 
        }

        // Method to login a user
        public User? Login(string username, string password)
        { 
            return _repo.Login(username, password); // return the User object if login is successful, otherwise null
        } 
    }
}