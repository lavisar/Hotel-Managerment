using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.Reportings
{
    public class ThongKeHoaDon
    {
        public string TenNV { get; set; }
        public string TenKH { get; set; }
        public int PhongID { get; set; }
        public int SoDem { get; set; }
        public int SoKhach { get; set; }
        public string NgayHD { get; set; }
        public int TongTien { get; set; }

    }
}
