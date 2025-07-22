using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;
using DTO_Models;
using DTO_Models.ViewModel;

namespace BLL_Services.Services
{
    public class BookAuthorsService
    {
        private BookAuthorsRepository BookAuthorsRepository { get; set; }
        public BookAuthorsService()
        {
            BookAuthorsRepository = new BookAuthorsRepository();
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
                throw new Exception("An error occurred while retrieving book authors.", ex);
            }
        }

        // Get book authors by criteria
        public List<BookAuthor> GetBookAuthorsByCriteria(string columnName, string value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Column name and value cannot be null or empty.");
            }
            try
            {
                return BookAuthorsRepository.GetBookAuthorsByCriteria(columnName, value);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving book authors by {columnName}.", ex);
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
                throw new Exception("An error occurred while retrieving book author view models.", ex);
            }
        }

        // Insert a new book-author relationship
        public int InsertBookAuthor(BookAuthor bookAuthor)
        {
            if (bookAuthor == null)
            {
                throw new ArgumentNullException(nameof(bookAuthor), "Book author cannot be null.");
            }
            try
            {
                return BookAuthorsRepository.Insert(bookAuthor);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while inserting the book author.", ex);
            }
        }


        // Update an existing book-author relationship
        public int UpdateBookAuthor(BookAuthor bookAuthor)
        {
            if (bookAuthor == null)
            {
                throw new ArgumentNullException(nameof(bookAuthor), "Book author cannot be null.");
            }
            try
            {
                return BookAuthorsRepository.Update(bookAuthor);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the book author.", ex);
            }
        }

        // Delete a book-author relationship
        public int DeleteBookAuthor(int bookAuthorId)
        {
            if (bookAuthorId <= 0)
            {
                throw new ArgumentException("Book author ID must be greater than zero.", nameof(bookAuthorId));
            }
            try
            {
                return BookAuthorsRepository.Delete(bookAuthorId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the book author.", ex);
            }
        }
    }
}
