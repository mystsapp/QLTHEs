using QLTHEs.Datas.Models.qlTheModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Models
{
    public class CapTheViewModel
    {
        public IEnumerable<CapThe> CapThes { get; set; }
        public IEnumerable<CapTheModel> CapTheModels { get; set; }
        public IEnumerable<ChiTietCapThe> ChiTietCapThes { get; set; }
        public IEnumerable<ThongTinThe> ThongTinThes { get; set; }
        public string strUrl { get; set; }
        
    }
}
