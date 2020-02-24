using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            CthoaDon = new HashSet<CthoaDon>();
            HoaDonThe = new HashSet<HoaDonThe>();
        }

        public string SoHd { get; set; }
        public DateTime? NgayHd { get; set; }
        public string CodeDoan { get; set; }
        public string HopDong { get; set; }
        public string Nhanvien { get; set; }
        public string Daily { get; set; }
        public string DonVi { get; set; }
        public string DiaChi { get; set; }
        public int? SoLuong { get; set; }
        public decimal? SoTien { get; set; }
        public decimal? DaTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool? Hoadon1 { get; set; }

        public virtual ICollection<CthoaDon> CthoaDon { get; set; }
        public virtual ICollection<HoaDonThe> HoaDonThe { get; set; }
    }
}
