using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;
using DTO_Models;
using DTO_Models.ViewModel;
using BLL_Services.Validators;

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
                return EntityRepository.GenerateId("Loans", "LoanID","LOAN");
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while generating a new Loan ID.", ex);
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
                throw new Exception("An error occurred while retrieving loans.", ex);
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
                throw new Exception("An error occurred while retrieving loans.", ex);
            }
        }

        //Get loans by criteria
        public List<Loan> GetLoansByCriteria(string columnName, string? value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Column name and value cannot be null or empty.");
            }
            return LoanRepository.GetLoansByCriteria(columnName, value);
        }


        //Get loan view models by criteria
        public List<LoanViewModel> GetLoanViewModelsByCriteria(string columnName, string? value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Column name and value cannot be null or empty.");
            }
            return LoanRepository.GetLoanViewModelsByCriteria(columnName, value);
        }

        //Search loans by search term
        public List<LoanViewModel> SearchLoansBySearchTerm(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Search term cannot be null or empty.", nameof(searchTerm));
            }
            return LoanRepository.SearchLoans(searchTerm);
        }


        //Add a new loan
        public int AddLoan(Loan loan)
        {
            if (loan == null)
            {
                throw new ArgumentNullException(nameof(loan), "Loan cannot be null.");
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
                throw new ArgumentNullException(nameof(loan), "Loan cannot be null.");
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
                throw new ArgumentException("Loan ID cannot be null or empty.", nameof(loanID));
            }
            return LoanRepository.Delete(loanID);
        }
    }
}

