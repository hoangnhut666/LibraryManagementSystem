using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class Book
    {
        public string? BookID { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? PublisherID { get; set; }
        public int? PublicationYear { get; set; }
        public string? CategoryID { get; set; }
        public string? ShelfLocation { get; set; }
        public int? NumberOfPages { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        public byte[]? CoverImage { get; set; }
    }
}
