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
    public class CategoryRepository
    {
        //Get all categories
        public List<Category> GetAllCategories()
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


        //Search categories by search term
        public List<Category> SearchCategories(string searchTerm)
        {
            string sql = @"
                SELECT * FROM Categories
                WHERE 
                    @SearchTerm IS NULL OR
                    CategoryID LIKE '%' + @SearchTerm + '%' OR
                    Name LIKE '%' + @SearchTerm + '%' OR
                    Description LIKE '%' + @SearchTerm + '%'
                ORDER BY CategoryID DESC;
            ";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@SearchTerm", string.IsNullOrEmpty(searchTerm) ? (object)DBNull.Value : searchTerm)
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
        public int Delete(string categoryId)
        {
            string sql = $"DELETE FROM Categories WHERE CategoryID = @CategoryID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryID", categoryId)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}
