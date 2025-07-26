using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models;

namespace BLL_Services.Validators
{
    public class FineValidator
    {
        public string ErrorMessage { get; set; } = string.Empty;
        public bool IsValidFine(Fine fine)
        {
            if (fine == null)
            {
                ErrorMessage = "Không có thông tin phạt.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(fine.FineID))
            {
                ErrorMessage = "Không có ID phạt.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(fine.LoanID))
            {
                ErrorMessage = "Không có mã phiếu mượn.";
                return false;
            }
            if (fine.Amount <= 0)
            {
                ErrorMessage = "Số tiền phạt phải lớn hơn 0.";
                return false;
            }
            if (fine.IssueDate > DateTime.Now)
            {
                ErrorMessage = "Ngày phạt không được ở tương lai.";
                return false;
            }
            if (!decimal.TryParse(fine.Amount.ToString(), out _))
            {
                ErrorMessage = "Số tiền phạt phải là một số lớn hơn 0";
                return false;
            }
            return true;
        }
    }
}
