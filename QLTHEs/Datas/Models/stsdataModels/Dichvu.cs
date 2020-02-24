using System;
using System.Collections.Generic;

namespace QLTHEs.Datas.Models.stsdataModels
{
    public partial class Dichvu
    {
        public Dichvu()
        {
            Giaodich = new HashSet<Giaodich>();
        }

        public string MaDv { get; set; }
        public string TenDv { get; set; }

        public virtual ICollection<Giaodich> Giaodich { get; set; }
    }
}
