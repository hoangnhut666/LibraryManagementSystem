using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class Fine
    {
        public string? FineID { get; set; }          
        public string? LoanID { get; set; }          
        public decimal? Amount { get; set; }        
        public DateTime? IssueDate { get; set; }     
        public bool Paid { get; set; }               
        public string? Reason { get; set; }           
    }
}
