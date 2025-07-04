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
    public class CategoryRepository
    {
        //Get all categories
        public List<Category> GetAll()
        {
            string sql = $"SELECT * FROM Categories";
            List<Category> categories = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Category
                {
                    CategoryID = reader["CategoryID"].ToString(),
                    Name = reader["Name"].ToString(),
                    Description = reader["Description"].ToString(),
                };
            });
            return categories;
        }

        //Get categories by criteria
        public List<Category> GetCategoriesByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM Categories WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Category> categories = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Category
                {
                    CategoryID = reader["CategoryID"].ToString(),
                    Name = reader["Name"].ToString(),
                    Description = reader["Description"].ToString(),
                };
            }, parameters);
            return categories;
        }

        //Insert a new category
        public int Insert(Category category)
        {
            string sql = $"INSERT INTO Categories (CategoryID, Name, Description) " +
                         $"VALUES (@CategoryID, @Name, @Description)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryID", category.CategoryID),
                new SqlParameter("@Name", category.Name),
                new SqlParameter("@Description", category.Description)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        //Update an existing category
        public int Update(Category category)
        {
            string sql = $"UPDATE Categories SET " +
                         $"Name = @Name, " +
                         $"Description = @Description " +
                         $"WHERE CategoryID = @CategoryID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryID", category.CategoryID),
                new SqlParameter("@Name", category.Name),
                new SqlParameter("@Description", category.Description)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        //Delete a category
        public int Delete(Category category)
        {
            string sql = $"DELETE FROM Categories WHERE CategoryID = @CategoryID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryID", category.CategoryID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}
