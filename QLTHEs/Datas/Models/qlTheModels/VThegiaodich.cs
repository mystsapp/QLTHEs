using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class VThegiaodich
    {
        public string SoSeri { get; set; }
        public DateTime? NgayHieuLuc { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string TrangThai { get; set; }
        public decimal? Gia { get; set; }
        public DateTime? NgayGd { get; set; }
        public string CodeDoan { get; set; }
        public string NguoiBan { get; set; }
        public string DaiLy { get; set; }
        public string NoiDung { get; set; }
        public string Khachhang { get; set; }
        public string Vetour { get; set; }
        public bool? Quatang { get; set; }
    }
}
