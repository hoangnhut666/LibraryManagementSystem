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
                ErrorMessage = "Mật khẩu hiện tại không được để trống.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                ErrorMessage = "Mật khẩu mới không được để trống.";
                return false;
            }
            if (newPassword.Length < 6)
            {
                ErrorMessage = "Mật khẩu mới phải có ít nhất 6 ký tự.";
                return false;
            }
            if (newPassword != confirmNewPassword)
            {
                ErrorMessage = "Mật khẩu mới và xác nhận không khớp.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(userName))
            {
                ErrorMessage = "Tên đăng nhập không được để trống.";
                return false;
            }

            // Check if the current password is correct
            var user = UserService.GetUserByUsername(userName);
            if (user == null)
            {
                ErrorMessage = "Người dùng không tồn tại.";
                return false;
            }
            if (!SecurityService.VerifyPassword(currentPassword, user.Password))
            {
                ErrorMessage = "Mật khẩu hiện tại không chính xác.";
                return false;
            }
            ErrorMessage = string.Empty; 
            return true;
        }
    }
}
