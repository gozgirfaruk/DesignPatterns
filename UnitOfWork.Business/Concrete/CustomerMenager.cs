using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Business.Abstract;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.UnitOfWork;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.Business.Concrete
{
    public class CustomerMenager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly UnitOfWorkDal _unitOfWorkDal;

        public CustomerMenager(ICustomerDal customerDal, UnitOfWorkDal unitOfWorkDal)
        {
            _customerDal = customerDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
            _unitOfWorkDal.Save();
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<Customer> entities)
        {
            _customerDal.MultiUpdate(entities);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
            _unitOfWorkDal.Save();
        }
    }
}
