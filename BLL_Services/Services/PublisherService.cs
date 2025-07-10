using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data;
using DTO_Models;

namespace BLL_Services.Services
{
    public class PublisherService
    {
        public PublisherRepository PublisherRepository { get; set; }

        public PublisherService()
        {
            PublisherRepository = new PublisherRepository();
        }

        // Get all publishers from the repository
        public List<Publisher> GetPublishers()
        {
            try
            {
                return PublisherRepository.GetAllPublishers();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving publishers.", ex);
            }
        }


    }
}
