using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.DataAccess.Concrete
{
    public class UnitContext : DbContext
    {
        public UnitContext(DbContextOptions<UnitContext>options) : base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }
    }
}
