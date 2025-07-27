using DAL_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO_Models;

namespace BLL_Services.Services
{
    public class SecurityService
    {
        UserRepository UserRepository { get; set; }
        public SecurityService()
        {
            UserRepository = new UserRepository();
        }

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            RandomNumberGenerator.Fill(salt);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }

            return true;
        }


        public string? GetStoredHashedPasswordWithUsername(string username)
        {
            return UserRepository.GetHashPassword(username);
        }


        //Update the password for a user
        public int UpdatePassword(string username, string newPassword)
        {
            try
            {
                string hashedPassword = HashPassword(newPassword);
                return UserRepository.UpdateUserPassword(username, hashedPassword);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the password.", ex);
            }
        }


        //Get user by username
        public User? GetUserByUsername(string username)
        {
            try
            {
                return UserRepository.GetUsersByCriteria("Username", username).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the user.", ex);
            }
        }

        //Lock user account by username
        public int LockAccountByUsername(string username)
        {
            try
            {
                return UserRepository.LockAcountByUsername(username);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while locking the account.", ex);
            }

        }
    }
}


