using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibility.DAL
{
    public class ChainContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P40Q2KE\\SQLEXPRESS;Initial Catalog =DesignChainDB;Integrated Security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
