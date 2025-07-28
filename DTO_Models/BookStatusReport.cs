using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class BookStatusReport
    {
        public string BookID { get; set; }
        public string Title { get; set; }
        public string Status { get; set; } // Available, Borrowed, Lost, Damaged...
    }
}
