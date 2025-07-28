using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;
using DTO_Models.ViewModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Services
{
    public class BookCopyService
    {
        private BookCopyRepository BookCopyRepository { get; set; }
        private BookCopyValidator BookCopyValidator { get; set; }

        public BookCopyService()
        {
            BookCopyRepository = new BookCopyRepository();
            BookCopyValidator = new BookCopyValidator();
        }

        // Get all book copies from the repository
        public List<BookCopy> GetAllBookCopies()
        {
            try
            {
                return BookCopyRepository.GetAllBookCopies();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi lấy danh sách bản sao sách.", ex);
            }
        }

        //Auto-generate CopyID
        public string GenerateCopyID()
        {
            return EntityRepository.GenerateId("BookCopies", "CopyID", "COPY");
        }


        //Search book copies by stored procedure
        public List<BookCopyViewModel> SearchBookCopies(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Từ khóa không được để trống.", nameof(searchTerm));
            }
            return BookCopyRepository.GetBookCopiesByStoredProcedure("SearchBookCopies", new SqlParameter("@SearchTerm", searchTerm));
        }

        // Search book copies by criteria
        public List<BookCopy> SearchBookCopies(string columnName, string value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tên cột và giá trị không được để trống.");
            }
            return BookCopyRepository.GetBookCopiesByCriteria(columnName, value);
        }


        // Get book copies view models
        public List<BookCopyViewModel> GetBookCopiesViewModels()
        {
            try
            {
                return BookCopyRepository.GetBookCopiesViewModels();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi lấy danh sách mô hình bản sao sách.", ex);
            }
        }


        // Add a new book copy
        public int AddBookCopy(BookCopy bookCopy)
        {
            if (bookCopy == null)
            {
                throw new ArgumentNullException(nameof(bookCopy), "Bản sao sách không được để trống.");
            }
            if (!BookCopyValidator.IsValidBookCopy(bookCopy))
            {
                throw new ArgumentException(BookCopyValidator.ErrorMessage, nameof(bookCopy));
            }
            return BookCopyRepository.Insert(bookCopy);
        }



        // Update an existing book copy
        public int UpdateBookCopy(BookCopy bookCopy)
        {
            if (bookCopy == null)
            {
                throw new ArgumentNullException(nameof(bookCopy), "Bản sao sách không được để trống.");
            }
            if (!BookCopyValidator.IsValidBookCopy(bookCopy))
            {
                throw new ArgumentException(BookCopyValidator.ErrorMessage, nameof(bookCopy));
            }
            return BookCopyRepository.Update(bookCopy);
        }


        // Delete a book copy
        public int DeleteBookCopy(string copyID)
        {
            if (string.IsNullOrWhiteSpace(copyID))
            {
                throw new ArgumentException("Mã bản sao không được để trống.", nameof(copyID));
            }
            return BookCopyRepository.Delete(copyID);
        }
    }
}



