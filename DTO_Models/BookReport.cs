using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUTIL_Utilities;

namespace DTO_Models
{
    public class BookReport
    {
        public string BookID { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
        public DateTime LoanDate { get; set; }

        public string LoanDateString
        {
            get
            {
                return DBUTIL_Utilities.DateUtil.ToString(LoanDate, DBUTIL_Utilities.DateUtil.DatePattern.Date);
            }
        }
    }
}
