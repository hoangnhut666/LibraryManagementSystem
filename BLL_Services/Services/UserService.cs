using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;
using DTO_Models.ViewModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL_Services.Services
{
    public class UserService
    {
        private UserRepository UserRepository { get; set; }
        private UserValidator UserValidator { get; set; }
        public UserService()
        {
            UserRepository = new UserRepository();
            UserValidator = new UserValidator();
        }

        // Auto-generate UserID
        public string GenerateUserID()
        {
            return EntityRepository.GenerateId("Users", "UserID", "USER");
        }

        //Get user view models
        public List<UserViewModel> GetUserViewModels()
        {
            try
            {
                return UserRepository.GetUserViewModels();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving user view models.", ex);
            }
        }

        // Get all users
        public List<User> GetUsers()
        {
            try
            {
                return UserRepository.GetAllUsers();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving users.", ex);
            }
        }

        //Search users by search term
        public List<UserViewModel> SearchUsers(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Search term cannot be null or empty.", nameof(searchTerm));
            }
            return UserRepository.SearchUsers(searchTerm);
        }


        // Search users by criteria
        public List<User> SearchUsers(string columnName, string value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Column name and value cannot be null or empty.");
            }
            return UserRepository.GetUsersByCriteria(columnName, value);
        }


        // Get user by ID
        public User GetUserById(string userID)
        {
            if (string.IsNullOrWhiteSpace(userID))
            {
                throw new ArgumentException("User ID cannot be null or empty.", nameof(userID));
            }
            return SearchUsers("UserID", userID).FirstOrDefault() ?? throw new KeyNotFoundException($"User with ID {userID} not found.");
        }


        // Insert a new user
        public int AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null.");
            }
            if (!UserValidator.IsValidUser(user))
            {
                throw new ArgumentException(UserValidator.ErrorMessage, nameof(user));
            }
            return UserRepository.Insert(user);
        }

        // Update an existing user
        public int UpdateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null.");
            }
            if (!UserValidator.IsValidUser(user))
            {
                throw new ArgumentException(UserValidator.ErrorMessage, nameof(user));
            }
            return UserRepository.Update(user);
        }


        // Delete a user
        public int DeleteUser(string userID)
        {
            if (string.IsNullOrWhiteSpace(userID))
            {
                throw new ArgumentException("User ID cannot be null or empty.", nameof(userID));
            }
            return UserRepository.Delete(userID);
        }
    }
}

