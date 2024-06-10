using Microsoft.EntityFrameworkCore;

namespace Mediator.UI.DAL
{
    public class MediatContextClass : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-P40Q2KE\\SQLEXPRESS; Initial Catalog=MediatDb; Integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }

    }
}
