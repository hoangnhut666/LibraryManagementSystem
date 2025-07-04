using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUTIL_Utilities;

namespace DAL_Data
{
    public class EntityRepository
    {
        //Auto generate ID for a specific table
        public static string GenerateId(string tableName, string columnName, string prefix)
        {
            string query = $"SELECT TOP 1 {columnName} FROM {tableName} ORDER BY {columnName} DESC";
            try
            {
                // Get the maximum ID from the database
                string lastId = Utilities.ExecuteScalar(query)?.ToString() ?? string.Empty;
                if (string.IsNullOrEmpty(lastId))
                {
                    return prefix + "001";
                }
                // Extract the numeric part and increment it
                string numericPart = lastId.Substring(prefix.Length);


                // Check if the numeric part is a valid number
                if (!int.TryParse(numericPart, out int nextNumber))
                {
                    throw new FormatException($"The last ID '{lastId}' does not match the expected format for table {tableName}. Please delete the invalid staffId in database");
                }

                nextNumber = nextNumber + 1;
                return prefix + nextNumber.ToString("D3");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating new ID for table {tableName}: " + ex.Message);
            }
        }
    }
}
