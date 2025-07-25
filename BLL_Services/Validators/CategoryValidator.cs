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
                ErrorMessage = "Thể loại không được để trống.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(category.CategoryID))
            {
                ErrorMessage = "Mã thể loại không được để trống.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(category.Name))
            {
                ErrorMessage = "Tên thể loại không được để trống.";
                return false;
            }
            ErrorMessage = null; 
            return true;
        }
    }
}
