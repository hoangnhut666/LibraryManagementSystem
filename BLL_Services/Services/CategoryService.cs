using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;
using DTO_Models;

namespace BLL_Services.Services
{
    public class CategoryService
    {
        private CategoryRepository CategoryRepository { get; set; }

        public CategoryService()
        {
            CategoryRepository = new CategoryRepository();
        }

        // Get all categories from the repository
        public List<Category> GetCategories()
        {
            try
            {
                return CategoryRepository.GetAllCategories();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving categories.", ex);
            }
        }
    }
}
