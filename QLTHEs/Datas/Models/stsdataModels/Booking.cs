using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.stsdataModels
{
    public partial class Booking
    {
        public decimal Stt { get; set; }
        public string Sgtcode { get; set; }
        public string Masothuedv { get; set; }
        public string Masothuecn { get; set; }
        public string Dichvu { get; set; }
        public string Noidung { get; set; }
        public int? Sk { get; set; }
        public decimal? Sotien { get; set; }
        public DateTime Ngay { get; set; }
        public int? Sophong { get; set; }
        public string Nguondata { get; set; }
    }
}
