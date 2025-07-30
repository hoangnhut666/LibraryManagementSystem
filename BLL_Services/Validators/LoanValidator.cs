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
            if (loan == null)
            {
                ErrorMessage = "Phiếu mượn không được để trống.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(loan.Status))
            {
                ErrorMessage = "Trạng thái phiếu không được để trống";
                return false;
            }
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

            if (loan.LoanDate == default(DateTime))
            {
                ErrorMessage = "Ngày mượn không được để trống.";
                return false;
            }
            if (loan.DueDate == default(DateTime))
            {
                ErrorMessage = "Ngày đến hạn không được để trống.";
                return false;
            }
            if (loan.DueDate != default(DateTime) && loan.DueDate < loan.LoanDate)
            {
                ErrorMessage = "Ngày đến hạn không được trước ngày mượn.";
                return false;
            }
            if (loan.ReturnDate != default(DateTime) && loan.ReturnDate < loan.LoanDate)
            {
                ErrorMessage = "Ngày trả không được trước ngày mượn";
                return false;
            }
            if (loan.Status == "Đã trả" && loan.ReturnDate == default(DateTime))
            {
                ErrorMessage = "Một phiếu mượn đã trả phải có thông tin ngày trả";
                return false;
            }
            if (loan.Status == "Đang mượn" && loan.ReturnDate != default(DateTime))
            {
                ErrorMessage = "Một phiếu mượn đang mượn không thể có thông tin ngày trả";
                return false;
            }
            if (loan.Status == "Quá hạn" && loan.ReturnDate < loan.DueDate)
            {
                ErrorMessage = "Một phiếu mượn quá hạn phải có ngày trả lớn hơn ngày đến hạn";
                return false;
            }
            if (loan.Status == "Thất lạc" && loan.ReturnDate != default(DateTime))
            {
                ErrorMessage = "Một phiếu mượn thất lạc không thể có thông tin ngày trả";
                return false;
            }
            return true;
        }
    }
}



