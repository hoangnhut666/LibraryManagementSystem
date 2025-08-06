using BLL_Services.Services;
using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;
using DTO_Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Services
{
    public class LoanService
    {
        private LoanRepository LoanRepository { get; set; }
        private LoanValidator LoanValidator { get; set; }

        public LoanService()
        {
            LoanRepository = new LoanRepository();
            LoanValidator = new LoanValidator();
        }

        //Auto generate a new Loan ID
        public string GenerateNewLoanID()
        {
            try
            {
                return EntityRepository.GenerateId("Loans", "LoanID", "LOAN");
            }
            catch (Exception ex)
            {
                throw new Exception("Một lỗi xảy ra khi tạo mã khoản vay mới.", ex);
            }
        }

        // Get all loans
        public List<Loan> GetAllLoans()
        {
            try
            {
                return LoanRepository.GetAllLoans();
            }
            catch (Exception ex)
            {
                throw new Exception("Một lỗi xảy ra khi lấy danh sách khoản vay.", ex);
            }
        }

        // Get all loan view models
        public List<LoanViewModel> GetLoanViewModels()
        {
            try
            {
                return LoanRepository.GetAllLoanViewModels();
            }
            catch (Exception ex)
            {
                throw new Exception("Một lỗi xảy ra khi lấy danh sách khoản vay.", ex);
            }
        }

        //Get loans by criteria
        public List<Loan> GetLoansByCriteria(string columnName, string? value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tên cột và giá trị không được để trống.");
            }
            return LoanRepository.GetLoansByCriteria(columnName, value);
        }


        //Get loan view models by criteria
        public List<LoanViewModel> GetLoanViewModelsByCriteria(string columnName, string? value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tên cột và giá trị không được để trống.");
            }
            return LoanRepository.GetLoanViewModelsByCriteria(columnName, value);
        }

        //Search loans by search term
        public List<LoanViewModel> SearchLoansBySearchTerm(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Tiêu chí tìm kiếm không được để trống.", nameof(searchTerm));
            }
            return LoanRepository.SearchLoans(searchTerm);
        }


        //Add a new loan
        public int AddLoan(Loan loan)
        {
            if (loan == null)
            {
                throw new ArgumentNullException(nameof(loan), "Phiếu mượn không được để trống.");
            }
            if (!LoanValidator.IsValidLoan(loan))
            {
                throw new ArgumentException(LoanValidator.ErrorMessage, nameof(loan));
            }
            return LoanRepository.Insert(loan);
        }

        // Update an existing loan
        public int UpdateLoan(Loan loan)
        {
            if (loan == null)
            {
                throw new ArgumentNullException(nameof(loan), "Phiếu mượn không được để trống.");
            }
            if (!LoanValidator.IsValidLoan(loan))
            {
                throw new ArgumentException(LoanValidator.ErrorMessage, nameof(loan));
            }
            return LoanRepository.Update(loan);
        }

        // Delete a loan
        public int DeleteLoan(string loanID)
        {
            if (string.IsNullOrWhiteSpace(loanID))
            {
                throw new ArgumentException("Mã khoản vay không được để trống.", nameof(loanID));
            }
            return LoanRepository.Delete(loanID);
        }


        //Auto update loan status if the loan have overdue
        public void AutoUpdateLoanStatus(Loan loan)
        {
            if (loan == null)
            {
                throw new ArgumentNullException(nameof(loan), "Phiếu mượn không được để trống.");
            }
            int overdueDays = CalculateDaysOverdue(loan);
            if (overdueDays > 0)
            {
                loan.Status = "Quá hạn";
            }
            else if (loan.ReturnDate != default(DateTime) && loan.ReturnDate.Value <= loan.DueDate)
            {
                loan.Status = "Đã trả";
            }
            else
            {
                loan.Status = "Đang mượn";
            }
            UpdateLoan(loan);
        }


        // Calculate the number of days overdue for a loan
        public int CalculateDaysOverdue(Loan loan)
        {
            if (loan == null)
            {
                throw new ArgumentNullException(nameof(loan), "Phiếu mượn không được để trống.");
            }
            if (loan.ReturnDate == null)
            {
                throw new ArgumentException("Ngày trả không được để trống.");
            }
            DateTime returnDate = loan.ReturnDate.Value;
            DateTime dueDate = loan.DueDate;
            if (returnDate <= dueDate)
            {
                return 0;
            }
            return (returnDate - dueDate).Days;
        }
    }
}
