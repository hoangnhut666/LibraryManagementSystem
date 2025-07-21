using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;
using Microsoft.Data.SqlClient;
using DBUTIL_Utilities;


namespace BLL_Services.Services
{
    public class MemberService
    {
        // Repository responsible for accessing and managing member data in the database.
        private readonly MemberRepository MemberRepository;
        // Validator used to ensure that member data meets required rules and formats.
        private readonly MemberValidator MemberValidator;

        /// <summary>
        /// Searches for members based on the provided Member ID.
        /// </summary>
        /// <param name="memberID">The Member ID to search for.</param>
        /// <returns>A list of members matching the specified Member ID.</returns>
        /// <exception cref="ArgumentException">Thrown when the Member ID is null or empty.</exception>
        public List<Member> SearchMembers(string memberID)
        {
            if (string.IsNullOrWhiteSpace(memberID))
            {
                throw new ArgumentException("Member ID cannot be null or empty.", nameof(memberID));
            }
            return MemberRepository.FindMembers(memberID: memberID);
        }

        /// <summary>
        /// Initializes a new instance of the MemberService class,
        /// setting up the repository and validator dependencies.
        /// </summary>
        public MemberService()
        {
            MemberRepository = new MemberRepository();
            MemberValidator = new MemberValidator();
        }

        /// <summary>
        /// Generates a new unique Member ID by using the EntityRepository.
        /// The ID will have the prefix "MEM" and is based on the Members table's MemberID column.
        /// </summary>
        /// <returns>A unique Member ID string.</returns>
        public string GenerateMemberID()
        {
            return EntityRepository.GenerateId("Members", "MemberID", "MEM");
        }

        /// <summary>
        /// Retrieves all members from the repository.
        /// </summary>
        /// <returns>A list of all members.</returns>
        public List<Member> GetMembers()
        {
            return MemberRepository.GetAllMembers();
        }

        //Search members by stored procedure
        /* public List<Member> SearchMembers(string searchTerm)
         {
             if (string.IsNullOrWhiteSpace(searchTerm))
             {
                 throw new ArgumentException("Search term cannot be null or empty.", nameof(searchTerm));
             }
             return MemberRepository.GetMembersByStoredProcedure("SearchMembers", new SqlParameter("@SearchTerm", searchTerm));
         }*/

        /// <summary>
        /// Adds a new member to the repository after validating the member data.
        /// </summary>
        /// <param name="member">The member object to add.</param>
        /// <returns>The number of rows affected in the database.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the member is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the member data is invalid.</exception>
        public int AddMember(Member member)
        {
            if (member == null)
            {
                throw new ArgumentNullException(nameof(member), "Member cannot be null.");
            }
            if (!MemberValidator.IsvaliMember(member))
            {
                throw new ArgumentException("Invalid member data.", nameof(member));
            }
            return MemberRepository.Insert(member);
        }
    }
}
