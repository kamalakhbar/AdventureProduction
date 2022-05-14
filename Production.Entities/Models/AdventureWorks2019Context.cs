using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Production.Entities.Models
{
    public partial class AdventureWorks2019Context : DbContext
    {
        public AdventureWorks2019Context()
        {
        }

        public AdventureWorks2019Context(DbContextOptions<AdventureWorks2019Context> options)
            : base(options)
        {
        }

        public virtual DbSet<vAddProduct> vAddProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-0GRTEHQ\\SQLEXPRESS;Initial Catalog=AdventureWorks2019;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<vAddProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAddProduct");

                entity.Property(e => e.Class)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.Color).HasMaxLength(15);

                entity.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.Model_Name)
                    .HasMaxLength(50)
                    .HasColumnName("Model Name");

                entity.Property(e => e.Nama_Produk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nama Produk");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProductLine)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.SellEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellStartDate).HasColumnType("datetime");

                entity.Property(e => e.Size).HasMaxLength(5);

                entity.Property(e => e.StandardCost).HasColumnType("money");

                entity.Property(e => e.Style)
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.SubName).HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WeightUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
