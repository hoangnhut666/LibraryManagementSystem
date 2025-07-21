using DAL_Data;
using DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BLL_Services.Validators
{
    public class MemberValidator
    {
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Validates the given Member object by checking required fields and applying various validation rules.
        /// Sets an appropriate error message if validation fails.
        /// </summary>
        /// <param name="member">The Member object to validate.</param>
        /// <returns>True if all validation checks pass; otherwise, false.</returns>
        public bool IsvaliMember(Member member)
        {
            //When the user does not enter information, no check will be performed and an error message.
            if (string.IsNullOrWhiteSpace(member.FullName) &&
            string.IsNullOrWhiteSpace(member.Email) &&
            string.IsNullOrWhiteSpace(member.Phone) &&
            member.Photo == null)
            {
                ErrorMessage = "Please enter member information.";
                return false;
            }

            // Address is required
            if (string.IsNullOrWhiteSpace(member.Address))
            {
                ErrorMessage = "Address cannot be empty.";
                return false;
            }

            // Check if the member ID is not empty
            if (string.IsNullOrWhiteSpace(member.MemberID))
            {
                ErrorMessage = "Member ID cannot be empty.";
                return false;
            }

            // Check if the member ID length is between 5 and 10 characters
            if (member.MemberID.Length < 5 || member.MemberID.Length > 10)
            {
                ErrorMessage = "Member ID must be between 5 and 10 characters.";
                return false;
            }

            // Check if the full name is not empty
            if (string.IsNullOrWhiteSpace(member.FullName))
            {
                ErrorMessage = "Full name cannot be empty.";
                return false;
            }

            // Email is required
            if (string.IsNullOrWhiteSpace(member.Email))
            {
                ErrorMessage = "Email cannot be empty.";
                return false;
            }

            //Check if the email duplicate
            MemberRepository MemberRepository = new MemberRepository();
            if (MemberRepository.IsEmailExists(member.Email, member.MemberID))
            {
                ErrorMessage = "Email already exists.";
                return false;
            }

            // Check if the email is valid
            if (!string.IsNullOrWhiteSpace(member.Email) && !IsValidEmail(member.Email))
            {
                ErrorMessage = "Invalid email format.";
                return false;
            }

            // Phone number is required
            if (string.IsNullOrWhiteSpace(member.Phone))
            {
                ErrorMessage = "Phone number cannot be empty.";
                return false;
            }

            // Check if the phone number is valid
            if (!string.IsNullOrWhiteSpace(member.Phone) && !IsValidPhone(member.Phone))
            {
                ErrorMessage = "Invalid phone number format.";
                return false;
            }

            // Check if the date of birth is not in the future
            if (member.DateOfBirth.HasValue && member.DateOfBirth > DateTime.Now)
            {
                ErrorMessage = "Date of birth cannot be in the future.";
                return false;
            }

            // Check if the join date is not in the future
            if (member.JoinDate > DateTime.Now)
            {
                ErrorMessage = "Join date cannot be in the future.";
                return false;
            }

            // Kiểm trang check box nếu không được chọn thì mặc định là "Không hoạt động"
            if (string.IsNullOrWhiteSpace(member.Status))
            {
                member.Status = "Không hoạt động";
            }

            // Check if the photo is not null or empty
            if (member.Photo == null || member.Photo.Length == 0)
            {
                ErrorMessage = "Vui lòng chọn ảnh đại diện.";
                return false;
            }

            // If all checks pass, return true
            return true;
        }

        /// <summary>
        /// Validates the phone number format.
        /// The phone number is considered valid if it contains only digits and has at least 10 characters.
        /// </summary>
        /// <param name="phone">The phone number string to validate.</param>
        /// <returns>True if the phone number is valid; otherwise, false.</returns>
        private bool IsValidPhone(string phone)
        {
            // A simple phone validation logic (can be improved)
            return phone.Length >= 10 && phone.All(char.IsDigit);
        }

        /// <summary>
        /// Validates the email format using System.Net.Mail.MailAddress.
        /// The email is considered valid if it can be parsed without throwing an exception,
        /// and the parsed address matches the original input.
        /// </summary>
        /// <param name="email">The email address to validate.</param>
        /// <returns>True if the email format is valid; otherwise, false.</returns>
        private bool IsValidEmail(string email)
        {
            // A simple email validation using .NET built-in MailAddress class
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
