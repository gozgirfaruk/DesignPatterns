
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.Concrete;
using UnitOfWork.DataAccess.Repositories;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.DataAccess.EntityFramework
{
    public class EfProcessDal : IGenericRepository<Process>, IProcessDal
    {
        public EfProcessDal(UnitContext context) : base(context)
        {
        }
    }
}
