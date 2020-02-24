using QLTHEs.Datas.Interfaces;
using QLTHEs.Datas.Models.qlTheModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface IHTTTRepository: IRepository<Httt>
    {

    }
    public class HTTTRepository : Repository<Httt>, IHTTTRepository
    {
        public HTTTRepository(qlTheContext context) : base(context)
        {
        }
    }
}
