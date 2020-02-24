using QLTHEs.Datas.Interfaces;
using QLTHEs.Datas.Models.qlTheModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface IThongTinTheRepository : IRepository<ThongTinThe>
    {

    }
    public class ThongTinTheRepository : Repository<ThongTinThe>, IThongTinTheRepository
    {
        public ThongTinTheRepository(qlTheContext context) : base(context)
        {
        }
    }
}
