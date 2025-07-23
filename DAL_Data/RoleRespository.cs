using DBUTIL_Utilities;
using DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace DAL_Data
{
    public class RoleRespository
    {
        public List<Role> GetAllRoles()
        {
            string sql = $"SELECT * FROM Roles";
            List<Role> roles = Utilities.ExecuteQuery(sql, reader =>
            {
                return new Role
                {
                    RoleID = reader["RoleID"].ToString(),
                    RoleName = reader["RoleName"].ToString(),
                    Description = reader["Description"] as string
                };
            });
            return roles;
        }

    }
}
