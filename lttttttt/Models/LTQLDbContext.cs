namespace lttttttt.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Khachhang>Khachhangs { get; set; }
        public virtual DbSet<NhaCC>NhaCCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khachhang>()
                .Property(e => e.Sodt)
                .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
                .Property(e => e.MaKhachhang)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
              .Property(e => e.MaNCC)
              .IsUnicode(false);

        }
    }
}
