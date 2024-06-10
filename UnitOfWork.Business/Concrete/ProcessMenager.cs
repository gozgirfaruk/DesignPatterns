using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Business.Abstract;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.Business.Concrete
{
    public class ProcessMenager : IProcessService
    {
        private readonly IProcessDal _processDal;

        public ProcessMenager(IProcessDal processDal)
        {
            _processDal = processDal;
        }

        public void TDelete(Process entity)
        {
            throw new NotImplementedException();
        }

        public List<Process> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Process TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Process entity)
        {
            throw new NotImplementedException();
        }

        public void TMultiUpdate(List<Process> entities)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Process entity)
        {
            throw new NotImplementedException();
        }
    }
}
