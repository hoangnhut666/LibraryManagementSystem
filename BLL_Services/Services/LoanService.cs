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

        // Get all loan view models
        public List<LoanViewModel> GetLoanViewModels()
        {
            try
            {
                return LoanRepository.GetLoanViewModels();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving loans.", ex);
            }
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

