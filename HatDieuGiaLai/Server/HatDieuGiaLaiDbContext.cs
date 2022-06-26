using Microsoft.EntityFrameworkCore;
using HatDieuGiaLai.Shared;

namespace HatDieuGiaLai.Server
{
    public class HatDieuGiaLaiDbContext : DbContext
    {
        public HatDieuGiaLaiDbContext(DbContextOptions<HatDieuGiaLaiDbContext> options)
          : base(options) { }

        public DbSet<Dieu> Dieus { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var dieuEntity = modelBuilder.Entity<Dieu>();
            dieuEntity.HasKey(dieu => dieu.Id);
            dieuEntity.Property(dieu => dieu.Name)
            .HasMaxLength(80);
            dieuEntity.Property(dieu => dieu.Price)
            .HasColumnType("money");
            dieuEntity.Property(dieu => dieu.Loaisanpham)
            .HasConversion<string>();

            var ordersEntity = modelBuilder.Entity<Order>();
            ordersEntity.HasKey(order => order.Id);
            ordersEntity.HasOne(order => order.Customer);
            ordersEntity.HasMany(order => order.Dieus)
            .WithMany(dieu => dieu.Orders);

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.Id);
            customerEntity.Property(customer => customer.Name)
            .HasMaxLength(100);
            customerEntity.Property(customer => customer.Street)
            .HasMaxLength(50);
            customerEntity.Property(customer => customer.City)
            .HasMaxLength(50);
        }
    }
}
