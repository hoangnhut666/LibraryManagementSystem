using DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Validators
{
    public class LoanValidator
    {
        public string ErrorMessage { get; private set; }
        public LoanValidator()
        {
            ErrorMessage = string.Empty;
        }

        public bool IsValidLoan(Loan loan)
        {
            // Check if CopyID is not empty
            if (string.IsNullOrWhiteSpace(loan.CopyID))
            {
                ErrorMessage = "Mã bản sao không được để trống.";
                return false;
            }
            // Check if MemberID is not empty
            if (string.IsNullOrWhiteSpace(loan.MemberID))
            {
                ErrorMessage = "Mã thành viên không được để trống.";
                return false;
            }
            // Check if LoanDate is not in the future
            if (loan.LoanDate > DateTime.Now)
            {
                ErrorMessage = "Ngày mượn không được lớn hơn ngày hiện tại.";
                return false;
            }
            // Check if DueDate is not before LoanDate
            if (loan.DueDate < loan.LoanDate)
            {
                ErrorMessage = "Ngày đến hạn không được trước ngày mượn.";
                return false;
            }
            // If ReturnDate is set, check if it is not before LoanDate or DueDate
            if (loan.ReturnDate.HasValue && (loan.ReturnDate < loan.LoanDate || loan.ReturnDate < loan.DueDate))
            {
                ErrorMessage = "Ngày trả không được trước ngày mượn hoặc ngày đến hạn.";
                return false;
            }
            return true;
        }
    }
}
