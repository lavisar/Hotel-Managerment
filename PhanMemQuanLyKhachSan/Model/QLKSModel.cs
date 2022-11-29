namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema; // su dung EF core
    using System.Linq;

    // 
    public partial class QLKSModel : DbContext
    {
        public QLKSModel()
            : base("name=QLKSModel") // chu?i k?t n?i
        {
        }

        // Thong tin b?ng CSDL
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichLamViec> LichLamViecs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<MatKhau> MatKhaus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }

        // cai cau hinh
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TenLoai)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.NgayHD)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.QuocTich)
                .IsUnicode(false);

            modelBuilder.Entity<LichLamViec>()
                .Property(e => e.Ngay)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.TenLoai)
                .IsUnicode(false);

            modelBuilder.Entity<MatKhau>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<MatKhau>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
