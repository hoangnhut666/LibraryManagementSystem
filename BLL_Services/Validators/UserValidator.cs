using DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL_Data;
using BLL_Services.Services;

namespace BLL_Services.Validators
{
    public class UserValidator
    {
        public string ErrorMessage { get; private set; } = string.Empty;
        public UserRepository UserRepository { get; set; } 

        public UserValidator()
        {
            UserRepository = new UserRepository();
        }

        public bool IsValidUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.UserID))
            {
                ErrorMessage = "Mã người dùng không được để trống.";
                return false;
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                ErrorMessage = "Mật khẩu không được để trống";
            }

            var existingUserWithTheSameEmail = UserRepository.GetUsersByCriteria("Email", user.Email);
            if (existingUserWithTheSameEmail.Count > 0 && existingUserWithTheSameEmail[0].UserID != user.UserID)
            {
                ErrorMessage = "Email đã được sử dụng bởi người dùng khác.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.FullName))
            {
                ErrorMessage = "Họ và tên không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.RoleID))
            {
                ErrorMessage = "Vai trò không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                ErrorMessage = "Email không được để trống.";
                return false;
            }


            if (!Regex.IsMatch(user.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ErrorMessage = "Định dạng email không hợp lệ.";
                return false;
            }

            ErrorMessage = string.Empty;
            return true;
        }
    }
}

