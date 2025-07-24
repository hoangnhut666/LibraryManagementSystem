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
    public class MemberRepository
    {
        //Get all members
        public List<Member> GetAllMembers()
        {
            string sql = $"SELECT * FROM Members ORDER BY MemberID DESC";
            List<Member> members = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Member
                {
                    MemberID = reader["MemberID"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Email = reader["Email"] as string,
                    Phone = reader["Phone"] as string,
                    Address = reader["Address"] as string,
                    DateOfBirth = reader["DateOfBirth"] as DateTime?,
                    JoinDate = (DateTime)reader["JoinDate"],
                    Status = reader["Status"].ToString(),
                    Photo = reader["Photo"] as byte[]
                };
            });
            return members;

        }


        //Get member by criteria
        public List<Member> GetMembersByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM Members WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<Member> members = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Member
                {
                    MemberID = reader["MemberID"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Email = reader["Email"] as string,
                    Phone = reader["Phone"] as string,
                    Address = reader["Address"] as string,
                    DateOfBirth = reader["DateOfBirth"] as DateTime?,
                    JoinDate = (DateTime)reader["JoinDate"],
                    Status = reader["Status"].ToString(),
                    Photo = reader["Photo"] as byte[]
                };
            }, parameters);
            return members;
        }

        //Search members by search term
        public List<Member> SearchMembers(string searchTerm)
        {
            string sql = @"
            SELECT *
            FROM Members m
            WHERE 
                @SearchTerm IS NULL OR
                m.MemberID LIKE '%' + @SearchTerm + '%' OR
                CAST(m.DateOfBirth AS NVARCHAR) LIKE '%' + @SearchTerm + '%' OR
                m.FullName LIKE '%' + @SearchTerm + '%' OR
                m.Email LIKE '%' + @SearchTerm + '%' OR
                m.Phone LIKE '%' + @SearchTerm + '%' OR
                m.Address LIKE '%' + @SearchTerm + '%'
            ORDER BY m.MemberID DESC";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@SearchTerm", string.IsNullOrEmpty(searchTerm) ? (object)DBNull.Value : searchTerm)
            };

            List<Member> members = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Member
                {
                    MemberID = reader["MemberID"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Email = reader["Email"] as string,
                    Phone = reader["Phone"] as string,
                    Address = reader["Address"] as string,
                    DateOfBirth = reader["DateOfBirth"] as DateTime?,
                    JoinDate = (DateTime)reader["JoinDate"],
                    Status = reader["Status"].ToString(),
                    Photo = reader["Photo"] as byte[]
                };
            }, parameters);

            return members;
        }



        // Insert a new member
        public int Insert(Member member)
        {
            string sql = $"INSERT INTO Members (MemberID, FullName, Email, Phone, Address, DateOfBirth, JoinDate, Status, Photo) " +
                         $"VALUES (@MemberID, @FullName, @Email, @Phone, @Address, @DateOfBirth, @JoinDate, @Status, @Photo)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberID", member.MemberID ?? string.Empty),
                new SqlParameter("@FullName", member.FullName ?? string.Empty),
                new SqlParameter("@Email", member.Email ?? (object)DBNull.Value),
                new SqlParameter("@Phone", member.Phone ?? (object)DBNull.Value),
                new SqlParameter("@Address", member.Address ?? (object)DBNull.Value),
                new SqlParameter("@DateOfBirth", member.DateOfBirth ?? (object)DBNull.Value),
                new SqlParameter("@JoinDate", member.JoinDate),
                new SqlParameter("@Status", member.Status ?? string.Empty),
                new SqlParameter("@Photo", member.Photo ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Update an existing member
        public int Update(Member member)
        {
            string sql = $"UPDATE Members SET " +
                         $"FullName = @FullName, " +
                         $"Email = @Email, " +
                         $"Phone = @Phone, " +
                         $"Address = @Address, " +
                         $"DateOfBirth = @DateOfBirth, " +
                         $"JoinDate = @JoinDate, " +
                         $"Status = @Status, " +
                         $"Photo = @Photo " +
                         $"WHERE MemberID = @MemberID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberID", member.MemberID ?? string.Empty),
                new SqlParameter("@FullName", member.FullName ?? string.Empty),
                new SqlParameter("@Email", member.Email ?? (object)DBNull.Value),
                new SqlParameter("@Phone", member.Phone ?? (object)DBNull.Value),
                new SqlParameter("@Address", member.Address ?? (object)DBNull.Value),
                new SqlParameter("@DateOfBirth", member.DateOfBirth ?? (object)DBNull.Value),
                new SqlParameter("@JoinDate", member.JoinDate),
                new SqlParameter("@Status", member.Status ?? string.Empty),
                new SqlParameter("@Photo", member.Photo ?? (object)DBNull.Value)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        // Delete a member
        public int Delete(string memberId)
        {
            string sql = $"DELETE FROM Members WHERE MemberID = @MemberID";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberID", memberId)
            };
            return Utilities.ExecuteNonQuery(sql, parameters);
        }
    }
}