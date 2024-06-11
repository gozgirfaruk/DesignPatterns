using Microsoft.EntityFrameworkCore;

namespace Decorator.UI.DAL
{
    public class DecoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-P40Q2KE\\SQLEXPRESS; Initial Catalog=DecoratorDB; Integrated Security=true");
        }
        public DbSet<iMessage> iMessages { get; set; }
        public DbSet<Notifier> Notifiers { get; set; }
    }

     
}
