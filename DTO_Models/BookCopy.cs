using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class BookCopy
    {
        public string? CopyID { get; set; } 
        public string? BookID { get; set; } 
        public string? Barcode { get; set; } 
        public string Status { get; set; } = "Có sẵn"; 
        public string? ConditionNotes { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }

    }
}
