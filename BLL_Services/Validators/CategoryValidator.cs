using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models;

namespace BLL_Services.Validators
{
    public class CategoryValidator
    {
        public string? ErrorMessage { get; private set; }
        public bool IsValidCategory(Category category)
        {
            if (category == null)
            {
                ErrorMessage = "Category cannot be null.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(category.CategoryID))
            {
                ErrorMessage = "Category ID cannot be null or empty.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(category.Name))
            {
                ErrorMessage = "Category name cannot be null or empty.";
                return false;
            }
            ErrorMessage = null; 
            return true;
        }
    }
}
