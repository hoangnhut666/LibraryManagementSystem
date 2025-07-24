using BLL_Services.Services;
using DAL_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Validators
{
    public class ChangePasswordValidator
    {
        private UserService UserService { get; set; }
        private SecurityService SecurityService { get; set; }
        public ChangePasswordValidator()
        {
            UserService = new UserService();
            SecurityService = new SecurityService();
        }
        public string ErrorMessage { get; set; } = string.Empty;
        public bool IsValidPassword(string userName ,string currentPassword, string newPassword, string confirmNewPassword)
        {
            if (string.IsNullOrWhiteSpace(currentPassword))
            {
                ErrorMessage = "Current password is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                ErrorMessage = "New password is required.";
                return false;
            }
            if (newPassword.Length < 6)
            {
                ErrorMessage = "New password must be at least 6 characters long.";
                return false;
            }
            if (newPassword != confirmNewPassword)
            {
                ErrorMessage = "New password and confirmation do not match.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(userName))
            {
                ErrorMessage = "Username is required.";
                return false;
            }

            // Check if the current password is correct
            var user = UserService.GetUserByUsername(userName);
            if (user == null)
            {
                ErrorMessage = "User not found.";
                return false;
            }
            if (!SecurityService.VerifyPassword(currentPassword, user.Password))
            {
                ErrorMessage = "Current password is incorrect.";
                return false;
            }
            ErrorMessage = string.Empty; 
            return true;
        }
    }
}
