using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.Concrete;

namespace UnitOfWork.DataAccess.Repositories
{
    public class IGenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly UnitContext _context;

        public IGenericRepository(UnitContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();  
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);

        }

        public void MultiUpdate(List<T> entities)
        {
            _context.UpdateRange(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
