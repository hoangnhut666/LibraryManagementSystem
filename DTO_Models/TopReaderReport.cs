using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class TopReaderReport
    {
        public string MemberID { get; set; }
        public string FullName { get; set; }
        public int BorrowCount{ get; set; }
    }
}
