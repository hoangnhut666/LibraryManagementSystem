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
            if (bookCopy == null)
            {
                ErrorMessage = "Bản sao sách không được để trống.";
                return false;
            }

            // Check if the book ID is not empty
            if (string.IsNullOrWhiteSpace(bookCopy.BookID))
            {
                ErrorMessage = "Mã sách không được để trống.";
                return false;
            }

            // Check if the date is not in the future
            if (bookCopy.PurchaseDate.HasValue && bookCopy.PurchaseDate.Value > DateTime.Now)
            {
                ErrorMessage = "Ngày mua không được ở tương lai.";
                return false;
            }

            // Check if the purchase price is not negative
            if (bookCopy.PurchasePrice.HasValue && bookCopy.PurchasePrice.Value < 0)
            {
                ErrorMessage = "Giá mua không được âm.";
                return false;
            }

            // Check if the purchase price is a whole number
            if (bookCopy.PurchasePrice.HasValue && bookCopy.PurchasePrice.Value % 1 != 0)
            {
                ErrorMessage = "Giá mua phải là một số nguyên.";
                return false;
            }

            // Check if the purchase price is a valid decimal
            if (!bookCopy.PurchasePrice.HasValue)
            {
                ErrorMessage = "Giá mua phải là một số hợp lệ.";
                return false;
            }
            
            return true;
        }
    }
}



