using QLTHEs.Datas.Interfaces;
using QLTHEs.Datas.Models.qlTheModels;
using QLTHEs.Datas.Models.stsdataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface INhanVienRepository : IRepository<Nhanvien>
    {

    }
    public class NhanVienRepository : Repository_stsdata<Nhanvien>, INhanVienRepository
    {
        public NhanVienRepository(stsdataContext context) : base(context)
        {
        }
    }
}
