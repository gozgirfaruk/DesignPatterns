using Microsoft.EntityFrameworkCore;

namespace CQRSDesign.DAL
{
    public class CqrsContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-P40Q2KE\\SQLEXPRESS; Initial Catalog=DesignCqrsDb; Integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
