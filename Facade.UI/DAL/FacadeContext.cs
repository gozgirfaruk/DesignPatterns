using Microsoft.EntityFrameworkCore;

namespace Facade.UI.DAL
{
    public class FacadeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-P40Q2KE\\SQLEXPRESS; Initial Catalog=FacadeDB; Integrated Security=true");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
