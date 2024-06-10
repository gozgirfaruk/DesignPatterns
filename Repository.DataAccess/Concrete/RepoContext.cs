using Microsoft.EntityFrameworkCore;
using Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess.Concrete
{
    public class RepoContext : DbContext
    {
        public RepoContext(DbContextOptions<RepoContext> options) : base(options) { }

        public DbSet<Category> Categories {get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
