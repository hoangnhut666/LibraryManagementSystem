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
    public class FineRepository
    {
        // Get all fines
        public List<Fine> GetAllFines()
        {
            string sql = "SELECT * FROM Fines ORDER BY FineID DESC";
            List<Fine> fines = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Fine
                {
                    FineID = reader["FineID"].ToString(),
                    LoanID = reader["LoanID"].ToString(),
                    Amount = reader["Amount"] as decimal?,
                    IssueDate = reader["IssueDate"] as DateTime?,
                    Paid = (bool)reader["Paid"],
                    Reason = reader["Reason"].ToString()
                };
            });
            return fines;
        }

        // Get fines by criteria
        public List<Fine> GetFinesByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM Fines WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Fine> fines = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Fine
                {
                    FineID = reader["FineID"].ToString(),
                    LoanID = reader["LoanID"].ToString(),
                    Amount = reader["Amount"] as decimal?,
                    IssueDate = reader["IssueDate"] as DateTime?,
                    Paid = (bool)reader["Paid"],
                    Reason = reader["Reason"].ToString()
                };
            }, parameters);
            return fines;
        }


        // Get fine by ID
        public Fine? GetFineById(string fineId)
        {
            string sql = "SELECT * FROM Fines WHERE FineID = @FineID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@FineID", fineId)
            };
            List<Fine> fines = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Fine
                {
                    FineID = reader["FineID"].ToString(),
                    LoanID = reader["LoanID"].ToString(),
                    Amount = reader["Amount"] as decimal?,
                    IssueDate = reader["IssueDate"] as DateTime?,
                    Paid = (bool)reader["Paid"],
                    Reason = reader["Reason"].ToString()
                };
            }, parameters);
            return fines.FirstOrDefault();
        }

        // Get fine view models
        public List<FineViewModel> GetFineViewModels()
        {
            string sql = @"
            SELECT
                 f.FineID,
                 f.LoanID,
                 m.FullName,
                 f.Amount
             FROM Fines f
             JOIN Loans l ON l.LoanID=f.LoanID
             JOIN Members m ON m.MemberID=l.MemberID
             ORDER BY f.FineID DESC";
            List<FineViewModel> fines = Utilities.ExecuteQuery(sql, reader =>
            {
                return new FineViewModel
                {
                    MaPhieuPhat = reader["FineID"].ToString(),
                    MaPhieuMuon = reader["LoanID"].ToString(),
                    TenThanhVien = reader["FullName"].ToString(),
                    SoTien = (decimal)reader["Amount"]
                };
            });
            return fines;
        }


        // Search fines by search term
        public List<FineViewModel> SearchFines(string searchTerm)
        {
            string sql = @"
            SELECT 
                f.FineID,
                f.LoanID,
                m.FullName,
                f.Amount
            FROM
                Fines f
            JOIN Loans l ON f.LoanID = l.LoanID
            JOIN Members m ON l.MemberID = m.MemberID
            WHERE 
                @SearchTerm IS NULL OR
                f.FineID LIKE '%' + @SearchTerm + '%' OR
                m.FullName LIKE '%' + @SearchTerm + '%' OR
                l.LoanDate LIKE '%' + @SearchTerm + '%' OR
                l.DueDate LIKE '%' + @SearchTerm + '%' OR
                l.ReturnDate LIKE '%' + @SearchTerm + '%'
            ORDER BY 
                f.FineID DESC;";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@SearchTerm", string.IsNullOrEmpty(searchTerm) ? (object)DBNull.Value : searchTerm)
            };
            List<FineViewModel> fines = Utilities.ExecuteQuery(sql, reader =>
            {
                return new FineViewModel
                {
                    MaPhieuPhat = reader["FineID"].ToString(),
                    MaPhieuMuon = reader["LoanID"].ToString(),
                    TenThanhVien = reader["FullName"].ToString(),
                    SoTien = (decimal)reader["Amount"]
                };
            }, parameters);
            return fines;
        }

        // Insert a new fine
        public int Insert(Fine fine)
        {
            string sql = "INSERT INTO Fines (FineID, LoanID, Amount, IssueDate, Paid, Reason) " +
                         "VALUES (@FineID, @LoanID, @Amount, @IssueDate, @Paid, @Reason)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@FineID", fine.FineID),
                new SqlParameter("@LoanID", fine.LoanID),
                new SqlParameter("@Amount", fine.Amount ?? (object)DBNull.Value),
                new SqlParameter("@IssueDate", fine.IssueDate ?? (object)DBNull.Value),
                new SqlParameter("@Paid", fine.Paid),
                new SqlParameter("@Reason", fine.Reason ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Update an existing fine
        public int Update(Fine fine)
        {
            string sql = "UPDATE Fines SET LoanID = @LoanID, Amount = @Amount, IssueDate = @IssueDate, " +
                         "Paid = @Paid, Reason = @Reason WHERE FineID = @FineID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@FineID", fine.FineID),
                new SqlParameter("@LoanID", fine.LoanID),
                new SqlParameter("@Amount", fine.Amount ?? (object)DBNull.Value),
                new SqlParameter("@IssueDate", fine.IssueDate ?? (object)DBNull.Value),
                new SqlParameter("@Paid", fine.Paid),
                new SqlParameter("@Reason", fine.Reason ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Delete a fine
        public int Delete(string fineID)
        {
            string sql = "DELETE FROM Fines WHERE FineID = @FineID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@FineID", fineID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}