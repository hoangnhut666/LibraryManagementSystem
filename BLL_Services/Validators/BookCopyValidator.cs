using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;
using DTO_Models;

namespace BLL_Services.Validators
{
    public class BookCopyValidator
    {
        public string? ErrorMessage { get; private set; }
        public BookCopyValidator()
        {
        }
        public bool IsValidBookCopy(BookCopy bookCopy)
        {
            // Check if the book ID is not empty
            if (string.IsNullOrWhiteSpace(bookCopy.BookID))
            {
                ErrorMessage = "Book ID cannot be empty.";
                return false;
            }

            //Check if the date is not in the future
            if (bookCopy.PurchaseDate.HasValue && bookCopy.PurchaseDate.Value > DateTime.Now)
            {
                ErrorMessage = "Purchase date cannot be in the future.";
                return false;
            }

            // Check if the purchase price is not negative
            if (bookCopy.PurchasePrice.HasValue && bookCopy.PurchasePrice.Value < 0)
            {
                ErrorMessage = "Purchase price cannot be negative.";
                return false;
            }


            return true;
        }
    }
}



