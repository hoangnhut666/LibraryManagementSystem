using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUTIL_Utilities;
using Microsoft.Data.SqlClient;
using DTO_Models;

namespace DAL_Data
{
    public class FineRepository
    {
        public List<FineDTO> GetAllFines()
        {
            string query = "SELECT * FROM Fines";
            return Utilities.ExecuteQuery(query, reader => new FineDTO
            {
                FineID = reader["FineID"].ToString(),
                LoanID = reader["LoanID"].ToString(),
                Amount = Convert.ToDecimal(reader["Amount"]),
                IssueDate = Convert.ToDateTime(reader["IssueDate"]),
                Paid = Convert.ToBoolean(reader["Paid"]),
                Reason = reader["Reason"].ToString()
            });
        }

        public bool InsertFine(FineDTO fine)
        {
            string query = "INSERT INTO Fines VALUES (@FineID, @LoanID, @Amount, @IssueDate, @Paid, @Reason)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FineID", fine.FineID),
                new SqlParameter("@LoanID", fine.LoanID),
                new SqlParameter("@Amount", fine.Amount),
                new SqlParameter("@IssueDate", fine.IssueDate),
                new SqlParameter("@Paid", fine.Paid),
                new SqlParameter("@Reason", fine.Reason)
            };

            return Utilities.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateFine(FineDTO fine)
        {
            string query = "UPDATE Fines SET LoanID = @LoanID, Amount = @Amount, IssueDate = @IssueDate, Paid = @Paid, Reason = @Reason WHERE FineID = @FineID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LoanID", fine.LoanID),
                new SqlParameter("@Amount", fine.Amount),
                new SqlParameter("@IssueDate", fine.IssueDate),
                new SqlParameter("@Paid", fine.Paid),
                new SqlParameter("@Reason", fine.Reason),
                new SqlParameter("@FineID", fine.FineID)
            };

            return Utilities.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteFine(string fineID)
        {
            string query = "DELETE FROM Fines WHERE FineID = @FineID";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@FineID", fineID)
            };
            return Utilities.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
