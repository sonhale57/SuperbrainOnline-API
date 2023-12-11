using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SuperbrainOnline_API.Models
{
    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
            : base("name=ModelDbContext")
        {
        }

        public virtual DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public virtual DbSet<Dangky> Dangkies { get; set; }
        public virtual DbSet<Hocsinh> Hocsinhs { get; set; }
        public virtual DbSet<Khoahoc> Khoahocs { get; set; }
        public virtual DbSet<Lophoc> Lophocs { get; set; }
        public virtual DbSet<Lophoc_join> Lophoc_join { get; set; }
        public virtual DbSet<UserAvatar> UserAvatars { get; set; }
        public virtual DbSet<UserMood> UserMoods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.thongtin_block1)
                .IsFixedLength();

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.caidat_block)
                .IsFixedLength();

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.soluonglop)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.testdauvao)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.chiphi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.dienthoaiThiTQ)
                .IsUnicode(false);

            modelBuilder.Entity<Dangky>()
                .Property(e => e.MADK)
                .IsUnicode(false);

            modelBuilder.Entity<Dangky>()
                .Property(e => e.Hocphi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Dangky>()
                .Property(e => e.Phitailieu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Dangky>()
                .Property(e => e.Tonghocphi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Khoahoc>()
                .Property(e => e.HP_full)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Khoahoc>()
                .Property(e => e.thoiluong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Khoahoc>()
                .Property(e => e.diemquakhoa)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Lophoc>()
                .Property(e => e.buoihoc)
                .HasPrecision(18, 1);
        }
    }
}
