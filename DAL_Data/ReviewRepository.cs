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
    public class ReviewRepository
    {
        // Get all reviews
        public List<Review> GetAllReviews()
        {
            string sql = $"SELECT * FROM Reviews";
            List<Review> reviews = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Review
                {
                    ReviewID = (int)reader["ReviewID"],
                    BookID = reader["BookID"].ToString(),
                    MemberID = reader["MemberID"].ToString(),
                    Expression = reader["Expression"] as string,
                    ReviewText = reader["ReviewText"] as string
                };
            });
            return reviews;
        }

        // Get reviews by criteria
        public List<Review> GetReviewsByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM Reviews WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Review> reviews = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Review
                {
                    ReviewID = (int)reader["ReviewID"],
                    BookID = reader["BookID"].ToString(),
                    MemberID = reader["MemberID"].ToString(),
                    Expression = reader["Expression"] as string,
                    ReviewText = reader["ReviewText"] as string
                };
            }, parameters);
            return reviews;
        }


        // Insert a new review
        public int Insert(Review review)
        {
            string sql = $"INSERT INTO Reviews (ReviewID, BookID, MemberID, Expression, ReviewText) " +
                         $"VALUES (@ReviewID, @BookID, @MemberID, @Expression, @ReviewText)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ReviewID", review.ReviewID),
                new SqlParameter("@BookID", review.BookID ?? string.Empty),
                new SqlParameter("@MemberID", review.MemberID ?? string.Empty),
                new SqlParameter("@Expression", review.Expression ?? (object)DBNull.Value),
                new SqlParameter("@ReviewText", review.ReviewText ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        // Update an existing review
        public int Update(Review review)
        {
            string sql = $"UPDATE Reviews SET " +
                         $"BookID = @BookID, " +
                         $"MemberID = @MemberID, " +
                         $"Expression = @Expression, " +
                         $"ReviewText = @ReviewText " +
                         $"WHERE ReviewID = @ReviewID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ReviewID", review.ReviewID),
                new SqlParameter("@BookID", review.BookID ?? string.Empty),
                new SqlParameter("@MemberID", review.MemberID ?? string.Empty),
                new SqlParameter("@Expression", review.Expression ?? (object)DBNull.Value),
                new SqlParameter("@ReviewText", review.ReviewText ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        // Delete a review
        public int Delete(Review review)
        {
            string sql = $"DELETE FROM Reviews WHERE ReviewID = @ReviewID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ReviewID", review.ReviewID)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}