using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class Loan
    {
        public string? LoanID { get; set; }
        public string? CopyID { get; set; }
        public string? MemberID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? Status { get; set; }
        public string? Notes { get; set; }
    }
}
