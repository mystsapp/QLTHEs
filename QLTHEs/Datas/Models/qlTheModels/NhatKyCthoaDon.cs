﻿using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class NhatKyCthoaDon
    {
        public decimal Stt { get; set; }
        public string SoHd { get; set; }
        public string SeriTu { get; set; }
        public string SeriDen { get; set; }
        public string Seri { get; set; }
        public decimal? Gia { get; set; }
        public int? Sl { get; set; }
        public decimal? SoTien { get; set; }
        public string Nhanvien { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string MayTinh { get; set; }
    }
}
