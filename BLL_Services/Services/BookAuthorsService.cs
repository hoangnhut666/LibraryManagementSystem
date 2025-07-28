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
    public class BookAuthorsService
    {
        private BookAuthorsRepository BookAuthorsRepository { get; set; }
        private BookAuthorValidator BookAuthorsValidator { get; set; }
        public BookAuthorsService()
        {
            BookAuthorsRepository = new BookAuthorsRepository();
            BookAuthorsValidator = new BookAuthorValidator();
        }

        // Get all book-author relationships
        public List<BookAuthor> GetAllBookAuthors()
        {
            try
            {
                return BookAuthorsRepository.GetAllBookAuthors();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi lấy danh sách tác giả sách.", ex);
            }
        }

        // Get book authors by criteria
        public List<BookAuthor> GetBookAuthorsByCriteria(string columnName, string value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tên cột và giá trị không được để trống.");
            }
            try
            {
                return BookAuthorsRepository.GetBookAuthorsByCriteria(columnName, value);
            }
            catch (Exception ex)
            {
                throw new Exception($"Đã xảy ra lỗi khi lấy danh sách tác giả sách theo {columnName}.", ex);
            }
        }


        // Get book author view models
        public List<BookAuthorViewModel> GetBookAuthorViewModels()
        {
            try
            {
                return BookAuthorsRepository.GetBookAuthorViewModels();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi lấy danh sách mô hình tác giả sách.", ex);
            }
        }

        // Insert a new book-author relationship
        public int InsertBookAuthor(BookAuthor bookAuthor)
        {
            if (bookAuthor == null)
            {
                throw new ArgumentNullException(nameof(bookAuthor), "Mối quan hệ sách - tác giả không được để trống.");
            }
            if (!BookAuthorsValidator.IsValidBookAuthor(bookAuthor))
            {
                throw new ArgumentException(BookAuthorsValidator.ErrorMessage, nameof(bookAuthor));
            }
            return BookAuthorsRepository.Insert(bookAuthor);
        }


        // Update an existing book-author relationship
        public int UpdateBookAuthor(BookAuthor bookAuthor)
        {
            if (bookAuthor == null)
            {
                throw new ArgumentNullException(nameof(bookAuthor), "Mối quan hệ sách - tác giả không được để trống.");
            }
            if (!BookAuthorsValidator.IsValidBookAuthor(bookAuthor))
            {
                throw new ArgumentException(BookAuthorsValidator.ErrorMessage, nameof(bookAuthor));
            }
            return BookAuthorsRepository.Update(bookAuthor);
        }

        // Delete a book-author relationship
        public int DeleteBookAuthor(string bookAuthorID)
        {
            if (string.IsNullOrWhiteSpace(bookAuthorID))
            {
                throw new ArgumentException("Mã tác giả sách không được để trống.", nameof(bookAuthorID));
            }
            return BookAuthorsRepository.Delete(bookAuthorID);
        }
    }
}

