using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class TheDaHuy
    {
        public string SoSeri { get; set; }
        public string MaSoHuy { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public DateTime? NgayHuy { get; set; }
        public string NguoiHuy { get; set; }
        public string Maytinh { get; set; }

        public virtual Huythe MaSoHuyNavigation { get; set; }
    }
}
