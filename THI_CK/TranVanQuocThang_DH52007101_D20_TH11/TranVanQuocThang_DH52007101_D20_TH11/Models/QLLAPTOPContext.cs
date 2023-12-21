using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class QLLAPTOPContext : DbContext {
        public QLLAPTOPContext() {
        }

        public QLLAPTOPContext(DbContextOptions<QLLAPTOPContext> options)
            : base(options) {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<Laptop> Laptop { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=QLLAPTOP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ChiTietHoaDon>(entity => {
                entity.HasKey(e => new { e.MaHd, e.MaLaptop });

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(10);

                entity.Property(e => e.MaLaptop).HasMaxLength(10);

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietHoaDon)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietHoaDon_HoaDon");

                entity.HasOne(d => d.MaLaptopNavigation)
                    .WithMany(p => p.ChiTietHoaDon)
                    .HasForeignKey(d => d.MaLaptop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietHoaDon_Laptop");
            });

            modelBuilder.Entity<HoaDon>(entity => {
                entity.HasKey(e => e.MaHd);

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.NgayHd)
                    .HasColumnName("NgayHD")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Laptop>(entity => {
                entity.HasKey(e => e.MaLaptop);

                entity.Property(e => e.MaLaptop)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaNsx)
                    .HasColumnName("MaNSX")
                    .HasMaxLength(10);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.NgaySx)
                    .HasColumnName("NgaySX")
                    .HasColumnType("datetime");

                entity.Property(e => e.TenLaptop).HasMaxLength(50);

                entity.HasOne(d => d.MaNsxNavigation)
                    .WithMany(p => p.Laptop)
                    .HasForeignKey(d => d.MaNsx)
                    .HasConstraintName("FK_Laptop_NhaSanXuat");
            });

            modelBuilder.Entity<NhaSanXuat>(entity => {
                entity.HasKey(e => e.MaNsx);

                entity.Property(e => e.MaNsx)
                    .HasColumnName("MaNSX")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.SoDt)
                    .HasColumnName("SoDT")
                    .HasMaxLength(12);

                entity.Property(e => e.TenNsx)
                    .HasColumnName("TenNSX")
                    .HasMaxLength(50);
            });
        }
    }
}
