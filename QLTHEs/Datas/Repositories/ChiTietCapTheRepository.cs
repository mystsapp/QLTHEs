using QLTHEs.Datas.Interfaces;
using QLTHEs.Datas.Models.qlTheModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface IChiTietCapTheRepository: IRepository<ChiTietCapThe>
    {

    }
    public class ChiTietCapTheRepository : Repository<ChiTietCapThe>, IChiTietCapTheRepository
    {
        public ChiTietCapTheRepository(qlTheContext context) : base(context)
        {
        }
    }
}
