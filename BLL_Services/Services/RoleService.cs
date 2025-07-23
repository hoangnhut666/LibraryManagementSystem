using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models;
using DAL_Data;

namespace BLL_Services.Services
{
    public class RoleService
    {
        public List<Role> GetAllRoles()
        {
            RoleRespository roleRepository = new RoleRespository();
            return roleRepository.GetAllRoles();
        }

    }
}
