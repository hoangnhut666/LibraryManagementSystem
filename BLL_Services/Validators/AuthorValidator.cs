using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Models;

namespace BLL_Services.Validators
{
    public class AuthorValidator
    {
        public string? ErrorMessage { get; private set; }

        public AuthorValidator() { 
            
        }

        public bool IsValidAuthor(Author author)
        {

            // Check if the author name is not empty
            if (string.IsNullOrWhiteSpace(author.FullName))
            {
                ErrorMessage = "Author name cannot be empty.";
                return false;
            }

            //Check if date of birth is not after date of death
            if (author.DateOfBirth.HasValue && author.DateOfDeath.HasValue && author.DateOfBirth > author.DateOfDeath)
            {
                ErrorMessage = "Date of birth cannot be after date of death.";
                return false;
            }

            //Check if date of birth is not in the future
            if (author.DateOfBirth.HasValue && author.DateOfBirth > DateTime.Now)
            {
                ErrorMessage = "Date of birth cannot be in the future.";
                return false;
            }

            //Check if date of death is not in the future
            if (author.DateOfDeath.HasValue && author.DateOfDeath > DateTime.Now)
            {
                ErrorMessage = "Date of death cannot be in the future.";
                return false;
            }

            return true;
        }
    }
}
