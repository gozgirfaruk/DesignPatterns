using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.Concrete;
using UnitOfWork.DataAccess.Repositories;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.DataAccess.EntityFramework
{
    public class EfCustomerDal : IGenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(UnitContext context) : base(context)
        {
        }
    }
}
