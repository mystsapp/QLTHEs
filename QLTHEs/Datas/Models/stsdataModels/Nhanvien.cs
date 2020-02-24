using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.stsdataModels
{
    public partial class Nhanvien
    {
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string TenDn { get; set; }
        public string MatKhau { get; set; }
        public string MaCn { get; set; }
        public string MaVp { get; set; }
        public string MaPhong { get; set; }
        public bool? TrangThai { get; set; }
        public string Email { get; set; }
        public bool? DoiMk { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}
