using DBUTIL_Utilities;
using DTO_Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_Data
{
    public class PublisherRepository
    {
        // Get all publishers
        public List<Publisher> GetAllPublishers()
        {
            string sql = $"SELECT * FROM Publishers";
            List<Publisher> publishers = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Publisher
                {
                    PublisherID = reader["PublisherID"].ToString(),
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"] as string,
                    Phone = reader["Phone"] as string,
                    Email = reader["Email"] as string
                };
            });
            return publishers;
        }

        // Get publishers by criteria
        public List<Publisher> GetPublishersByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM Publishers WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Publisher> publishers = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Publisher
                {
                    PublisherID = reader["PublisherID"].ToString(),
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"] as string,
                    Phone = reader["Phone"] as string,
                    Email = reader["Email"] as string
                };
            });
            return publishers;
        }


        // Insert a new publisher
        public int Insert(Publisher publisher)
        {
            string sql = $"INSERT INTO Publishers (PublisherID, Name, Address, Phone, Email) " +
                         $"VALUES (@PublisherID, @Name, @Address, @Phone, @Email)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@PublisherID", publisher.PublisherID ?? string.Empty),
                new SqlParameter("@Name", publisher.Name ?? string.Empty),
                new SqlParameter("@Address", publisher.Address ?? (object)DBNull.Value),
                new SqlParameter("@Phone", publisher.Phone ?? (object)DBNull.Value),
                new SqlParameter("@Email", publisher.Email ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        // Update an existing publisher
        public int Update(Publisher publisher)
        {
            string sql = $"UPDATE Publishers SET " +
                         $"Name = @Name, " +
                         $"Address = @Address, " +
                         $"Phone = @Phone, " +
                         $"Email = @Email " +
                         $"WHERE PublisherID = @PublisherID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@PublisherID", publisher.PublisherID ?? string.Empty),
                new SqlParameter("@Name", publisher.Name ?? string.Empty),
                new SqlParameter("@Address", publisher.Address ?? (object)DBNull.Value),
                new SqlParameter("@Phone", publisher.Phone ?? (object)DBNull.Value),
                new SqlParameter("@Email", publisher.Email ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Delete a publisher
        public int Delete(string publisherID)
        {
            string sql = $"DELETE FROM Publishers WHERE PublisherID = @PublisherID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@PublisherID", publisherID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);

        }
    }
}

