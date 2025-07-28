using DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL_Data;

namespace BLL_Services.Validators
{
    public class BookValidator
    {
        private BookRepository BookRepository { get; set; }
        public string? ErrorMessage { get; set; }
        public BookValidator()
        {
            BookRepository = new BookRepository();
        }
        public bool IsValidBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.ISBN))
            {
                ErrorMessage = "Mã ISBN không được để trống.";
                return false;
            }

            if (!Regex.IsMatch(book.ISBN, @"^\d{10,13}$"))
            {
                ErrorMessage = "Mã ISBN phải từ 10 đến 13 ký tự số";
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
            if(book.NumberOfPages == null)
            {
                ErrorMessage = "Số trang không hợp lệ,số trang phải là một số nguyên dương.";
                return false;
            }
            if (book.PublicationYear == null)
            {
                ErrorMessage = "Năm xuất bản phải là số nguyên dương";
                return false;
            }
            

            return true;
        }
    }
}














