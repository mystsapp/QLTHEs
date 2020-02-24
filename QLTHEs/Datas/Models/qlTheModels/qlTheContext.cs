using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLTHEs.Datas.Models.qlTheModels
{
    public partial class qlTheContext : DbContext
    {
        public qlTheContext()
        {
        }

        public qlTheContext(DbContextOptions<qlTheContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CapThe> CapThe { get; set; }
        public virtual DbSet<ChiTietCapThe> ChiTietCapThe { get; set; }
        public virtual DbSet<CthoaDon> CthoaDon { get; set; }
        public virtual DbSet<GiaoDich> GiaoDich { get; set; }
        public virtual DbSet<GiaoDichThe> GiaoDichThe { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoaDonThe> HoaDonThe { get; set; }
        public virtual DbSet<Httt> Httt { get; set; }
        public virtual DbSet<Huythe> Huythe { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LoaiThe> LoaiThe { get; set; }
        public virtual DbSet<NhatKyCthoaDon> NhatKyCthoaDon { get; set; }
        public virtual DbSet<NhatKyGiaoDich> NhatKyGiaoDich { get; set; }
        public virtual DbSet<NhatKyHoaDon> NhatKyHoaDon { get; set; }
        public virtual DbSet<NhatKyHoadonThe> NhatKyHoadonThe { get; set; }
        public virtual DbSet<NhatKyThe> NhatKyThe { get; set; }
        public virtual DbSet<TheDaHuy> TheDaHuy { get; set; }
        public virtual DbSet<ThongTinThe> ThongTinThe { get; set; }
        public virtual DbSet<TrangThai> TrangThai { get; set; }
        public virtual DbSet<VCapthe> VCapthe { get; set; }
        public virtual DbSet<VCthoadon> VCthoadon { get; set; }
        public virtual DbSet<VHoadon> VHoadon { get; set; }
        public virtual DbSet<VTheHoadon> VTheHoadon { get; set; }
        public virtual DbSet<VThegiaodich> VThegiaodich { get; set; }
        public virtual DbSet<VThongtinthe> VThongtinthe { get; set; }
        public virtual DbSet<VThongtintheTungayDenngay> VThongtintheTungayDenngay { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=192.168.4.198;database=qlThe;Trusted_Connection=true;User Id=sa;Password=TigerSts@2017;Integrated security=false;MultipleActiveResultSets=true");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CapThe>(entity =>
            {
                entity.HasKey(e => e.MaCapThe)
                    .HasName("PK_XuatThe");

                entity.Property(e => e.MaCapThe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChiNhanh)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hoadon)
                    .HasColumnName("hoadon")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Httt)
                    .HasColumnName("HTTT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MayTinh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.NgayCap).HasColumnType("smalldatetime");

                entity.Property(e => e.NguoiCap).HasMaxLength(50);

                entity.Property(e => e.NguoiNhan).HasMaxLength(50);

                entity.Property(e => e.TongSoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.VanPhong)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChiTietCapThe>(entity =>
            {
                entity.HasKey(e => new { e.MaCapThe, e.Stt });

                entity.Property(e => e.MaCapThe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MenhGia)
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoSeriDen)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SoSeriTu)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaCapTheNavigation)
                    .WithMany(p => p.ChiTietCapThe)
                    .HasForeignKey(d => d.MaCapThe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietCapThe_CapThe");
            });

            modelBuilder.Entity<CthoaDon>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("CTHoaDon");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Gia).HasColumnType("decimal(14, 0)");

                entity.Property(e => e.Seri)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeriDen)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SeriTu)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SoHd)
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SoTien).HasColumnType("decimal(14, 0)");

                entity.HasOne(d => d.SoHdNavigation)
                    .WithMany(p => p.CthoaDon)
                    .HasForeignKey(d => d.SoHd)
                    .HasConstraintName("FK_CTHoaDon_HoaDon");
            });

            modelBuilder.Entity<GiaoDich>(entity =>
            {
                entity.HasKey(e => e.SoGd)
                    .HasName("PK_GiaoDichThe_1");

                entity.Property(e => e.SoGd)
                    .HasColumnName("SoGD")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.CodeDoan)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DaiLy).HasMaxLength(50);

                entity.Property(e => e.Donvi).HasMaxLength(30);

                entity.Property(e => e.Giatri).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Hopdong).HasMaxLength(20);

                entity.Property(e => e.Khachhang).HasMaxLength(50);

                entity.Property(e => e.LoaiDv)
                    .HasColumnName("LoaiDV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiThe)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NgayGd)
                    .HasColumnName("NgayGD")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayHetHan).HasColumnType("date");

                entity.Property(e => e.NgaySd)
                    .HasColumnName("NgaySD")
                    .HasColumnType("date");

                entity.Property(e => e.NguoiBan).HasMaxLength(50);

                entity.Property(e => e.NoiDung).HasMaxLength(80);

                entity.Property(e => e.Quatang).HasColumnName("quatang");

                entity.Property(e => e.Seri)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Tonggiatri).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Vetour)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GiaoDichThe>(entity =>
            {
                entity.HasKey(e => e.SoSeri);

                entity.Property(e => e.SoSeri)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NgayGd)
                    .HasColumnName("NgayGD")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SoGd)
                    .HasColumnName("SoGD")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.SoHd);

                entity.Property(e => e.SoHd)
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.CodeDoan)
                    .HasColumnName("codeDoan")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DaTra)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Daily).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(70);

                entity.Property(e => e.DonVi).HasMaxLength(30);

                entity.Property(e => e.Hoadon1)
                    .HasColumnName("hoadon")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HopDong).HasMaxLength(30);

                entity.Property(e => e.NgayHd)
                    .HasColumnName("NgayHD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NgayTra)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(50);

                entity.Property(e => e.Nhanvien).HasMaxLength(50);

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoTien)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HoaDonThe>(entity =>
            {
                entity.HasKey(e => e.SoSeri);

                entity.Property(e => e.SoSeri)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DaiLy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(100);

                entity.Property(e => e.NgayHetHan).HasColumnType("date");

                entity.Property(e => e.NgayHieuLuc).HasColumnType("date");

                entity.Property(e => e.NguoiBan).HasMaxLength(50);

                entity.Property(e => e.Quatang).HasDefaultValueSql("(N'false')");

                entity.Property(e => e.SoHd)
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(50);

                entity.HasOne(d => d.SoHdNavigation)
                    .WithMany(p => p.HoaDonThe)
                    .HasForeignKey(d => d.SoHd)
                    .HasConstraintName("FK_HoaDonThe_HoaDon");

                entity.HasOne(d => d.SoSeriNavigation)
                    .WithOne(p => p.HoaDonThe)
                    .HasForeignKey<HoaDonThe>(d => d.SoSeri)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDonThe_ThongTinThe");
            });

            modelBuilder.Entity<Httt>(entity =>
            {
                entity.HasKey(e => e.MaHt);

                entity.ToTable("HTTT");

                entity.Property(e => e.MaHt)
                    .HasColumnName("MaHT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TenHt)
                    .HasColumnName("TenHT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Huythe>(entity =>
            {
                entity.HasKey(e => e.MaSoHuy);

                entity.Property(e => e.MaSoHuy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Daily).HasMaxLength(50);

                entity.Property(e => e.Maytinh).HasMaxLength(50);

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.Property(e => e.NgayHuy).HasColumnType("datetime");

                entity.Property(e => e.NguoiBan).HasMaxLength(50);

                entity.Property(e => e.NguoiHuy).HasMaxLength(50);

                entity.Property(e => e.Seri)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeKh)
                    .HasColumnName("codeKH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChiKh)
                    .HasColumnName("DiaChiKH")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.MaSt)
                    .HasColumnName("MaST")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaTp)
                    .HasColumnName("MaTP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NguoiLienHe).HasMaxLength(50);

                entity.Property(e => e.SoDt)
                    .HasColumnName("SoDT")
                    .HasMaxLength(20);

                entity.Property(e => e.SoDtNlh)
                    .HasColumnName("SoDT_NLH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiThe>(entity =>
            {
                entity.HasKey(e => e.LoaiThe1);

                entity.Property(e => e.LoaiThe1)
                    .HasColumnName("LoaiThe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ghichu).HasMaxLength(50);

                entity.Property(e => e.TenLoai).HasMaxLength(50);
            });

            modelBuilder.Entity<NhatKyCthoaDon>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("NhatKyCTHoaDon");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Gia).HasColumnType("decimal(14, 0)");

                entity.Property(e => e.MayTinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayCapNhat).HasColumnType("smalldatetime");

                entity.Property(e => e.Nhanvien).HasMaxLength(50);

                entity.Property(e => e.Seri)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeriDen)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SeriTu)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SoHd)
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SoTien).HasColumnType("decimal(14, 0)");
            });

            modelBuilder.Entity<NhatKyGiaoDich>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodeDoan)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DaiLy).HasMaxLength(50);

                entity.Property(e => e.Donvi).HasMaxLength(30);

                entity.Property(e => e.Giatri).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Hopdong).HasMaxLength(20);

                entity.Property(e => e.Khachhang).HasMaxLength(50);

                entity.Property(e => e.LoaiDv)
                    .HasColumnName("LoaiDV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiThe)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Maytinh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayGd)
                    .HasColumnName("NgayGD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.Property(e => e.NgaySd)
                    .HasColumnName("NgaySD")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiBan).HasMaxLength(30);

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(20);

                entity.Property(e => e.NoiDung).HasMaxLength(80);

                entity.Property(e => e.Quatang).HasColumnName("quatang");

                entity.Property(e => e.Seri)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SoGd)
                    .HasColumnName("SoGD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Tonggiatri).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.VeTour)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NhatKyHoaDon>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodeDoan)
                    .HasColumnName("codeDoan")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DaTra).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Daily).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(70);

                entity.Property(e => e.DonVi).HasMaxLength(50);

                entity.Property(e => e.Hoadon)
                    .HasColumnName("hoadon")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HopDong).HasMaxLength(50);

                entity.Property(e => e.MayTinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHd)
                    .HasColumnName("NgayHD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NgayTra).HasColumnType("smalldatetime");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(50);

                entity.Property(e => e.Nhanvien).HasMaxLength(50);

                entity.Property(e => e.SoHd)
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NhatKyHoadonThe>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DaiLy).HasMaxLength(30);

                entity.Property(e => e.Ghichu).HasMaxLength(100);

                entity.Property(e => e.Maytinh).HasMaxLength(50);

                entity.Property(e => e.NgayCapNhat).HasColumnType("smalldatetime");

                entity.Property(e => e.NgayHetHan).HasColumnType("smalldatetime");

                entity.Property(e => e.NgayHieuLuc).HasColumnType("smalldatetime");

                entity.Property(e => e.NguoiBan).HasMaxLength(50);

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(50);

                entity.Property(e => e.SoHd)
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Soseri)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NhatKyThe>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ghichu).HasMaxLength(200);

                entity.Property(e => e.Gia).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Hinh1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hinh2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaCapThe).HasMaxLength(10);

                entity.Property(e => e.Maytinh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiCapNhat).HasMaxLength(50);

                entity.Property(e => e.NguoiNhan).HasMaxLength(50);

                entity.Property(e => e.NoiNhan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoSeri)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TheDaHuy>(entity =>
            {
                entity.HasKey(e => e.SoSeri);

                entity.Property(e => e.SoSeri)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaSoHuy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Maytinh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.Property(e => e.NgayHuy)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiHuy).HasMaxLength(50);

                entity.HasOne(d => d.MaSoHuyNavigation)
                    .WithMany(p => p.TheDaHuy)
                    .HasForeignKey(d => d.MaSoHuy)
                    .HasConstraintName("FK_TheDaHuy_Huythe");
            });

            modelBuilder.Entity<ThongTinThe>(entity =>
            {
                entity.HasKey(e => e.SoSeri)
                    .HasName("PK_ThongTinThe_1");

                entity.Property(e => e.SoSeri)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.Gia).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Hinh1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hinh2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaCapThe)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayPhatHanh)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiNhan).HasMaxLength(50);

                entity.Property(e => e.NguoiPhatHanh).HasMaxLength(50);

                entity.Property(e => e.NoiNhan).HasMaxLength(50);

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaCapTheNavigation)
                    .WithMany(p => p.ThongTinThe)
                    .HasForeignKey(d => d.MaCapThe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThongTinThe_CapThe");
            });

            modelBuilder.Entity<TrangThai>(entity =>
            {
                entity.HasKey(e => e.MaTt);

                entity.Property(e => e.MaTt)
                    .HasColumnName("MaTT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.TenTt)
                    .HasColumnName("TenTT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VCapthe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCAPTHE");

                entity.Property(e => e.ChiNhanh)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Httt)
                    .HasColumnName("HTTT")
                    .HasMaxLength(50);

                entity.Property(e => e.MaCapThe)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MayTinh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayCap).HasColumnType("smalldatetime");

                entity.Property(e => e.NguoiCap).HasMaxLength(50);

                entity.Property(e => e.NguoiNhan).HasMaxLength(50);

                entity.Property(e => e.VanPhong).HasMaxLength(50);
            });

            modelBuilder.Entity<VCthoadon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCTHOADON");

                entity.Property(e => e.Ghichu).HasMaxLength(50);

                entity.Property(e => e.Gia).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.NgayHetHan).HasColumnType("smalldatetime");

                entity.Property(e => e.NgayHieuLuc).HasColumnType("smalldatetime");

                entity.Property(e => e.SoHd)
                    .IsRequired()
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SoSeri)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHoadon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vHOADON");

                entity.Property(e => e.DaTra).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Daily).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(70);

                entity.Property(e => e.DonVi).HasMaxLength(30);

                entity.Property(e => e.HopDong).HasMaxLength(30);

                entity.Property(e => e.NgayHd)
                    .HasColumnName("NgayHD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Nhanvien).HasMaxLength(50);

                entity.Property(e => e.SoHd)
                    .IsRequired()
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<VTheHoadon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTHE_HOADON");

                entity.Property(e => e.DiaChi).HasMaxLength(70);

                entity.Property(e => e.DonVi).HasMaxLength(30);

                entity.Property(e => e.Ghichu).HasMaxLength(100);

                entity.Property(e => e.Gia).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.HopDong).HasMaxLength(30);

                entity.Property(e => e.NgayHd)
                    .HasColumnName("NgayHD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NgayHetHan).HasColumnType("date");

                entity.Property(e => e.NgayHieuLuc).HasColumnType("date");

                entity.Property(e => e.Nhanvien).HasMaxLength(50);

                entity.Property(e => e.SoHd)
                    .IsRequired()
                    .HasColumnName("SoHD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SoSeri)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VThegiaodich>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTHEGIAODICH");

                entity.Property(e => e.CodeDoan)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DaiLy).HasMaxLength(50);

                entity.Property(e => e.Gia).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Khachhang).HasMaxLength(50);

                entity.Property(e => e.NgayGd)
                    .HasColumnName("NgayGD")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayHetHan).HasColumnType("date");

                entity.Property(e => e.NgayHieuLuc).HasColumnType("date");

                entity.Property(e => e.NguoiBan).HasMaxLength(50);

                entity.Property(e => e.NoiDung).HasMaxLength(80);

                entity.Property(e => e.SoSeri)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.Property(e => e.Vetour)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VThongtinthe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTHONGTINTHE");

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.Gia).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Hinh1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hinh2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NguoiNhan).HasMaxLength(50);

                entity.Property(e => e.NoiNhan).HasMaxLength(50);

                entity.Property(e => e.SoSeri)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai).HasMaxLength(50);
            });

            modelBuilder.Entity<VThongtintheTungayDenngay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTHONGTINTHE_TUNGAY_DENNGAY");

                entity.Property(e => e.NgayPhatHanh).HasColumnType("smalldatetime");

                entity.Property(e => e.NguoiNhan).HasMaxLength(50);

                entity.Property(e => e.SoSeri)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TenVp)
                    .HasColumnName("TenVP")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
