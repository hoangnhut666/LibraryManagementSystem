using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;

namespace BLL_Services.Services
{
    public class CategoryService
    {
        private CategoryRepository CategoryRepository { get; set; }
        private CategoryValidator CategoryValidator { get; set; }

        public CategoryService()
        {
            CategoryRepository = new CategoryRepository();
            CategoryValidator = new CategoryValidator();
        }

        // Auto-generate CategoryID
        public string GenerateCategoryID()
        {
            return EntityRepository.GenerateId("Categories", "CategoryID", "CAT");
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

        //Search categories by search term
        public List<Category> SearchCategories(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Search term cannot be null or empty.", nameof(searchTerm));
            }
            return CategoryRepository.SearchCategories(searchTerm);
        }

        //Insert a new category
        public int AddCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null.");
            }
            if (!CategoryValidator.IsValidCategory(category))
            {
                throw new ArgumentException(CategoryValidator.ErrorMessage, nameof(category));
            }
            return CategoryRepository.Insert(category);
        }

        //Update an existing category
        public int UpdateCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null.");
            }
            if (!CategoryValidator.IsValidCategory(category))
            {
                throw new ArgumentException(CategoryValidator.ErrorMessage, nameof(category));
            }
            return CategoryRepository.Update(category);
        }

        //Delete a category by ID
        public int DeleteCategory(string categoryId)
        {
            if (string.IsNullOrWhiteSpace(categoryId))
            {
                throw new ArgumentException("Category ID cannot be null or empty.", nameof(categoryId));
            }
            return CategoryRepository.Delete(categoryId);
        }

    }
}