using DBUTIL_Utilities;
using DTO_Models;
using DTO_Models.ViewModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data
{
    public class UserRepository
    {
        // Get all users
        public List<User> GetAllUsers()
        {
            string sql = "SELECT * FROM Users ORDER BY UserID DESC";
            List<User> users = Utilities.ExecuteQuery(sql, reader =>
            {
                return new User
                {
                    UserID = reader["UserID"].ToString(),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),
                    Email = reader["Email"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    RoleID = reader["RoleID"].ToString(),
                    IsActive = (bool)reader["IsActive"]
                };
            });
            return users;
        }

        // Get users by criteria
        public List<User> GetUsersByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM Users WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<User> users = Utilities.ExecuteQuery(sql, reader =>
            {
                return new User
                {
                    UserID = reader["UserID"].ToString(),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),
                    Email = reader["Email"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    RoleID = reader["RoleID"].ToString(),
                    IsActive = (bool)reader["IsActive"]
                };
            }, parameters);
            return users;
        }


        // Get user view models
        public List<UserViewModel> GetUserViewModels()
        {
            string sql = @"
            SELECT
                u.UserID,
                u.FullName,
                r.RoleName
            FROM Users u
            JOIN Roles r ON r.RoleID = u.RoleID
            ORDER BY u.UserID DESC";
            List<UserViewModel> users = Utilities.ExecuteQuery(sql, reader =>
            {
                return new UserViewModel
                {
                    MaNguoiDung = reader["UserID"].ToString(),
                    HoVaTen = reader["FullName"].ToString(),
                    VaiTro = reader["RoleName"].ToString()
                };
            });
            return users;
        }

        //Search users by search term
        public List<UserViewModel> SearchUsers(string searchTerm)
        {
            string sql = @"
                SELECT 
                    u.UserID,
                    u.FullName,
                    r.RoleName
                FROM Users u
                JOIN Roles r ON r.RoleID = u.RoleID
                WHERE 
                    @SearchTerm IS NULL OR
                    u.UserID LIKE '%' + @SearchTerm + '%' OR
                    u.FullName LIKE '%' + @SearchTerm + '%' OR
                    r.RoleName LIKE '%' + @SearchTerm + '%' OR
                    u.Email LIKE '%' + @SearchTerm + '%' OR
                    u.Username LIKE '%' + @SearchTerm + '%'
                ORDER BY u.UserID DESC;
            ";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@SearchTerm", string.IsNullOrEmpty(searchTerm) ? (object)DBNull.Value : searchTerm)
            };

            List<UserViewModel> users = Utilities.ExecuteQuery(sql, reader =>
            {
                return new UserViewModel
                {
                    MaNguoiDung = reader["UserID"].ToString(),
                    HoVaTen = reader["FullName"].ToString(),
                    VaiTro = reader["RoleName"].ToString()
                };
            }, parameters);

            return users;
        }

        //Insert a new user
        public int Insert(User user)
        {
            string sql = "INSERT INTO Users (UserID, Username, Password, Email, FullName, RoleID, IsActive) " +
                         "VALUES (@UserID, @Username, @Password, @Email, @FullName, @RoleID, @IsActive)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", user.UserID),
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@FullName", user.FullName),
                new SqlParameter("@RoleID", user.RoleID),
                new SqlParameter("@IsActive", user.IsActive)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        // Update an existing user
        public int Update(User user)
        {
            string sql = "UPDATE Users SET Username = @Username, Password = @Password, Email = @Email, " +
                         "FullName = @FullName, RoleID = @RoleID, IsActive = @IsActive " +
                         "WHERE UserID = @UserID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", user.UserID),
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@FullName", user.FullName),
                new SqlParameter("@RoleID", user.RoleID),
                new SqlParameter("@IsActive", user.IsActive)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        // Delete a user
        public int Delete(string userID)
        {
            string sql = "DELETE FROM Users WHERE UserID = @UserID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Get hash password with username
        public string? GetHashPassword(string username)
        {
            string sql = "SELECT Password FROM Users WHERE Username = @Username";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };
            List<string?> passwords = Utilities.ExecuteQuery(sql, reader => reader["Password"]?.ToString(), parameters);
            return passwords.FirstOrDefault() ?? string.Empty;
        }

        //Update password
        public int UpdateUserPassword(string userName, string newPassword)
        {
            string sql = "UPDATE Users SET Password = @Password WHERE Username = @Username";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", userName),
                new SqlParameter("@Password", newPassword)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);

        }
    }
}


