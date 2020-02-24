using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class HoaDonThe
    {
        public string SoHd { get; set; }
        public string SoSeri { get; set; }
        public string TenKh { get; set; }
        public DateTime? NgayHieuLuc { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string NguoiBan { get; set; }
        public string DaiLy { get; set; }
        public bool? Quatang { get; set; }
        public string Ghichu { get; set; }

        public virtual HoaDon SoHdNavigation { get; set; }
        public virtual ThongTinThe SoSeriNavigation { get; set; }
    }
}
