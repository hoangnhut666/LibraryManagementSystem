using System;
using System.Collections.Generic;
using System.Data;
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
        // IsEmailExists
        public bool IsEmailExists(string email, string excludeMemberID = null)
        {
            string sql = "SELECT COUNT(*) FROM Members WHERE Email = @Email";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Email", email)
            };

            if (!string.IsNullOrEmpty(excludeMemberID))
            {
                sql += " AND MemberID != @MemberID";
                parameters.Add(new SqlParameter("@MemberID", excludeMemberID));
            }

            int count = (int)Utilities.ExecuteScalar(sql, parameters.ToArray());
            return count > 0;
        }

        //Search members by stored procedure
        public List<Member> FindMembers(string memberID = null, string fullName = null, string email = null,
                                   string phone = null, string address = null,
                                   DateTime? dateOfBirth = null, DateTime? joinDate = null,
                                   string status = null)
        {
            string sql = "SELECT * FROM Members WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(memberID))
            {
                sql += " AND MemberID = @MemberID";
                parameters.Add(new SqlParameter("@MemberID", memberID));
            }
            if (!string.IsNullOrEmpty(fullName))
            {
                sql += " AND FullName LIKE @FullName";
                parameters.Add(new SqlParameter("@FullName", "%" + fullName + "%"));
            }
            if (!string.IsNullOrEmpty(email))
            {
                sql += " AND Email LIKE @Email";
                parameters.Add(new SqlParameter("@Email", "%" + email + "%"));
            }
            if (!string.IsNullOrEmpty(phone))
            {
                sql += " AND Phone LIKE @Phone";
                parameters.Add(new SqlParameter("@Phone", "%" + phone + "%"));
            }
            if (!string.IsNullOrEmpty(address))
            {
                sql += " AND Address LIKE @Address";
                parameters.Add(new SqlParameter("@Address", "%" + address + "%"));
            }
            if (dateOfBirth.HasValue)
            {
                sql += " AND DateOfBirth = @DateOfBirth";
                parameters.Add(new SqlParameter("@DateOfBirth", dateOfBirth.Value));
            }
            if (joinDate.HasValue)
            {
                sql += " AND JoinDate = @JoinDate";
                parameters.Add(new SqlParameter("@JoinDate", joinDate.Value));
            }
            if (!string.IsNullOrEmpty(status))
            {
                sql += " AND Status = @Status";
                parameters.Add(new SqlParameter("@Status", status));
            }
            return Utilities.ExecuteQuery(sql, reader =>
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
            }, parameters.ToArray());
        }

        //Get all members
        public List<Member> GetAllMembers()
        {
            string sql = $"SELECT * FROM Members";
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

        // Get members by criteria
        public List<Member> GetMembers()
        {
            string sql = $"SELECT * FROM Members";
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

        //Auto generate MemberID
        public string GenerateMemberID()
        {
            string sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(MemberID, 2, LEN(MemberID) - 1) AS INT)), 0) + 1 FROM Members";
            int nextId = (int)Utilities.ExecuteScalar(sql);
            return $"M{nextId:D4}"; // Format as M0001, M0002, etc.
        }

        // Insert a new member
        public int Insert(Member member)
        {
            string sql = @"INSERT INTO Members 
                   (MemberID, FullName, Email, Phone, Address, DateOfBirth, JoinDate, Status, Photo) 
                   VALUES 
                   (@MemberID, @FullName, @Email, @Phone, @Address, @DateOfBirth, @JoinDate, @Status, @Photo)";

            var parameters = new SqlParameter[]
            {
            new SqlParameter("@MemberID", member.MemberID ?? string.Empty),
            new SqlParameter("@FullName", string.IsNullOrWhiteSpace(member.FullName) ? DBNull.Value : member.FullName),
            new SqlParameter("@Email", string.IsNullOrWhiteSpace(member.Email) ? DBNull.Value : member.Email),
            new SqlParameter("@Phone", string.IsNullOrWhiteSpace(member.Phone) ? DBNull.Value : member.Phone),
            new SqlParameter("@Address", string.IsNullOrWhiteSpace(member.Address) ? DBNull.Value : member.Address),
            new SqlParameter("@DateOfBirth", member.DateOfBirth.HasValue ? (object)member.DateOfBirth.Value : DBNull.Value),
            new SqlParameter("@JoinDate", member.JoinDate == DateTime.MinValue ? DateTime.Now : member.JoinDate),
            new SqlParameter("@Status", string.IsNullOrWhiteSpace(member.Status) ? DBNull.Value : member.Status),
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