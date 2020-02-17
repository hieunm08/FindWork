namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TimKiemViecLamDbConText : DbContext
    {
        public TimKiemViecLamDbConText()
            : base("name=TimKiemViecLam")
        {
        }

        public virtual DbSet<CongTy> CongTies { get; set; }
        public virtual DbSet<CV_UngVien> CV_UngVien { get; set; }
        public virtual DbSet<DangKy> DangKies { get; set; }
        public virtual DbSet<KinhNghiem> KinhNghiems { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<NganhNghe> NganhNghes { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThanhPho> ThanhPhoes { get; set; }
        public virtual DbSet<TinViecLam> TinViecLams { get; set; }
        public virtual DbSet<TrinhDo> TrinhDoes { get; set; }
        public virtual DbSet<UngVien> UngViens { get; set; }
        public virtual DbSet<ViTriUngTuyen> ViTriUngTuyens { get; set; }
        public virtual DbSet<VungMien> VungMiens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongTy>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<CongTy>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<CongTy>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<CongTy>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<CongTy>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<UngVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<UngVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UngVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<UngVien>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);
        }
    }
}
