using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class ThongTinThe
    {
        public string SoSeri { get; set; }
        public string MaCapThe { get; set; }
        public decimal? Gia { get; set; }
        public string NguoiPhatHanh { get; set; }
        public DateTime? NgayPhatHanh { get; set; }
        public string NoiNhan { get; set; }
        public string NguoiNhan { get; set; }
        public string Trangthai { get; set; }
        public string Hinh1 { get; set; }
        public string Hinh2 { get; set; }
        public string GhiChu { get; set; }

        public virtual CapThe MaCapTheNavigation { get; set; }
        public virtual HoaDonThe HoaDonThe { get; set; }
    }
}
