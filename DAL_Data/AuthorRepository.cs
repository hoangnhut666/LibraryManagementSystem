using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUTIL_Utilities;
using DTO_Models;

namespace DAL_Data
{
    public class AuthorRepository
    {
        public List<Author> GetAllAuthors()
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
    }
}

