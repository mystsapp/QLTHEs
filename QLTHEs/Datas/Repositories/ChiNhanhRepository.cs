using QLTHEs.Datas.Interfaces;
using QLTHEs.Datas.Models.stsdataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface IChiNhanhRepository : IRepository<Chinhanh>
    {

    }
    public class ChiNhanhRepository : Repository_stsdata<Chinhanh>, IChiNhanhRepository
    {
        public ChiNhanhRepository(stsdataContext context) : base(context)
        {
        }
    }
}
