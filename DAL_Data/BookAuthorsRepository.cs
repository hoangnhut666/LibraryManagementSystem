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
    public class BookAuthorsRepository
    {
        // Get all book authors
        public List<BookAuthor> GetAllBookAuthors()
        {
            string sql = $"SELECT * FROM BookAuthors ORDER BY BookID DESC";
            List<BookAuthor> bookAuthors = Utilities.ExecuteQuery(sql, reader =>
            {
                return new BookAuthor
                {
                    BookAuthorID = Convert.ToInt32(reader["BookAuthorID"]),
                    BookID = reader["BookID"].ToString(),
                    AuthorID = reader["AuthorID"].ToString()
                };
            });
            return bookAuthors;
        }


        // Get book authors by criteria
        public List<BookAuthor> GetBookAuthorsByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM BookAuthors WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<BookAuthor> bookAuthors = Utilities.ExecuteQuery(sql, reader =>
            {
                return new BookAuthor
                {
                    BookAuthorID = Convert.ToInt32(reader["BookAuthorID"]),
                    BookID = reader["BookID"].ToString(),
                    AuthorID = reader["AuthorID"].ToString()
                };
            });
            return bookAuthors;
        }

        //Get book author view models
        public List<BookAuthorViewModel> GetBookAuthorViewModels()
        {
            string sql = @"
                SELECT 
                    ba.BookAuthorID,
                    ba.BookID,
                    b.Title,
                    ba.AuthorID,
                    a.FullName
                FROM BookAuthors ba
                JOIN Authors a ON a.AuthorID = ba.AuthorID
                JOIN Books b ON b.BookID = ba.BookID
                ORDER BY ba.BookAuthorID DESC";

            List<BookAuthorViewModel> bookAuthors = Utilities.ExecuteQuery(sql, reader =>
            {
                return new BookAuthorViewModel
                {
                    MaSachVaTacGia = reader["BookAuthorID"].ToString(),
                    MaSach = reader["BookID"].ToString(),
                    TieuDe = reader["Title"].ToString(),
                    MaTacGia = reader["AuthorID"].ToString(),
                    TenTacGia = reader["FullName"].ToString()
                };
            });
            return bookAuthors;
        }

        //Insert a new book author
        public int Insert(BookAuthor bookAuthor)
        {
            string sql = "INSERT INTO BookAuthors (BookID, AuthorID) VALUES (@BookID, @AuthorID); SELECT SCOPE_IDENTITY();";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@BookID", bookAuthor.BookID),
                new SqlParameter("@AuthorID", bookAuthor.AuthorID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Update an existing book author
        public int Update(BookAuthor bookAuthor)
        {
            string sql = "UPDATE BookAuthors SET BookID = @BookID, AuthorID = @AuthorID WHERE BookAuthorID = @BookAuthorID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@BookAuthorID", bookAuthor.BookAuthorID),
                new SqlParameter("@BookID", bookAuthor.BookID),
                new SqlParameter("@AuthorID", bookAuthor.AuthorID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Delete a book author
        public int Delete(int bookAuthorID)
        {
            string sql = "DELETE FROM BookAuthors WHERE BookAuthorID = @BookAuthorID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@BookAuthorID", bookAuthorID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}


