using DAL_Data;
using DTO_Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Services
{
    public class ReportService
    {
        private readonly ReportRepository BookRepository;
        public ReportService()
        {
            BookRepository = new ReportRepository();
        }
        public List<Top10BooksViewModel> GetTopBorrowedBooks()
        {
            try
            {
                return BookRepository.GetTopBorrowedBooks();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving top borrowed books.", ex);
            }
        }

        public List<Top10ReadersViewModel> GetTopReaders()
        {
            try
            {
                return BookRepository.GetTopReaders();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving top readers.", ex);
            }
        }

        public List<BookReportViewModel> GetBookReportViewModelByCriteria(string column, string value)
        {
            try
            {
                return BookRepository.GetBookReportViewModelByCriteria(column, value);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving book report by {column}.", ex);
            }
        }
    }
}
