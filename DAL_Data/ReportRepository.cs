using DBUTIL_Utilities;
using DTO_Models;
using DTO_Models.ViewModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data
{
    public class ReportRepository
    {
        public List<Top10ReadersViewModel> GetTopReaders()
        {
            string query = @"
            SELECT TOP 10 m.MemberID, m.FullName, COUNT(*) AS BorrowCount
            FROM Loans l
            INNER JOIN Members m ON l.MemberID = m.MemberID
            GROUP BY m.MemberID, m.FullName
            ORDER BY BorrowCount DESC
        ";

            return Utilities.ExecuteQuery(query, reader => new Top10ReadersViewModel
            {
                MaThanhVien = reader["MemberID"].ToString(),
                HoVaTen = reader["FullName"].ToString(),
                SoLuotMuon = Convert.ToInt32(reader["BorrowCount"])
            });
        }

        public List<Top10BooksViewModel> GetTopBorrowedBooks()
        {
            string query = @"
            SELECT TOP 10 b.BookID, b.Title, COUNT(*) AS BorrowCount
            FROM Loans l
            INNER JOIN BookCopies bc ON l.CopyID = bc.CopyID
            INNER JOIN Books b ON bc.BookID = b.BookID
            GROUP BY b.BookID, b.Title
            ORDER BY BorrowCount DESC";

            return Utilities.ExecuteQuery(query, reader => new Top10BooksViewModel
            {
                MaSach = reader["BookID"].ToString(),
                TieuDe = reader["Title"].ToString(),
                SoLuotMuon = Convert.ToInt32(reader["BorrowCount"])
            });
        }

        //Get book report view models by criteria
        public List<BookReportViewModel> GetBookReportViewModelByCriteria(string column, string value)
        {
            string query = $@"
            SELECT 
                bc.CopyID,
                b.Title,
                c.Name AS CategoryName,
                m.FullName AS MemberFullName,
                l.LoanDate,
                l.DueDate,
                l.ReturnDate,
                l.Status
            FROM Books b
            JOIN Categories c ON c.CategoryID = b.CategoryID
            JOIN BookCopies bc ON bc.BookID = b.BookID
            JOIN Loans l ON l.CopyID = bc.CopyID
            JOIN Members m ON m.MemberID = l.MemberID
            WHERE l.{column} = @Value";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };

            return Utilities.ExecuteQuery(query, reader => new BookReportViewModel
            {
                MaBanSao = reader["CopyID"] as string,
                TieuDe = reader["Title"] as string,
                TheLoai = reader["CategoryName"] as string,
                TenNguoiMuon = reader["MemberFullName"] as string,
                NgayMuon = Convert.ToDateTime(reader["LoanDate"]),
                HanTra = Convert.ToDateTime(reader["DueDate"]),
                NgayTra = reader["ReturnDate"] as DateTime?,
                TrangThai = reader["Status"] as string
            }, parameters);

        }
    }
}
