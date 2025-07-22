using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Services
{

    public class BookService
    {
        private BookRepository BookRepository { get; set; }
        private BookValidator BookValidator { get; set; }

        public BookService()
        {
            BookRepository = new BookRepository();
            BookValidator = new BookValidator();
        }

        //Auto-generate AuthorID
        public string GenerateBookID()
        {
            return EntityRepository.GenerateId("Books", "BookID", "BOOK");
        }

        // Get all books from the repository
        public List<Book> GetBooks()
        {
            try
            {
                return BookRepository.GetAllBooks();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving books.", ex);
            }
        }

        // Search books by stored procedure
        public List<Book> SearchBooks(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Search term cannot be null or empty.", nameof(searchTerm));
            }
            return BookRepository.GetBooksByStoredProcedure("SearchBooks", new SqlParameter("@SearchTerm", searchTerm));
        }


        // Add a new book
        public int AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            }
            if (!BookValidator.IsValidBook(book))
            {
                throw new ArgumentException(BookValidator.ErrorMessage, nameof(book));
            }
            return BookRepository.Insert(book);
        }

        // Update an existing book
        public int UpdateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            }
            if (!BookValidator.IsValidBook(book))
            {
                throw new ArgumentException(BookValidator.ErrorMessage, nameof(book));
            }
            return BookRepository.Update(book);
        }


        // Delete a book
        public int DeleteBook(string bookID)
        {
            if (string.IsNullOrWhiteSpace(bookID))
            {
                throw new ArgumentException("Book ID cannot be null or empty.", nameof(bookID));
            }
            return BookRepository.Delete(bookID);
        }

        //Get the book cover image with the given book ID
        public byte[]? GetBookCoverImage(string bookID)
        {
            if (string.IsNullOrWhiteSpace(bookID))
            {
                throw new ArgumentException("Book ID cannot be null or empty.", nameof(bookID));
            }
            return BookRepository.GetBookCoverImage(bookID);
        }
    }
}


