using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class ChiTietCapThe
    {
        public decimal Stt { get; set; }
        public string MaCapThe { get; set; }
        public string SoSeriTu { get; set; }
        public string SoSeriDen { get; set; }
        public decimal? MenhGia { get; set; }
        public int? SoLuong { get; set; }

        public virtual CapThe MaCapTheNavigation { get; set; }
    }
}
