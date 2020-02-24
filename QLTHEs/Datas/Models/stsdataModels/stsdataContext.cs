using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLTHEs.Datas.Models.stsdataModels
{
    public partial class stsdataContext : DbContext
    {
        public stsdataContext()
        {
        }

        public stsdataContext(DbContextOptions<stsdataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Chinhanh> Chinhanh { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyTemp> CompanyTemp { get; set; }
        public virtual DbSet<CompanyTrace> CompanyTrace { get; set; }
        public virtual DbSet<Dichvu> Dichvu { get; set; }
        public virtual DbSet<Doituong> Doituong { get; set; }
        public virtual DbSet<Giaodich> Giaodich { get; set; }
        public virtual DbSet<Giaodich1> Giaodich1 { get; set; }
        public virtual DbSet<Httt> Httt { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Khachhang1> Khachhang1 { get; set; }
        public virtual DbSet<Loaichuongtrinh> Loaichuongtrinh { get; set; }
        public virtual DbSet<Loaithe> Loaithe { get; set; }
        public virtual DbSet<LogGiaodich> LogGiaodich { get; set; }
        public virtual DbSet<LogKhachhang> LogKhachhang { get; set; }
        public virtual DbSet<LogThekh> LogThekh { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Phongban> Phongban { get; set; }
        public virtual DbSet<Services2crm> Services2crm { get; set; }
        public virtual DbSet<Thanhpho> Thanhpho { get; set; }
        public virtual DbSet<Thekh> Thekh { get; set; }
        public virtual DbSet<Truycapchuongtrinh> Truycapchuongtrinh { get; set; }
        public virtual DbSet<VCapthekh> VCapthekh { get; set; }
        public virtual DbSet<VCapthekhLog> VCapthekhLog { get; set; }
        public virtual DbSet<VThekhachhang> VThekhachhang { get; set; }
        public virtual DbSet<VThongtindangnhap> VThongtindangnhap { get; set; }
        public virtual DbSet<Vanphong> Vanphong { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=192.168.4.198;database=stsdata;Trusted_Connection=true;User Id=sa;Password=TigerSts@2017;Integrated security=false;MultipleActiveResultSets=true");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("booking");

                entity.Property(e => e.Stt)
                    .HasColumnName("stt")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dichvu)
                    .IsRequired()
                    .HasColumnName("dichvu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Masothuecn)
                    .IsRequired()
                    .HasColumnName("masothuecn")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Masothuedv)
                    .IsRequired()
                    .HasColumnName("masothuedv")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Ngay)
                    .HasColumnName("ngay")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguondata)
                    .HasColumnName("nguondata")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Noidung)
                    .HasColumnName("noidung")
                    .HasMaxLength(100);

                entity.Property(e => e.Sgtcode)
                    .HasColumnName("sgtcode")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Sk)
                    .HasColumnName("sk")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sophong)
                    .HasColumnName("sophong")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sotien)
                    .HasColumnName("sotien")
                    .HasColumnType("decimal(12, 0)");
            });

            modelBuilder.Entity<Chinhanh>(entity =>
            {
                entity.HasKey(e => e.MaCn);

                entity.ToTable("CHINHANH");

                entity.Property(e => e.MaCn)
                    .HasColumnName("MaCN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodeTkh)
                    .HasColumnName("CodeTKH")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaTp)
                    .HasColumnName("MaTP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenCn)
                    .HasColumnName("TenCN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Chinhanh)
                    .IsRequired()
                    .HasColumnName("chinhanh")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codecn)
                    .IsRequired()
                    .HasColumnName("codecn")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasColumnName("diachi")
                    .HasMaxLength(150);

                entity.Property(e => e.Dienthoai)
                    .HasColumnName("dienthoai")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dienthoai1)
                    .HasColumnName("dienthoai1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Httt)
                    .HasColumnName("httt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Masothue)
                    .HasColumnName("masothue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nganhnghe)
                    .HasColumnName("nganhnghe")
                    .HasMaxLength(50);

                entity.Property(e => e.Nhanvien)
                    .HasColumnName("nhanvien")
                    .HasMaxLength(50);

                entity.Property(e => e.Quocgia)
                    .IsRequired()
                    .HasColumnName("quocgia")
                    .HasMaxLength(50);

                entity.Property(e => e.Tengiaodich)
                    .IsRequired()
                    .HasColumnName("tengiaodich")
                    .HasMaxLength(100);

                entity.Property(e => e.Tenthuongmai)
                    .IsRequired()
                    .HasColumnName("tenthuongmai")
                    .HasMaxLength(100);

                entity.Property(e => e.Thanhpho)
                    .IsRequired()
                    .HasColumnName("thanhpho")
                    .HasMaxLength(50);

                entity.Property(e => e.Thongtin).HasColumnName("thongtin");

                entity.Property(e => e.Vemaybay).HasColumnName("vemaybay");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CompanyTemp>(entity =>
            {
                entity.ToTable("company_temp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Capnhat)
                    .HasColumnName("capnhat")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Chinhanh)
                    .HasColumnName("chinhanh")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Codecn)
                    .HasColumnName("codecn")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi)
                    .HasColumnName("diachi")
                    .HasMaxLength(150);

                entity.Property(e => e.Dienthoai)
                    .HasColumnName("dienthoai")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dienthoai1)
                    .HasColumnName("dienthoai1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Httt)
                    .HasColumnName("httt")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Masothue)
                    .HasColumnName("masothue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nganhnghe)
                    .HasColumnName("nganhnghe")
                    .HasMaxLength(50);

                entity.Property(e => e.Quocgia)
                    .HasColumnName("quocgia")
                    .HasMaxLength(50);

                entity.Property(e => e.Tengiaodich)
                    .HasColumnName("tengiaodich")
                    .HasMaxLength(100);

                entity.Property(e => e.Tenthuongmai)
                    .HasColumnName("tenthuongmai")
                    .HasMaxLength(100);

                entity.Property(e => e.Thanhpho)
                    .HasColumnName("thanhpho")
                    .HasMaxLength(50);

                entity.Property(e => e.Thongtin).HasColumnName("thongtin");

                entity.Property(e => e.Vemaybay).HasColumnName("vemaybay");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CompanyTrace>(entity =>
            {
                entity.ToTable("company_trace");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Capnhat)
                    .IsRequired()
                    .HasColumnName("capnhat")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Chinhanh)
                    .IsRequired()
                    .HasColumnName("chinhanh")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Codecn)
                    .IsRequired()
                    .HasColumnName("codecn")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasColumnName("diachi")
                    .HasMaxLength(150);

                entity.Property(e => e.Dienthoai)
                    .HasColumnName("dienthoai")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dienthoai1)
                    .HasColumnName("dienthoai1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Httt)
                    .HasColumnName("httt")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Masothue)
                    .HasColumnName("masothue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maytinh)
                    .HasColumnName("maytinh")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Nganhnghe)
                    .HasColumnName("nganhnghe")
                    .HasMaxLength(50);

                entity.Property(e => e.Ngay)
                    .HasColumnName("ngay")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nhanvien)
                    .HasColumnName("nhanvien")
                    .HasMaxLength(50);

                entity.Property(e => e.Quocgia)
                    .IsRequired()
                    .HasColumnName("quocgia")
                    .HasMaxLength(50);

                entity.Property(e => e.Tengiaodich)
                    .IsRequired()
                    .HasColumnName("tengiaodich")
                    .HasMaxLength(100);

                entity.Property(e => e.Tenthuongmai)
                    .IsRequired()
                    .HasColumnName("tenthuongmai")
                    .HasMaxLength(100);

                entity.Property(e => e.Thanhpho)
                    .IsRequired()
                    .HasColumnName("thanhpho")
                    .HasMaxLength(50);

                entity.Property(e => e.Thongtin).HasColumnName("thongtin");

                entity.Property(e => e.Vemaybay).HasColumnName("vemaybay");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Dichvu>(entity =>
            {
                entity.HasKey(e => e.MaDv);

                entity.ToTable("DICHVU");

                entity.Property(e => e.MaDv)
                    .HasColumnName("MaDV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TenDv)
                    .HasColumnName("TenDV")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Doituong>(entity =>
            {
                entity.HasKey(e => e.MaDoituong);

                entity.ToTable("DOITUONG");

                entity.Property(e => e.MaDoituong)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TenDoituong).HasMaxLength(50);
            });

            modelBuilder.Entity<Giaodich>(entity =>
            {
                entity.ToTable("giaodich");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasColumnName("computer")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Create)
                    .HasColumnName("create")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Daily)
                    .HasColumnName("daily")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dichvuden)
                    .HasColumnName("dichvuden")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dichvutu)
                    .HasColumnName("dichvutu")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ghichu).HasColumnName("ghichu");

                entity.Property(e => e.Giamgia)
                    .HasColumnName("giamgia")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.Hoadon)
                    .HasColumnName("hoadon")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Loaidv)
                    .HasColumnName("loaidv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Loaitien)
                    .HasColumnName("loaitien")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayban)
                    .HasColumnName("ngayban")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoiban)
                    .HasColumnName("nguoiban")
                    .HasMaxLength(25);

                entity.Property(e => e.Nhaptay).HasColumnName("nhaptay");

                entity.Property(e => e.Noidung)
                    .HasColumnName("noidung")
                    .HasMaxLength(80);

                entity.Property(e => e.Sotien)
                    .HasColumnName("sotien")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Tienvnd)
                    .HasColumnName("tienvnd")
                    .HasColumnType("decimal(12, 0)");

                entity.HasOne(d => d.LoaidvNavigation)
                    .WithMany(p => p.Giaodich)
                    .HasForeignKey(d => d.Loaidv)
                    .HasConstraintName("FK_giaodich_DICHVU");
            });

            modelBuilder.Entity<Giaodich1>(entity =>
            {
                entity.ToTable("giaodich1");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasColumnName("computer")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Create)
                    .HasColumnName("create")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Daily)
                    .HasColumnName("daily")
                    .HasMaxLength(25);

                entity.Property(e => e.Dichvuden)
                    .HasColumnName("dichvuden")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dichvutu)
                    .HasColumnName("dichvutu")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ghichu).HasColumnName("ghichu");

                entity.Property(e => e.Giamgia)
                    .HasColumnName("giamgia")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.Hoadon)
                    .HasColumnName("hoadon")
                    .HasMaxLength(12);

                entity.Property(e => e.Loaidv)
                    .HasColumnName("loaidv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Loaitien)
                    .HasColumnName("loaitien")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngayban)
                    .HasColumnName("ngayban")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoiban)
                    .HasColumnName("nguoiban")
                    .HasMaxLength(25);

                entity.Property(e => e.Nhaptay).HasColumnName("nhaptay");

                entity.Property(e => e.Noidung)
                    .HasColumnName("noidung")
                    .HasMaxLength(80);

                entity.Property(e => e.Sotien)
                    .HasColumnName("sotien")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Tienvnd)
                    .HasColumnName("tienvnd")
                    .HasColumnType("decimal(12, 0)");
            });

            modelBuilder.Entity<Httt>(entity =>
            {
                entity.HasKey(e => e.Httt1);

                entity.ToTable("httt");

                entity.Property(e => e.Httt1)
                    .HasColumnName("httt")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Diengiai)
                    .HasColumnName("diengiai")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Makh);

                entity.ToTable("khachhang");

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasMaxLength(50);

                entity.Property(e => e.Dtdidong)
                    .HasColumnName("dtdidong")
                    .HasMaxLength(50);

                entity.Property(e => e.Dtnharieng)
                    .HasColumnName("dtnharieng")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duong)
                    .HasColumnName("duong")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("gioitinh")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hieuluchc)
                    .HasColumnName("hieuluchc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hochieu)
                    .HasColumnName("hochieu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycaphc)
                    .HasColumnName("ngaycaphc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycmnd)
                    .HasColumnName("ngaycmnd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nghenghiep)
                    .HasColumnName("nghenghiep")
                    .HasMaxLength(50);

                entity.Property(e => e.Phuong)
                    .HasColumnName("phuong")
                    .HasMaxLength(50);

                entity.Property(e => e.Quan)
                    .HasColumnName("quan")
                    .HasMaxLength(50);

                entity.Property(e => e.Sonha)
                    .HasColumnName("sonha")
                    .HasMaxLength(20);

                entity.Property(e => e.Tenkh)
                    .HasColumnName("tenkh")
                    .HasMaxLength(50);

                entity.Property(e => e.Thanhpho)
                    .HasColumnName("thanhpho")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Khachhang1>(entity =>
            {
                entity.HasKey(e => e.Makh);

                entity.ToTable("khachhang1");

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dtdidong)
                    .HasColumnName("dtdidong")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dtnharieng)
                    .HasColumnName("dtnharieng")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duong)
                    .HasColumnName("duong")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("gioitinh")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hieuluchc)
                    .HasColumnName("hieuluchc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hieulucthe)
                    .HasColumnName("hieulucthe")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Hochieu)
                    .HasColumnName("hochieu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kichhoat).HasColumnName("kichhoat");

                entity.Property(e => e.Lydodoithe).HasColumnName("lydodoithe");

                entity.Property(e => e.Lylichthe).HasColumnName("lylichthe");

                entity.Property(e => e.Ngaycaphc)
                    .HasColumnName("ngaycaphc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapthe)
                    .HasColumnName("ngaycapthe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaycmnd)
                    .HasColumnName("ngaycmnd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydoithe)
                    .HasColumnName("ngaydoithe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytrathe)
                    .HasColumnName("ngaytrathe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nghenghiep)
                    .HasColumnName("nghenghiep")
                    .HasMaxLength(50);

                entity.Property(e => e.Nguoicap)
                    .HasColumnName("nguoicap")
                    .HasMaxLength(50);

                entity.Property(e => e.Noicap)
                    .HasColumnName("noicap")
                    .HasMaxLength(50);

                entity.Property(e => e.Phieudk)
                    .HasColumnName("phieudk")
                    .HasMaxLength(50);

                entity.Property(e => e.Phuong)
                    .HasColumnName("phuong")
                    .HasMaxLength(20);

                entity.Property(e => e.Quan)
                    .HasColumnName("quan")
                    .HasMaxLength(20);

                entity.Property(e => e.Sodiem)
                    .HasColumnName("sodiem")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.Sonha)
                    .HasColumnName("sonha")
                    .HasMaxLength(20);

                entity.Property(e => e.Tenkh)
                    .HasColumnName("tenkh")
                    .HasMaxLength(50);

                entity.Property(e => e.Thanhpho)
                    .HasColumnName("thanhpho")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Loaichuongtrinh>(entity =>
            {
                entity.HasKey(e => e.MaCt);

                entity.ToTable("LOAICHUONGTRINH");

                entity.Property(e => e.MaCt)
                    .HasColumnName("MaCT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.TenCt)
                    .HasColumnName("TenCT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Loaithe>(entity =>
            {
                entity.HasKey(e => e.MaLoaiThe);

                entity.ToTable("LOAITHE");

                entity.Property(e => e.MaLoaiThe)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TenLoaiThe).HasMaxLength(50);
            });

            modelBuilder.Entity<LogGiaodich>(entity =>
            {
                entity.HasKey(e => e.Ids);

                entity.ToTable("log_giaodich");

                entity.Property(e => e.Ids)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Create)
                    .HasColumnName("create")
                    .HasColumnType("datetime");

                entity.Property(e => e.Daily)
                    .HasColumnName("daily")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dichvuden)
                    .HasColumnName("dichvuden")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dichvutu)
                    .HasColumnName("dichvutu")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ghichu).HasColumnName("ghichu");

                entity.Property(e => e.Giamgia)
                    .HasColumnName("giamgia")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.Hanhdong)
                    .HasColumnName("hanhdong")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hoadon)
                    .HasColumnName("hoadon")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Loaidv)
                    .HasColumnName("loaidv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Loaitien)
                    .HasColumnName("loaitien")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Maytinh)
                    .HasColumnName("maytinh")
                    .HasMaxLength(20);

                entity.Property(e => e.Ngayban)
                    .HasColumnName("ngayban")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoiban)
                    .HasColumnName("nguoiban")
                    .HasMaxLength(25);

                entity.Property(e => e.Nhaptay).HasColumnName("nhaptay");

                entity.Property(e => e.Noidung)
                    .HasColumnName("noidung")
                    .HasMaxLength(80);

                entity.Property(e => e.Sotien)
                    .HasColumnName("sotien")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Tienvnd)
                    .HasColumnName("tienvnd")
                    .HasColumnType("decimal(12, 0)");
            });

            modelBuilder.Entity<LogKhachhang>(entity =>
            {
                entity.ToTable("log_khachhang");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasMaxLength(50);

                entity.Property(e => e.Dtdidong)
                    .HasColumnName("dtdidong")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dtnharieng)
                    .HasColumnName("dtnharieng")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duong)
                    .HasColumnName("duong")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("gioitinh")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hanhdong)
                    .HasColumnName("hanhdong")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hieuluchc)
                    .HasColumnName("hieuluchc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hochieu)
                    .HasColumnName("hochieu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Maytinh).HasMaxLength(50);

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.Ngaycaphc)
                    .HasColumnName("ngaycaphc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycmnd)
                    .HasColumnName("ngaycmnd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nghenghiep)
                    .HasColumnName("nghenghiep")
                    .HasMaxLength(50);

                entity.Property(e => e.Phuong)
                    .HasColumnName("phuong")
                    .HasMaxLength(50);

                entity.Property(e => e.Quan)
                    .HasColumnName("quan")
                    .HasMaxLength(50);

                entity.Property(e => e.Sonha)
                    .HasColumnName("sonha")
                    .HasMaxLength(20);

                entity.Property(e => e.Tenkh)
                    .HasColumnName("tenkh")
                    .HasMaxLength(50);

                entity.Property(e => e.Thanhpho)
                    .HasColumnName("thanhpho")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LogThekh>(entity =>
            {
                entity.ToTable("log_thekh");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Hanhdong)
                    .HasColumnName("hanhdong")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hieulucthe)
                    .HasColumnName("hieulucthe")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Kichhoat).HasColumnName("kichhoat");

                entity.Property(e => e.Lydodoithe).HasColumnName("lydodoithe");

                entity.Property(e => e.Lylichthe).HasColumnName("lylichthe");

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Mathe)
                    .HasColumnName("mathe")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Maytinh)
                    .HasColumnName("maytinh")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaycapthe)
                    .HasColumnName("ngaycapthe")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaydoithe)
                    .HasColumnName("ngaydoithe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytrathe)
                    .HasColumnName("ngaytrathe")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(day,(10),getdate()))");

                entity.Property(e => e.Nguoicap)
                    .HasColumnName("nguoicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(30);

                entity.Property(e => e.Noicap)
                    .HasColumnName("noicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Phieudk)
                    .HasColumnName("phieudk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sodiem)
                    .HasColumnName("sodiem")
                    .HasColumnType("decimal(14, 0)");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DoiMk).HasColumnName("DoiMK");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.MaCn)
                    .HasColumnName("MaCN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaVp)
                    .HasColumnName("MaVP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau).HasMaxLength(100);

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenDn)
                    .HasColumnName("TenDN")
                    .HasMaxLength(50);

                entity.Property(e => e.TenNv)
                    .HasColumnName("TenNV")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Phongban>(entity =>
            {
                entity.HasKey(e => e.MaPhong);

                entity.ToTable("PHONGBAN");

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenPhong).HasMaxLength(50);
            });

            modelBuilder.Entity<Services2crm>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerAddress)
                    .HasColumnName("customer_address")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerCardCode)
                    .HasColumnName("customer_card_code")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerCardDate)
                    .HasColumnName("customer_card_date")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerCardType)
                    .HasColumnName("customer_card_type")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerDateOfBirth)
                    .HasColumnName("customer_date_of_birth")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerEmail)
                    .HasColumnName("customer_email")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerFirstName)
                    .HasColumnName("customer_first_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerGender)
                    .HasColumnName("Customer_gender")
                    .HasMaxLength(1);

                entity.Property(e => e.CustomerIdCard)
                    .HasColumnName("customer_id_card")
                    .HasMaxLength(16);

                entity.Property(e => e.CustomerJobTitle)
                    .HasColumnName("customer_job_title")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerLastName)
                    .HasColumnName("customer_last_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerMajor)
                    .HasColumnName("customer_major")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerPassport)
                    .HasColumnName("customer_passport")
                    .HasMaxLength(16);

                entity.Property(e => e.CustomerPhone)
                    .HasColumnName("customer_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.JsonTours).HasColumnName("json_tours");

                entity.Property(e => e.Tocrm)
                    .HasColumnName("tocrm")
                    .HasMaxLength(30);

                entity.Property(e => e.TourId)
                    .HasColumnName("tour_id")
                    .HasMaxLength(21);
            });

            modelBuilder.Entity<Thanhpho>(entity =>
            {
                entity.HasKey(e => e.MaTp);

                entity.ToTable("THANHPHO");

                entity.Property(e => e.MaTp)
                    .HasColumnName("MaTP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenTp)
                    .HasColumnName("TenTP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Thekh>(entity =>
            {
                entity.HasKey(e => e.Makh)
                    .HasName("PK_thekh_1");

                entity.ToTable("thekh");

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Hieulucthe)
                    .HasColumnName("hieulucthe")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Kichhoat).HasColumnName("kichhoat");

                entity.Property(e => e.Lydodoithe).HasColumnName("lydodoithe");

                entity.Property(e => e.Lylichthe).HasColumnName("lylichthe");

                entity.Property(e => e.Mathe)
                    .HasColumnName("mathe")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapthe)
                    .HasColumnName("ngaycapthe")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaydoithe)
                    .HasColumnName("ngaydoithe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytrathe)
                    .HasColumnName("ngaytrathe")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(day,(10),getdate()))");

                entity.Property(e => e.Nguoicap)
                    .HasColumnName("nguoicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Noicap)
                    .HasColumnName("noicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Phieudk)
                    .HasColumnName("phieudk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sodiem)
                    .HasColumnName("sodiem")
                    .HasColumnType("decimal(14, 0)");
            });

            modelBuilder.Entity<Truycapchuongtrinh>(entity =>
            {
                entity.HasKey(e => new { e.MaCt, e.MaNv });

                entity.ToTable("TRUYCAPCHUONGTRINH");

                entity.Property(e => e.MaCt)
                    .HasColumnName("MaCT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VCapthekh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCAPTHEKH");

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasMaxLength(50);

                entity.Property(e => e.Diachi).HasMaxLength(188);

                entity.Property(e => e.Dtdidong)
                    .HasColumnName("dtdidong")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hieulucthe)
                    .HasColumnName("hieulucthe")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Hochieu)
                    .HasColumnName("hochieu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kichhoat).HasColumnName("kichhoat");

                entity.Property(e => e.Makh)
                    .IsRequired()
                    .HasColumnName("makh")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapthe)
                    .HasColumnName("ngaycapthe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytrathe)
                    .HasColumnName("ngaytrathe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoicap)
                    .HasColumnName("nguoicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Noicap)
                    .HasColumnName("noicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Tenkh)
                    .HasColumnName("tenkh")
                    .HasMaxLength(50);

                entity.Property(e => e.Thanhpho)
                    .HasColumnName("thanhpho")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VCapthekhLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCAPTHEKH_log");

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasMaxLength(50);

                entity.Property(e => e.Dtdidong)
                    .HasColumnName("dtdidong")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dtnharieng)
                    .HasColumnName("dtnharieng")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duong)
                    .HasColumnName("duong")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("gioitinh")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hanhdong)
                    .HasColumnName("hanhdong")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hieuluchc)
                    .HasColumnName("hieuluchc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hieulucthe)
                    .HasColumnName("hieulucthe")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Hochieu)
                    .HasColumnName("hochieu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kichhoat).HasColumnName("kichhoat");

                entity.Property(e => e.Lydodoithe).HasColumnName("lydodoithe");

                entity.Property(e => e.Lylichthe).HasColumnName("lylichthe");

                entity.Property(e => e.Makh)
                    .HasColumnName("makh")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Maytinh)
                    .HasColumnName("maytinh")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycaphc)
                    .HasColumnName("ngaycaphc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnName("ngaycapnhat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaycapthe)
                    .HasColumnName("ngaycapthe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaycmnd)
                    .HasColumnName("ngaycmnd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydoithe)
                    .HasColumnName("ngaydoithe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytrathe)
                    .HasColumnName("ngaytrathe")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nghenghiep)
                    .HasColumnName("nghenghiep")
                    .HasMaxLength(50);

                entity.Property(e => e.Nguoicap)
                    .HasColumnName("nguoicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Nguoicapnhat)
                    .HasColumnName("nguoicapnhat")
                    .HasMaxLength(30);

                entity.Property(e => e.Noicap)
                    .HasColumnName("noicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Phieudk)
                    .HasColumnName("phieudk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phuong)
                    .HasColumnName("phuong")
                    .HasMaxLength(50);

                entity.Property(e => e.Quan)
                    .HasColumnName("quan")
                    .HasMaxLength(50);

                entity.Property(e => e.Sodiem)
                    .HasColumnName("sodiem")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.Sonha)
                    .HasColumnName("sonha")
                    .HasMaxLength(20);

                entity.Property(e => e.TenTp)
                    .HasColumnName("TenTP")
                    .HasMaxLength(50);

                entity.Property(e => e.Tenkh)
                    .HasColumnName("tenkh")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VThekhachhang>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTHEKHACHHANG");

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dtdidong)
                    .HasColumnName("dtdidong")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dtnharieng)
                    .HasColumnName("dtnharieng")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duong)
                    .HasColumnName("duong")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("gioitinh")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hieuluchc)
                    .HasColumnName("hieuluchc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hieulucthe)
                    .HasColumnName("hieulucthe")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Hochieu)
                    .HasColumnName("hochieu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kichhoat).HasColumnName("kichhoat");

                entity.Property(e => e.Lydodoithe).HasColumnName("lydodoithe");

                entity.Property(e => e.Lylichthe).HasColumnName("lylichthe");

                entity.Property(e => e.Makh)
                    .IsRequired()
                    .HasColumnName("makh")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Mathe)
                    .HasColumnName("mathe")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycaphc)
                    .HasColumnName("ngaycaphc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycapthe)
                    .HasColumnName("ngaycapthe")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaycmnd)
                    .HasColumnName("ngaycmnd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydoithe)
                    .HasColumnName("ngaydoithe")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaytrathe)
                    .HasColumnName("ngaytrathe")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nghenghiep)
                    .HasColumnName("nghenghiep")
                    .HasMaxLength(50);

                entity.Property(e => e.Nguoicap)
                    .HasColumnName("nguoicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Noicap)
                    .HasColumnName("noicap")
                    .HasMaxLength(30);

                entity.Property(e => e.Phieudk)
                    .HasColumnName("phieudk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phuong)
                    .HasColumnName("phuong")
                    .HasMaxLength(20);

                entity.Property(e => e.Quan)
                    .HasColumnName("quan")
                    .HasMaxLength(20);

                entity.Property(e => e.Sodiem)
                    .HasColumnName("sodiem")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.Sonha)
                    .HasColumnName("sonha")
                    .HasMaxLength(20);

                entity.Property(e => e.Tenkh)
                    .HasColumnName("tenkh")
                    .HasMaxLength(50);

                entity.Property(e => e.Thanhpho)
                    .HasColumnName("thanhpho")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VThongtindangnhap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTHONGTINDANGNHAP");

                entity.Property(e => e.CodeTkh)
                    .HasColumnName("CodeTKH")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DiaChiVp)
                    .HasColumnName("DiaChiVP")
                    .HasMaxLength(100);

                entity.Property(e => e.DienThoaiVp)
                    .HasColumnName("DienThoaiVP")
                    .HasMaxLength(20);

                entity.Property(e => e.DoiMk).HasColumnName("DoiMK");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FaxVp)
                    .HasColumnName("FaxVP")
                    .HasMaxLength(20);

                entity.Property(e => e.MaCn)
                    .HasColumnName("MaCN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaCt)
                    .IsRequired()
                    .HasColumnName("MaCT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasColumnName("MaNV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaTp)
                    .HasColumnName("MaTP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaVp)
                    .HasColumnName("MaVP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau).HasMaxLength(100);

                entity.Property(e => e.Mstvp)
                    .HasColumnName("MSTVP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

                entity.Property(e => e.TenCn)
                    .HasColumnName("TenCN")
                    .HasMaxLength(50);

                entity.Property(e => e.TenDn)
                    .HasColumnName("TenDN")
                    .HasMaxLength(50);

                entity.Property(e => e.TenNv)
                    .HasColumnName("TenNV")
                    .HasMaxLength(50);

                entity.Property(e => e.TenVp)
                    .HasColumnName("TenVP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vanphong>(entity =>
            {
                entity.HasKey(e => e.MaVp);

                entity.ToTable("VANPHONG");

                entity.Property(e => e.MaVp)
                    .HasColumnName("MaVP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChiVp)
                    .HasColumnName("DiaChiVP")
                    .HasMaxLength(100);

                entity.Property(e => e.DienThoaiVp)
                    .HasColumnName("DienThoaiVP")
                    .HasMaxLength(20);

                entity.Property(e => e.FaxVp)
                    .HasColumnName("FaxVP")
                    .HasMaxLength(20);

                entity.Property(e => e.MaCn)
                    .HasColumnName("MaCN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mstvp)
                    .HasColumnName("MSTVP")
                    .HasMaxLength(50)
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
