using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;
using DTO_Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Services
{
    public class MemberService
    {
        public MemberRepository MemberRepository { get; set; }
        public MemberValidator MemberValidator { get; set; }

        public MemberService()
        {
            MemberRepository = new MemberRepository();
            MemberValidator = new MemberValidator();
        }

        // Auto-generate MemberID
        public string GenerateMemberID()
        {
            return EntityRepository.GenerateId("Members", "MemberID", "MEM");
        }

        // Get all members
        public List<Member> GetMembers()
        {
            try
            {
                return MemberRepository.GetAllMembers();
            }
            catch (Exception ex)
            {
                throw new Exception("Một lỗi xảy ra khi lấy danh sách thành viên.", ex);
            }
        }

        // Search members by criteria
        public List<Member> SearchMembers(string columnName, string value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tên cột và giá trị không được để trống.");
            }
            return MemberRepository.GetMembersByCriteria(columnName, value);
        }

        // Search members by search term
        public List<Member> SearchMembers(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Tiêu chí tìm kiếm không được để trống.", nameof(searchTerm));
            }
            return MemberRepository.SearchMembers(searchTerm);
        }

        // Get member by ID
        public Member GetMemberById(string memberID)
        {
            if (string.IsNullOrWhiteSpace(memberID))
            {
                throw new ArgumentException("Mã thành viên không được để trống.", nameof(memberID));
            }
            return SearchMembers("MemberID", memberID).FirstOrDefault() ?? throw new KeyNotFoundException($"Member with ID {memberID} not found.");
        }

        // Insert a new member
        public int AddMember(Member member)
        {
            if (member == null)
            {
                throw new ArgumentNullException(nameof(member), "Thành viên không được để trống.");
            }
            if (!MemberValidator.IsValidMember(member))
            {
                throw new ArgumentException(MemberValidator.ErrorMessage, nameof(member));
            }
            return MemberRepository.Insert(member);
        }


        // Update an existing member
        public int UpdateMember(Member member)
        {
            if (member == null)
            {
                throw new ArgumentNullException(nameof(member), "Thành viên không được để trống.");
            }

            if (!MemberValidator.IsValidMember(member))
            {
                throw new ArgumentException(MemberValidator.ErrorMessage, nameof(member));
            }
            return MemberRepository.Update(member);
        }

        // Delete a member
        public int DeleteMember(string memberID)
        {
            if (string.IsNullOrWhiteSpace(memberID))
            {
                throw new ArgumentException("Mã thành viên không được để trống.", nameof(memberID));
            }
            return MemberRepository.Delete(memberID);
        }
    }
}

