using DAL_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Validators
{
    public class LoginValidator
    {
        public string ErrorMessage { get; private set; } = string.Empty;
        private UserRepository UserRepository { get; set; }
        public LoginValidator() { 
            UserRepository = new UserRepository();
        }
        public bool Validate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                ErrorMessage = "Tên đăng nhập không được để trống.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                ErrorMessage = "Mật khẩu không được để trống.";
                return false;
            }
            if (username.Length < 3 || username.Length > 20)
            {
                ErrorMessage = "Tên đăng nhập phải có độ dài từ 3 đến 20 ký tự.";
                return false;
            }
            if (password.Length < 6 || password.Length > 100)
            {
                ErrorMessage = "Mật khẩu phải có độ dài từ 6 đến 100 ký tự.";
                return false;
            }

            var users = UserRepository.GetUsersByCriteria("Username", username);
            if (users.Count == 0)
            {
                ErrorMessage = "Tên đăng nhập không tồn tại.";
                return false;
            }
            var user = users.FirstOrDefault();
            if (user != null && !user.IsActive)
            {
                ErrorMessage = "Tài khoản của bạn đã bị khóa.";
                return true;
            }

            ErrorMessage = string.Empty;
            return true;
        }
    }
}
