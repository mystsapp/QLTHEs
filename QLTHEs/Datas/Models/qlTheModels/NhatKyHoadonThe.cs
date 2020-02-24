using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class NhatKyHoadonThe
    {
        public decimal Stt { get; set; }
        public string SoHd { get; set; }
        public string Soseri { get; set; }
        public string TenKh { get; set; }
        public DateTime? NgayHieuLuc { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string NguoiBan { get; set; }
        public string DaiLy { get; set; }
        public bool? Quatang { get; set; }
        public string Ghichu { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string Maytinh { get; set; }
    }
}
