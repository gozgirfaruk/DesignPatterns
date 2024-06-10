using Repository.DataAccess.Abstract;
using Repository.DataAccess.Concrete;
using Repository.DataAccess.Repositories;
using Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(RepoContext context) : base(context)
        {
        }
    }
}
