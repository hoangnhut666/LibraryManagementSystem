using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models;
using DAL_Data;

namespace BLL_Services.Validators
{
    public class BookAuthorValidator
    {
        public string? ErrorMessage { get; private set; }
        public BookAuthorsRepository BookAuthorsRepository { get; set; }
        public BookAuthorValidator() {
            BookAuthorsRepository = new BookAuthorsRepository();
        }
        public bool IsValidBookAuthor(BookAuthor bookAuthor)
        {
            // Check if BookID is not empty
            if (string.IsNullOrWhiteSpace(bookAuthor.BookID))
            {
                ErrorMessage = "Book ID cannot be empty.";
                return false;
            }
            // Check if AuthorID is not empty
            if (string.IsNullOrWhiteSpace(bookAuthor.AuthorID))
            {
                ErrorMessage = "Author ID cannot be empty.";
                return false;
            }


            return true;
        }
    }
}
