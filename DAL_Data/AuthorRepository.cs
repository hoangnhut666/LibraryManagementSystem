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
    public class AuthorRepository
    {
        public List<Author> GetAllAuthors()
        {
            string sql = $"SELECT * FROM Authors ORDER BY AuthorID DESC";
            List<Author> authors = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Author
                {
                    AuthorID = reader["AuthorID"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Biography = reader["Biography"] as string,
                    DateOfBirth = reader["DateOfBirth"] as DateTime?,
                    DateOfDeath = reader["DateOfDeath"] as DateTime?
                };
            });

            return authors;
        }


        // Get authors by criteria
        public List<Author> GetAuthorsByCriteria()
        {
            string sql = $"SELECT * FROM Authors";
            List<Author> authors = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Author
                {
                    AuthorID = reader["AuthorID"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Biography = reader["Biography"] as string,
                    DateOfBirth = reader["DateOfBirth"] as DateTime?,
                    DateOfDeath = reader["DateOfDeath"] as DateTime?
                };
            });
            return authors;
        }


        //Get list of authors by execute stored procedure
        public List<Author> GetAuthorsByStoredProcedure(string procedureName, params SqlParameter[] parameters)
        {
            List<Author> authors = Utilities.ExecuteStoredProcedure(procedureName, reader =>
            {
                return new Author
                {
                    AuthorID = reader["AuthorID"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Biography = reader["Biography"] as string,
                    DateOfBirth = reader["DateOfBirth"] as DateTime?,
                    DateOfDeath = reader["DateOfDeath"] as DateTime?
                };
            }, parameters);
            return authors;
        }


        //Get all authors of a specific book with a given BookID
        public List<Author> GetAuthorsByBookID(string bookID)
        {
            string sql = $"SELECT a.* FROM Authors a " +
                         $"JOIN BookAuthors ba ON a.AuthorID = ba.AuthorID " +
                         $"WHERE ba.BookID = @BookID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@BookID", bookID)
            };
            List<Author> authors = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Author
                {
                    AuthorID = reader["AuthorID"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Biography = reader["Biography"] as string,
                    DateOfBirth = reader["DateOfBirth"] as DateTime?,
                    DateOfDeath = reader["DateOfDeath"] as DateTime?
                };
            }, parameters);
            return authors;
        }


        // Insert a new author
        public int Insert(Author author)
        {
            string sql = $"INSERT INTO Authors (AuthorID, FullName, Biography, DateOfBirth, DateOfDeath) " +
                         $"VALUES (@AuthorID, @FullName, @Biography, @DateOfBirth, @DateOfDeath)";
            var parameters = new SqlParameter[]
            {
               new SqlParameter("@AuthorID", author.AuthorID ?? string.Empty),
               new SqlParameter("@FullName", author.FullName ?? string.Empty),
               new SqlParameter("@Biography", author.Biography ?? (object)DBNull.Value),
               new SqlParameter("@DateOfBirth", author.DateOfBirth ?? (object)DBNull.Value),
               new SqlParameter("@DateOfDeath", author.DateOfDeath ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Update an existing author
        public int Update(Author author)
        {
            string sql = $"UPDATE Authors SET " +
                         $"FullName = @FullName, " +
                         $"Biography = @Biography, " +
                         $"DateOfBirth = @DateOfBirth, " +
                         $"DateOfDeath = @DateOfDeath " +
                         $"WHERE AuthorID = @AuthorID";
            var parameters = new SqlParameter[]
            {
               new SqlParameter("@AuthorID", author.AuthorID ?? string.Empty),
               new SqlParameter("@FullName", author.FullName ?? string.Empty),
               new SqlParameter("@Biography", author.Biography ?? (object)DBNull.Value),
               new SqlParameter("@DateOfBirth", author.DateOfBirth ?? (object)DBNull.Value),
               new SqlParameter("@DateOfDeath", author.DateOfDeath ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Delete an author
        public int Delete(string authorID)
        {
            string sql = $"DELETE FROM Authors WHERE AuthorID = @AuthorID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@AuthorID", authorID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}

