using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models.ViewModel
{
    public class BookReportViewModel
    {
            public string? MaBanSao{ get; set; }         
            public string? TieuDe { get; set; }       
            public string? TheLoai { get; set; }  
            public string? TenNguoiMuon { get; set; }  
            public DateTime NgayMuon { get; set; }    
            public DateTime HanTra { get; set; }     
            public DateTime? NgayTra { get; set; } 
            public string? TrangThai { get; set; }       
    }
}

