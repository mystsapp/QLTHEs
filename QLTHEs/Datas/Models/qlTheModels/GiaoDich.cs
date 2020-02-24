using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class GiaoDich
    {
        public string SoGd { get; set; }
        public DateTime? NgayGd { get; set; }
        public string Donvi { get; set; }
        public string Hopdong { get; set; }
        public string Seri { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string Khachhang { get; set; }
        public int? Sl { get; set; }
        public string LoaiDv { get; set; }
        public DateTime? NgaySd { get; set; }
        public string NoiDung { get; set; }
        public decimal? Giatri { get; set; }
        public int? Vat { get; set; }
        public decimal? Tonggiatri { get; set; }
        public string Vetour { get; set; }
        public string CodeDoan { get; set; }
        public string NguoiBan { get; set; }
        public string DaiLy { get; set; }
        public string LoaiThe { get; set; }
        public bool? Quatang { get; set; }
    }
}
