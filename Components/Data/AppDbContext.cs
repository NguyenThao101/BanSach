using Microsoft.EntityFrameworkCore;
using Webbanhang.Components.Data.Model;

namespace Webbanhang.Components.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       
        public DbSet<Item> Items { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<SaleHistory> SaleHistories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasKey(u => u.ItemId);
            modelBuilder.Entity<Item>()
                    .Property(o => o.ItemId)
                    .ValueGeneratedOnAdd();
            modelBuilder.Entity<OrderDetail>()
                .HasKey(o => o.OrderId);
            modelBuilder.Entity<OrderDetail>()
                    .Property(o => o.OrderId)
                    .ValueGeneratedOnAdd();
            modelBuilder.Entity<Account>()
                .HasKey(o => o.AccountId);
            modelBuilder.Entity<Account>()
                    .Property(o => o.AccountId)
                    .ValueGeneratedOnAdd();
            modelBuilder.Entity<SaleHistory>()
                .HasKey(o => o.HistoryId);
            modelBuilder.Entity<SaleHistory>()
                    .Property(o => o.HistoryId)
                    .ValueGeneratedOnAdd();
            modelBuilder.Entity<SaleHistory>()
                .Property(o => o.HistoryId)
                .ValueGeneratedOnAdd();

        }
    }
}

