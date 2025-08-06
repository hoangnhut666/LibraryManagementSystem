using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;
using BLL_Services.Validators;
using DTO_Models;
using DTO_Models.ViewModel;


namespace BLL_Services.Services
{
    public class FineService
    {
        private FineRepository FineRepository { get; set; }
        private FineValidator FineValidator { get; set; }
        private LoanService LoanService { get; set; }
        public FineService()
        {
            FineRepository = new FineRepository();
            FineValidator = new FineValidator();
            LoanService = new LoanService();
        }

        //Auto-generate FineID
        public string GenerateFineID()
        {
            return EntityRepository.GenerateId("Fines", "FineID", "FINE");
        }

        // Get all fines
        public List<Fine> GetAllFines()
        {
            try
            {
                return FineRepository.GetAllFines();
            }
            catch (Exception ex)
            {
                throw new Exception("Một lỗi xảy ra khi lấy danh sách khoản phạt.", ex);
            }
        }

        //Search fines by search term
        public List<FineViewModel> SearchFineBySearchTerm(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Tiêu chí tìm kiếm không được để trống.", nameof(searchTerm));
            }
            try
            {
                return FineRepository.SearchFines(searchTerm);
            }
            catch (Exception ex)
            {
                throw new Exception("Một lỗi xảy ra khi tìm kiếm khoản phạt.", ex);
            }
        }

        public List<Fine> GetFinesByCriteria(string columnName, string? value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tên cột và giá trị không được để trống.");
            }
            try
            {
                return FineRepository.GetFinesByCriteria(columnName, value);
            }
            catch (Exception ex)
            {
                throw new Exception($"Một lỗi xảy ra khi lấy danh sách khoản phạt theo {columnName}.", ex);
            }
        }

        //Get fine by ID
        public Fine? GetFineById(string fineId)
        {
            if (string.IsNullOrWhiteSpace(fineId))
            {
                throw new ArgumentException("Mã khoản phạt không được để trống.");
            }
            try
            {
                return FineRepository.GetFineById(fineId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Một lỗi đã xảy ra khi lấy khoản phạt với mã {fineId}.", ex);
            }
        }


        //Get fines view models
        public List<FineViewModel> GetFineViewModels()
        {
            try
            {
                return FineRepository.GetFineViewModels();
            }
            catch (Exception ex)
            {
                throw new Exception("Một lỗi đã xảy ra khi lấy danh sách các khoản phạt.", ex);
            }
        }

        // Add a new fine
        public int AddFine(Fine fine)
        {
            if (!FineValidator.IsValidFine(fine))
            {
                throw new ArgumentException(FineValidator.ErrorMessage);
            }
            return FineRepository.Insert(fine);
        }

        // Update an existing fine
        public int UpdateFine(Fine fine)
        {
            if (!FineValidator.IsValidFine(fine))
            {
                throw new ArgumentException(FineValidator.ErrorMessage);
            }
            return FineRepository.Update(fine);
        }

        // Delete a fine
        public int DeleteFine(string fineId)
        {
            if (string.IsNullOrWhiteSpace(fineId))
            {
                throw new ArgumentException("Mã khoản phạt không được để trống.");
            }
            return FineRepository.Delete(fineId);
        }


        //Automaticly update fine for overdue loans
        public void AutoUpdateFines()
        {
            var overdueLoans = LoanService.GetLoansByCriteria("Status", "Quá hạn");
            var overdueFines = FineRepository.GetFinesByCriteria("Reason", "Quá hạn");

            foreach (var overdueLoan in overdueLoans)
            {
                int overdueDays = LoanService.CalculateDaysOverdue(overdueLoan);
                if (overdueFines.Any(f => f.LoanID == overdueLoan.LoanID))
                {
                    var existingFine = overdueFines.First(f => f.LoanID == overdueLoan.LoanID);

                    if (existingFine.Paid == true)
                    {
                        continue;
                    }

                    if (overdueDays > 0)
                    {
                        decimal fineAmount = overdueDays * 5000;
                        existingFine.Amount = fineAmount;
                        existingFine.IssueDate = DateTime.Now;
                        existingFine.Paid = false;
                        existingFine.Reason = $"Quá hạn";
                        if (UpdateFine(existingFine) <= 0)
                        {
                            throw new Exception("Không thể cập nhật khoản phạt tự động.");
                        }
                    }
                }
                else 
                {
                    if (overdueDays > 0)
                    {
                        decimal fineAmount = overdueDays * 5000;
                        Fine fine = new Fine
                        {
                            FineID = GenerateFineID(),
                            LoanID = overdueLoan.LoanID,
                            Amount = fineAmount,
                            IssueDate = DateTime.Now,
                            Paid = false,
                            Reason = $"Quá hạn"
                        };
                        if (AddFine(fine) <= 0)
                        {
                            throw new Exception("Không thể thêm khoản phạt tự động.");
                        }
                    }
                }
            }
        }


    }
}
