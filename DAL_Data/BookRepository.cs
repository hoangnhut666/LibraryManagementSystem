using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUTIL_Utilities;
using DTO_Models;
using Microsoft.Data.SqlClient;

namespace DAL_Data
{
    public class BookRepository
    {
        //Get all books
        public List<Book> GetAllBooks()
        {
            string sql = $"SELECT * FROM Books ORDER BY BookID DESC";
            List<Book> books = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Book
                {
                    BookID = reader["BookID"].ToString(),
                    ISBN = reader["ISBN"].ToString(),
                    Title = reader["Title"].ToString(),
                    PublisherID = reader["PublisherID"].ToString(),
                    PublicationYear = reader["PublicationYear"] as int?,
                    CategoryID = reader["CategoryID"].ToString(),
                    ShelfLocation = reader["ShelfLocation"].ToString(),
                    NumberOfPages = reader["NumberOfPages"] as int?,
                    Language = reader["Language"].ToString(),
                    Description = reader["Description"].ToString(),
                    CoverImage = reader["CoverImage"] as byte[]
                };
            });
            return books;
        }


        // Get books by criteria
        public List<Book> GetBooksByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM Books WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Book> books = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Book
                {
                    BookID = reader["BookID"].ToString(),
                    ISBN = reader["ISBN"].ToString(),
                    Title = reader["Title"].ToString(),
                    PublisherID = reader["PublisherID"].ToString(),
                    PublicationYear = reader["PublicationYear"] as int?,
                    CategoryID = reader["CategoryID"].ToString(),
                    ShelfLocation = reader["ShelfLocation"].ToString(),
                    NumberOfPages = reader["NumberOfPages"] as int?,
                    Language = reader["Language"].ToString(),
                    Description = reader["Description"].ToString(),
                    CoverImage = reader["CoverImage"] as byte[]
                };
            }, parameters);
            return books;
        }


        // Get books by stored procedure
        public List<Book> GetBooksByStoredProcedure(string procedureName, params SqlParameter[] parameters)
        {
            List<Book> books = Utilities.ExecuteStoredProcedure(procedureName, reader =>
            {
                return new Book
                {
                    BookID = reader["BookID"].ToString(),
                    Title = reader["Title"].ToString(),
                };
            }, parameters);
            return books;
        }

        // Insert a new book
        public int Insert(Book book)
        {
            string sql = $"INSERT INTO Books (BookID, ISBN, Title, PublisherID, PublicationYear, CategoryID, ShelfLocation, NumberOfPages, Language, Description, CoverImage) " +
                         $"VALUES (@BookID, @ISBN, @Title, @PublisherID, @PublicationYear, @CategoryID, @ShelfLocation, @NumberOfPages, @Language, @Description, @CoverImage)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@BookID", book.BookID ?? (object)DBNull.Value),
                new SqlParameter("@ISBN", book.ISBN ?? (object)DBNull.Value),
                new SqlParameter("@Title", book.Title ?? (object)DBNull.Value),
                new SqlParameter("@PublisherID", book.PublisherID ?? (object)DBNull.Value),
                new SqlParameter("@PublicationYear", book.PublicationYear ?? (object)DBNull.Value),
                new SqlParameter("@CategoryID", book.CategoryID ?? (object)DBNull.Value),
                new SqlParameter("@ShelfLocation", book.ShelfLocation ?? (object)DBNull.Value),
                new SqlParameter("@NumberOfPages", book.NumberOfPages ?? (object)DBNull.Value),
                new SqlParameter("@Language", book.Language ?? (object)DBNull.Value),
                new SqlParameter("@Description", book.Description ?? (object)DBNull.Value),
                new SqlParameter("@CoverImage", book.CoverImage ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Update an existing book
        public int Update(Book book)
        {
            string sql = $"UPDATE Books SET " +
                         $"ISBN = @ISBN, " +
                         $"Title = @Title, " +
                         $"PublisherID = @PublisherID, " +
                         $"PublicationYear = @PublicationYear, " +
                         $"CategoryID = @CategoryID, " +
                         $"ShelfLocation = @ShelfLocation, " +
                         $"NumberOfPages = @NumberOfPages, " +
                         $"Language = @Language, " +
                         $"Description = @Description, " +
                         $"CoverImage = @CoverImage " +
                         $"WHERE BookID = @BookID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ISBN", book.ISBN ?? (object)DBNull.Value),
                new SqlParameter("@Title", book.Title ?? (object)DBNull.Value),
                new SqlParameter("@PublisherID", book.PublisherID ?? (object)DBNull.Value),
                new SqlParameter("@PublicationYear", book.PublicationYear ?? (object)DBNull.Value),
                new SqlParameter("@CategoryID", book.CategoryID ?? (object)DBNull.Value),
                new SqlParameter("@ShelfLocation", book.ShelfLocation ?? (object)DBNull.Value),
                new SqlParameter("@NumberOfPages", book.NumberOfPages ?? (object)DBNull.Value),
                new SqlParameter("@Language", book.Language ?? (object)DBNull.Value),
                new SqlParameter("@Description", book.Description ?? (object)DBNull.Value),
                new SqlParameter("@CoverImage", book.CoverImage ?? (object)DBNull.Value),
                new SqlParameter("@BookID", book.BookID ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        //Delete a book
        public int Delete(string bookID)
        {
            string sql = $"DELETE FROM Books WHERE BookID = @BookID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@BookID", bookID ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }

}











// Get all books
//public List<Book> GetAllBooks()
//{
//    //string sql = $"SELECT * FROM Books";
//    string sql = $"SELECT BookID, Title FROM Books ORDER BY BookID DESC";
//    List<Book> books = Utilities.ExecuteQuery(sql, reader =>
//    {
//        return new Book
//        {
//            BookID = reader["BookID"].ToString(),
//            ISBN = reader["ISBN"].ToString(),
//            Title = reader["Title"].ToString(),
//            PublisherID = reader["PublisherID"].ToString(),
//            PublicationYear = reader["PublicationYear"] as int?,
//            CategoryID = reader["CategoryID"].ToString(),
//            ShelfLocation = reader["ShelfLocation"].ToString(),
//            NumberOfPages = reader["NumberOfPages"] as int?,
//            Language = reader["Language"].ToString(),
//            Description = reader["Description"].ToString(),
//            CoverImage = reader["CoverImage"] as byte[]
//        };
//    });
//    return books;
//}