using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUTIL_Utilities;
using DTO_Models;
using Microsoft.Data.SqlClient;
using DTO_Models.ViewModel;

namespace DAL_Data
{
    public class LoanRepository
    {
        // Get all loans
        public List<Loan> GetAllLoans()
        {
            string sql = $"SELECT * FROM Loans";
            List<Loan> loans = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Loan
                {
                    LoanID = reader["LoanID"].ToString(),
                    CopyID = reader["CopyID"].ToString(),
                    MemberID = reader["MemberID"].ToString(),
                    LoanDate = (DateTime)reader["LoanDate"],
                    DueDate = (DateTime)reader["DueDate"],
                    ReturnDate = reader["ReturnDate"] as DateTime?,
                    Status = reader["Status"].ToString(),
                    Notes = reader["Notes"] as string
                };
            });
            return loans;
        }

        // Get loans by criteria
        public List<Loan> GetLoansByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM Loans WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Loan> loans = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Loan
                {
                    LoanID = reader["LoanID"].ToString(),
                    CopyID = reader["CopyID"].ToString(),
                    MemberID = reader["MemberID"].ToString(),
                    LoanDate = (DateTime)reader["LoanDate"],
                    DueDate = (DateTime)reader["DueDate"],
                    ReturnDate = reader["ReturnDate"] as DateTime?,
                    Status = reader["Status"].ToString(),
                    Notes = reader["Notes"] as string
                };
            }, parameters);
            return loans;
        }


        //Get view model for loans
        public List<LoanViewModel> GetLoanViewModels()
        {
            string sql = @"
                SELECT
                    l.LoanID AS MaMuon,
                    l.CopyID AS MaBanSao,
                    b.Title AS TenSach,
                    m.FullName AS TenDocGia,
                    u.FullName AS TenNhanVien,
                    l.LoanDate AS NgayMuon,
                    l.DueDate AS HanTra,
                    l.ReturnDate AS NgayTra,
                    l.Status AS TrangThai
                FROM Loans l
                JOIN BookCopies bc ON bc.CopyID = l.CopyID
                JOIN Books b ON b.BookID = bc.BookID
                JOIN Members m ON m.MemberID = l.MemberID
                LEFT JOIN Users u ON u.UserID = l.UserID
                ORDER BY LoanID DESC";
            List<LoanViewModel> viewModels = Utilities.ExecuteQuery(sql, reader =>
            {
                return new LoanViewModel
                {
                    MaMuon = reader["MaMuon"].ToString(),
                    MaBanSao = reader["MaBanSao"].ToString(),
                    TenSach = reader["TenSach"].ToString(),
                    TenDocGia = reader["TenDocGia"].ToString(),
                    TenNhanVien = reader["TenNhanVien"].ToString(),
                    NgayMuon = (DateTime)reader["NgayMuon"],
                    HanTra = (DateTime)reader["HanTra"],
                    NgayTra = reader["NgayTra"] as DateTime?,
                    TrangThai = reader["TrangThai"].ToString()
                };
            });
            return viewModels;
        }

        // Insert a new loan
        public int Insert(Loan loan)
        {
            string sql = $"INSERT INTO Loans (LoanID, CopyID, MemberID, LoanDate, DueDate, ReturnDate, Status, Notes) " +
                         $"VALUES (@LoanID, @CopyID, @MemberID, @LoanDate, @DueDate, @ReturnDate, @Status, @Notes)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@LoanID", loan.LoanID ?? string.Empty),
                new SqlParameter("@CopyID", loan.CopyID ?? string.Empty),
                new SqlParameter("@MemberID", loan.MemberID ?? string.Empty),
                new SqlParameter("@LoanDate", loan.LoanDate),
                new SqlParameter("@DueDate", loan.DueDate),
                new SqlParameter("@ReturnDate", (object)loan.ReturnDate ?? DBNull.Value),
                new SqlParameter("@Status", loan.Status ?? string.Empty),
                new SqlParameter("@Notes", loan.Notes ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Update an existing loan
        public int Update(Loan loan)
        {
            string sql = $"UPDATE Loans SET " +
                         $"CopyID = @CopyID, " +
                         $"MemberID = @MemberID, " +
                         $"LoanDate = @LoanDate, " +
                         $"DueDate = @DueDate, " +
                         $"ReturnDate = @ReturnDate, " +
                         $"Status = @Status, " +
                         $"Notes = @Notes " +
                         $"WHERE LoanID = @LoanID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@LoanID", loan.LoanID ?? string.Empty),
                new SqlParameter("@CopyID", loan.CopyID ?? string.Empty),
                new SqlParameter("@MemberID", loan.MemberID ?? string.Empty),
                new SqlParameter("@LoanDate", loan.LoanDate),
                new SqlParameter("@DueDate", loan.DueDate),
                new SqlParameter("@ReturnDate", (object)loan.ReturnDate ?? DBNull.Value),
                new SqlParameter("@Status", loan.Status ?? string.Empty),
                new SqlParameter("@Notes", loan.Notes ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        // Delete a loan
        public int Delete(Loan loan)
        {
            string sql = $"DELETE FROM Loans WHERE LoanID = @LoanID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@LoanID", loan.LoanID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);

        }
    }
}