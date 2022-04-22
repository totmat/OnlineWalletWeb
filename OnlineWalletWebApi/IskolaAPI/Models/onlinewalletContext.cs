using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace IskolaAPI.Models
{
    public partial class onlinewalletContext : DbContext
    {
        public onlinewalletContext()
        {
        }

        public onlinewalletContext(DbContextOptions<onlinewalletContext> options)
            : base(options)
        {
        }

        public virtual DbSet<bankkartya> bankkartya { get; set; }
        public virtual DbSet<felhasznalo> felhasznalo { get; set; }
        public virtual DbSet<igazolvany> igazolvany { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user id=root;database=onlinewallet", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.6-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            modelBuilder.Entity<bankkartya>(entity =>
            {
                entity.UseCollation("utf8mb4_hungarian_ci");
            });

            modelBuilder.Entity<felhasznalo>(entity =>
            {
                entity.UseCollation("utf8mb4_hungarian_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
