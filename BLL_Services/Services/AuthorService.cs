using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;
using DTO_Models;


namespace BLL_Services.Services
{
    public class AuthorService
    {
        private readonly AuthorRepository authorRepository;
        public AuthorService() { 
            authorRepository = new AuthorRepository();
        }

        //Get all authors
        public List<Author> GetAuthors()
        {
            return authorRepository.GetAllAuthors();
        }
    }
}
