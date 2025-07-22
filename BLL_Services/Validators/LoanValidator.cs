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
                ErrorMessage = "Copy ID cannot be empty.";
                return false;
            }
            // Check if MemberID is not empty
            if (string.IsNullOrWhiteSpace(loan.MemberID))
            {
                ErrorMessage = "Member ID cannot be empty.";
                return false;
            }
            // Check if LoanDate is not in the future
            if (loan.LoanDate > DateTime.Now)
            {
                ErrorMessage = "Loan date cannot be in the future.";
                return false;
            }
            // Check if DueDate is not before LoanDate
            if (loan.DueDate < loan.LoanDate)
            {
                ErrorMessage = "Due date cannot be before loan date.";
                return false;
            }
            // If ReturnDate is set, check if it is not before LoanDate or DueDate
            if (loan.ReturnDate.HasValue && (loan.ReturnDate < loan.LoanDate || loan.ReturnDate < loan.DueDate))
            {
                ErrorMessage = "Return date cannot be before loan date or due date.";
                return false;
            }
            return true;
        }
    }
}
