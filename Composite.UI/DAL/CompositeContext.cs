

using Microsoft.EntityFrameworkCore;

namespace Composite.UI.DAL
{
    public class CompositeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =DESKTOP-P40Q2KE\\SQLEXPRESS; Initial Catalog=CompositeDB; Integrated Security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
