using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public string? BookID { get; set; }

        public string? MemberID { get; set; }

        public string? Expression { get; set; }

        public string? ReviewText { get; set; }
    }
}
