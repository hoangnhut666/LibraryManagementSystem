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
                throw new Exception("Đã xảy ra lỗi khi lấy danh sách người dùng.", ex);
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
                throw new Exception("Đã xảy ra lỗi khi lấy danh sách người dùng.", ex);
            }
        }

        //Search users by search term
        public List<UserViewModel> SearchUsers(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Từ khóa không được để trống.", nameof(searchTerm));
            }
            return UserRepository.SearchUsers(searchTerm);
        }


        // Search users by criteria
        public List<User> SearchUsers(string columnName, string value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Các thuộc tính của người dùng không được để trống.");
            }
            return UserRepository.GetUsersByCriteria(columnName, value);
        }


        // Get user by ID
        public User GetUserById(string userID)
        {
            if (string.IsNullOrWhiteSpace(userID))
            {
                throw new ArgumentException("Mã người dùng không được để trống.", nameof(userID));
            }
            return SearchUsers("UserID", userID).FirstOrDefault() ?? throw new KeyNotFoundException($"Không tìm thấy người dùng với mã {userID}.");
        }


        // Get user by username
        public User GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Tên đăng nhập không được để trống.", nameof(username));
            }
            return SearchUsers("Username", username).FirstOrDefault() ?? throw new KeyNotFoundException($"Không tìm thấy người dùng với tên đăng nhập {username}.");
        }

        // Insert a new user
        public int AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "Người dùng không được để trống.");
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
                throw new ArgumentNullException(nameof(user), "Người dùng không được để trống.");
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
                throw new ArgumentException("Mã người dùng không được để trống.", nameof(userID));
            }
            return UserRepository.Delete(userID);
        }


        
    }
}

