using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class Huythe
    {
        public Huythe()
        {
            TheDaHuy = new HashSet<TheDaHuy>();
        }

        public string MaSoHuy { get; set; }
        public DateTime? NgayHuy { get; set; }
        public string Seri { get; set; }
        public int? Sl { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string NguoiBan { get; set; }
        public string Daily { get; set; }
        public string NguoiHuy { get; set; }
        public string Maytinh { get; set; }

        public virtual ICollection<TheDaHuy> TheDaHuy { get; set; }
    }
}
