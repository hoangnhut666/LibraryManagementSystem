using DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL_Services.Validators
{
    public class UserValidator
    {
        public string ErrorMessage { get; private set; } = string.Empty;

        public bool IsValidUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.UserID))
            {
                ErrorMessage = "User ID cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.FullName))
            {
                ErrorMessage = "Full Name cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.RoleID))
            {
                ErrorMessage = "Role cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                ErrorMessage = "Email cannot be empty.";
                return false;
            }

            if (!Regex.IsMatch(user.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ErrorMessage = "Email format is invalid.";
                return false;
            }

            ErrorMessage = string.Empty;
            return true;
        }
    }
}

