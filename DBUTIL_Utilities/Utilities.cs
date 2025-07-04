using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DBUTIL_Utilities
{
    public class Utilities
    {
        private static readonly string connString = @"Server=.\;Database=PolyLibrary;Integrated Security=True;TrustServerCertificate=True;";

        public static List<T> ExecuteQuery<T>(string query, Func<IDataReader, T> mapFunction, params SqlParameter[] parameters)
        {
            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(mapFunction(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing query and mapping results: {query}", ex);
                }
            }

            return result;
        }


        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                try
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing non-query command: {commandText}", ex);
                }
            }
        }


        public static object ExecuteScalar(string commandText, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                try
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing scalar command: {commandText}", ex);
                }
            }
        }


        public static List<T> ExecuteStoredProcedure<T>(string storedProcedureName, Func<IDataReader, T> mapFunction, params SqlParameter[] parameters)
        {
            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(mapFunction(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing stored procedure: {storedProcedureName}", ex);
                }
            }

            return result;
        }
    }
}
