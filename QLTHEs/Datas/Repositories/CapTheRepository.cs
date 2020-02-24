using QLTHEs.Datas.Interfaces;
using QLTHEs.Datas.Models.qlTheModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface ICapTheRepository: IRepository<CapThe>
    {

    }
    public class CapTheRepository : Repository<CapThe>, ICapTheRepository
    {
        public CapTheRepository(qlTheContext context) : base(context)
        {
        }
    }
}
