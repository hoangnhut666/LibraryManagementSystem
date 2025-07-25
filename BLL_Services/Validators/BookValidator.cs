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
                ErrorMessage = "Mã ISBN không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(book.Title))
            {
                ErrorMessage = "Tiêu đề không được để trống.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(book.PublisherID))
            {
                ErrorMessage = "Publisher ID không được để trống.";
                return false;
            }
            if (book.PublicationYear <= 0)
            {
                ErrorMessage = "Năm xuất bản phải là một số nguyên dương.";
                return false;
            }
            if (book.NumberOfPages <= 0)
            {
                ErrorMessage = "Số trang phải là một số nguyên dương.";
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
