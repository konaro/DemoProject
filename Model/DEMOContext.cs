using Microsoft.EntityFrameworkCore;

namespace Model
{
    public partial class DEMOContext : DbContext
    {
        public virtual DbSet<Product> Product { get; set; }

        public DEMOContext(DbContextOptions<DEMOContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "prod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brief)
                    .HasColumnName("brief")
                    .HasMaxLength(100);

                entity.Property(e => e.InStock).HasColumnName("in_stock");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(7, 2)");
            });
        }
    }
}