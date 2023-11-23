using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class QLSACHContext : DbContext {
        public QLSACHContext() {
        }

        public QLSACHContext(DbContextOptions<QLSACHContext> options)
            : base(options) {
        }

        public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; }
        public virtual DbSet<LoaiSach> LoaiSach { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuon { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=QLSACH;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ChiTietPhieuMuon>(entity => {
                entity.HasKey(e => new { e.MaPm, e.MaSach });

                entity.Property(e => e.MaPm)
                    .HasColumnName("MaPM")
                    .HasMaxLength(10);

                entity.Property(e => e.MaSach).HasMaxLength(10);

                entity.HasOne(d => d.MaPmNavigation)
                    .WithMany(p => p.ChiTietPhieuMuon)
                    .HasForeignKey(d => d.MaPm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietPhieuMuon_PhieuMuon");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.ChiTietPhieuMuon)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietPhieuMuon_Sach");
            });

            modelBuilder.Entity<LoaiSach>(entity => {
                entity.HasKey(e => e.MaLoai);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.TenLoai).HasMaxLength(50);
            });

            modelBuilder.Entity<PhieuMuon>(entity => {
                entity.HasKey(e => e.MaPm);

                entity.Property(e => e.MaPm)
                    .HasColumnName("MaPM")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.NgayMuon).HasColumnType("datetime");

                entity.Property(e => e.NgayTra).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sach>(entity => {
                entity.HasKey(e => e.MaSach);

                entity.Property(e => e.MaSach)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaLoai).HasMaxLength(10);

                entity.Property(e => e.NgayXb)
                    .HasColumnName("NgayXB")
                    .HasColumnType("datetime");

                entity.Property(e => e.TenSach).HasMaxLength(50);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.Sach)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_Sach_LoaiSach");
            });
        }
    }
}
