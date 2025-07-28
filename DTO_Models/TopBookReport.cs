using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class TopBookReport
    {
        public string BookID { get; set; }
        public string Title { get; set; }
        public int BorrowCount { get; set; }
    }
}
