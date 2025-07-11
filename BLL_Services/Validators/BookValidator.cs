using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models;

namespace BLL_Services.Validators
{
    public class BookValidator
    {
        public string? ErrorMessage { get; set; }

        public bool IsValidBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.ISBN))
            {
                ErrorMessage = "ISBN cannot be empty.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(book.Title))
            {
                ErrorMessage = "Title cannot be empty.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(book.PublisherID))
            {
                ErrorMessage = "Publisher ID cannot be empty.";
                return false;
            }
            if (book.PublicationYear <= 0)
            {
                ErrorMessage = "Publication Year must be a positive integer.";
                return false;
            }
            if (book.NumberOfPages <= 0)
            {
                ErrorMessage = "Number of Pages must be a positive integer.";
                return false;
            }
            ErrorMessage = string.Empty;
            return true;
        }
    }
}
















//if (string.IsNullOrWhiteSpace(book.Language))
//{
//    ErrorMessage = "Language cannot be empty.";
//    return false;
//}


//if (string.IsNullOrWhiteSpace(book.CategoryID))
//{
//    ErrorMessage = "Category ID cannot be empty.";
//    return false;
//}
