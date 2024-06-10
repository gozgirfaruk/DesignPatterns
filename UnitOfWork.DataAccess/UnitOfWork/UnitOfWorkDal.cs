using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Concrete;

namespace UnitOfWork.DataAccess.UnitOfWork
{
    public class UnitOfWorkDal : IUnitOfWorkDal
    {
        private readonly UnitContext _context;

        public UnitOfWorkDal(UnitContext context)
        {
            _context = context;
        }

        public void Save()
        {
           _context.SaveChanges();
        }

       
    }
}
