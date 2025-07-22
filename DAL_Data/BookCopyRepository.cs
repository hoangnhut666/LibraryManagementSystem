using DAL_Data;
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
    public class BookCopyRepository
    {
        // Get all book copies
        public List<BookCopy> GetAllBookCopies()
        {
            string sql = "SELECT * FROM BookCopies ORDER BY CopyID DESC";
            List<BookCopy> bookCopies = Utilities.ExecuteQuery(sql, reader =>
            {
                return new BookCopy
                {
                    CopyID = reader["CopyID"].ToString(),
                    BookID = reader["BookID"].ToString(),
                    Barcode = reader["Barcode"].ToString(),
                    Status = reader["Status"].ToString(),
                    ConditionNotes = reader["ConditionNotes"] as string,
                    PurchaseDate = reader["PurchaseDate"] as DateTime?,
                    PurchasePrice = reader["PurchasePrice"] as decimal?
                };
            });
            return bookCopies;
        }


        // Get book copies by criteria
        public List<BookCopy> GetBookCopiesByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM BookCopies WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<BookCopy> bookCopies = Utilities.ExecuteQuery(sql, reader =>
            {
                return new BookCopy
                {
                    CopyID = reader["CopyID"].ToString(),
                    BookID = reader["BookID"].ToString(),
                    Barcode = reader["Barcode"].ToString(),
                    Status = reader["Status"].ToString(),
                    ConditionNotes = reader["ConditionNotes"] as string,
                    PurchaseDate = reader["PurchaseDate"] as DateTime?,
                    PurchasePrice = reader["PurchasePrice"] as decimal?
                };
            }, parameters);
            return bookCopies;
        }


        //Get book copies view models
        public List<BookCopyViewModel> GetBookCopiesViewModels()
        {
            string sql = "SELECT CopyID, Title FROM BookCopies INNER JOIN Books ON BookCopies.BookID = Books.BookID ORDER BY CopyID DESC";
            List<BookCopyViewModel> bookCopies = Utilities.ExecuteQuery(sql, reader =>
            {
                return new BookCopyViewModel
                {
                    MaBanSao = reader["CopyID"].ToString(),
                    TieuDe = reader["Title"].ToString()
                };
            });
            return bookCopies;
        }


        //Get book copies by strored procedure
        public List<BookCopyViewModel> GetBookCopiesByStoredProcedure(string procedureName, params SqlParameter[] parameters)
        {
            List<BookCopyViewModel> bookCopies = Utilities.ExecuteStoredProcedure(procedureName, reader =>
            {
                return new BookCopyViewModel
                {
                    MaBanSao = reader["CopyID"].ToString(),
                    TieuDe = reader["Title"].ToString()
                };
            }, parameters);
            return bookCopies;
        }


        // Insert a new book copy
        public int Insert(BookCopy bookCopy)
        {
            string sql = "INSERT INTO BookCopies (CopyID, BookID, Barcode, Status, ConditionNotes, PurchaseDate, PurchasePrice) " +
                         "VALUES (@CopyID, @BookID, @Barcode, @Status, @ConditionNotes, @PurchaseDate, @PurchasePrice)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CopyID", bookCopy.CopyID),
                new SqlParameter("@BookID", bookCopy.BookID),
                new SqlParameter("@Barcode", bookCopy.Barcode),
                new SqlParameter("@Status", bookCopy.Status),
                new SqlParameter("@ConditionNotes", (object)bookCopy.ConditionNotes ?? DBNull.Value),
                new SqlParameter("@PurchaseDate", (object)bookCopy.PurchaseDate ?? DBNull.Value),
                new SqlParameter("@PurchasePrice", (object)bookCopy.PurchasePrice ?? DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        // Update an existing book copy
        public int Update(BookCopy bookCopy)
        {
            string sql = "UPDATE BookCopies SET BookID = @BookID, Barcode = @Barcode, Status = @Status, " +
                         "ConditionNotes = @ConditionNotes, PurchaseDate = @PurchaseDate, PurchasePrice = @PurchasePrice " +
                         "WHERE CopyID = @CopyID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CopyID", bookCopy.CopyID),
                new SqlParameter("@BookID", bookCopy.BookID),
                new SqlParameter("@Barcode", bookCopy.Barcode),
                new SqlParameter("@Status", bookCopy.Status),
                new SqlParameter("@ConditionNotes", (object)bookCopy.ConditionNotes ?? DBNull.Value),
                new SqlParameter("@PurchaseDate", (object)bookCopy.PurchaseDate ?? DBNull.Value),
                new SqlParameter("@PurchasePrice", (object)bookCopy.PurchasePrice ?? DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        // Delete a book copy
        public int Delete(string copyID)
        {
            string sql = "DELETE FROM BookCopies WHERE CopyID = @CopyID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CopyID", copyID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

    }

}