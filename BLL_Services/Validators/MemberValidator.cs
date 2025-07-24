using DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;


namespace BLL_Services.Validators
{
    public class MemberValidator
    {
        MemberRepository MemberRepository { get; set; }
        public string? ErrorMessage { get; set; }

        public MemberValidator()
        {
            MemberRepository = new MemberRepository();
            ErrorMessage = null;
        }

        public bool IsValidMember(Member member)
        {
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

            var existingMember = MemberRepository.GetMembersByCriteria("Email", member.Email);
            foreach (var item in existingMember)
            {
                if (item.MemberID != member.MemberID)
                {
                    ErrorMessage = "Email already exists.";
                    return false;
                }
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

            //Check if the join date is not before the date of birth
            if (member.DateOfBirth.HasValue && member.JoinDate < member.DateOfBirth)
            {
                ErrorMessage = "Join date cannot be before the date of birth.";
                return false;
            }

            // Kiểm trang check box nếu không được chọn thì mặc định là "Không hoạt động"
            if (string.IsNullOrWhiteSpace(member.Status))
            {
                member.Status = "Không hoạt động";
            }

            //Check if the photo is not null or empty
            if (member.Photo == null || member.Photo.Length == 0)
            {
                ErrorMessage = "Vui lòng chọn ảnh đại diện.";
                return false;
            }

            return true;
        }

        private bool IsValidPhone(string phone)
        {
            return phone.Length >= 10 && phone.All(char.IsDigit);
        }

        private bool IsValidEmail(string email)
        {
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
