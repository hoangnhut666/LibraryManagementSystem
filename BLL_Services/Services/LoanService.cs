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


    }
}
