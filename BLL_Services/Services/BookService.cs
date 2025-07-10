using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;
using DTO_Models;

namespace BLL_Services.Services
{
    
    public class BookService
    {
        private BookRepository BookRepository { get; set; }
        private PublisherService PublisherService { get; set; }
        private CategoryService CategoryService { get; set; }

        public BookService()
        {
            BookRepository = new BookRepository();
            PublisherService = new PublisherService();
            CategoryService = new CategoryService();
        }

        // Get all books from the repository
        public List<Book> GetBooks()
        {
            try
            {
                return BookRepository.GetAllBooks();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving books.", ex);
            }
        }



    }
}
