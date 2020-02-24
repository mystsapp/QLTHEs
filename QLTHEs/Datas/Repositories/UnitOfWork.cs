using QLTHEs.Datas.Models.qlTheModels;
using QLTHEs.Datas.Models.stsdataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTHEs.Datas.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICapTheRepository capTheRepository { get; }
        IChiNhanhRepository chiNhanhRepository { get; }
        IChiTietCapTheRepository chiTietCapTheRepository { get; }
        IHTTTRepository hTTTRepository { get; }
        ILoaiThe_qlThe_Repository loaiThe_QlThe_Repository { get; }
        INhanVienRepository nhanVienRepository { get; }
        IVanPhongRepository vanPhongRepository { get; }
        IThongTinTheRepository thongTinTheRepository { get; }
        Task<int> Complete_qlThe();
        Task<int> Complete_stsdata();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly qlTheContext _qlTheContext;
        private readonly stsdataContext _stsdataContext;

        public UnitOfWork(qlTheContext qlTheContext, stsdataContext stsdataContext)
        {
            _qlTheContext = qlTheContext;
            _stsdataContext = stsdataContext;

            capTheRepository = new CapTheRepository(_qlTheContext);
            chiNhanhRepository = new ChiNhanhRepository(_stsdataContext);
            chiTietCapTheRepository = new ChiTietCapTheRepository(_qlTheContext);
            hTTTRepository = new HTTTRepository(_qlTheContext);
            loaiThe_QlThe_Repository = new LoaiThe_qlThe_Repository(_qlTheContext);
            nhanVienRepository = new NhanVienRepository(_stsdataContext);
            vanPhongRepository = new VanPhongRepository(_stsdataContext);
            thongTinTheRepository = new ThongTinTheRepository(_qlTheContext);
        }

        public ICapTheRepository capTheRepository { get; }

        public IChiNhanhRepository chiNhanhRepository { get; }

        public IChiTietCapTheRepository chiTietCapTheRepository { get; }

        public IHTTTRepository hTTTRepository { get; }

        public ILoaiThe_qlThe_Repository loaiThe_QlThe_Repository { get; }

        public INhanVienRepository nhanVienRepository { get; }

        public IVanPhongRepository vanPhongRepository { get; }

        public IThongTinTheRepository thongTinTheRepository { get; }

        public async Task<int> Complete_qlThe()
        {
            return await _qlTheContext.SaveChangesAsync(); ;
        }
        public async Task<int> Complete_stsdata()
        {
            return await _stsdataContext.SaveChangesAsync(); ;
        }

        public void Dispose()
        {
            _qlTheContext.Dispose();
            _stsdataContext.Dispose();
        }

    }
}
