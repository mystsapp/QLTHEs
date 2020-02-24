using QLTHEs.Datas.Interfaces;
using QLTHEs.Datas.Models.qlTheModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface ILoaiThe_qlThe_Repository : IRepository<LoaiThe>
    {

    }
    public class LoaiThe_qlThe_Repository : Repository<LoaiThe>, ILoaiThe_qlThe_Repository
    {
        public LoaiThe_qlThe_Repository(qlTheContext context) : base(context)
        {
        }
    }
}
