using QLTHEs.Datas.Interfaces;
using QLTHEs.Datas.Models.stsdataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface IVanPhongRepository : IRepository<Vanphong>
    {

    }
    public class VanPhongRepository : Repository_stsdata<Vanphong>, IVanPhongRepository
    {
        public VanPhongRepository(stsdataContext context) : base(context)
        {
        }
    }
}
