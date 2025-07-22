using DTO_Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace DTO_Models.ViewModel
{
    public class LoanViewModel
    {
        public string? MaMuon { get; set; }
        public string? MaBanSao { get; set; }
        public string? TenSach { get; set; }
        public string? TenDocGia { get; set; }
        public string? TenNhanVien { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public string? TrangThai { get; set; }
    }
}


