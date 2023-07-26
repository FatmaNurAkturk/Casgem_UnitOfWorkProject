using Casgem_UnitOfWord.EntityLayer.Concrete;
using Casgem_UnitOfWork.BusinessLayer.Abstract;
using Casgem_UnitOfWork.DataAccessLayer.Abstract;
using Casgem_UnitOfWork.DataAccessLayer.EntityFramework;
using Casgem_UnitOfWork.DataAccessLayer.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.BusinessLayer.Concrete
{
    public class CustomerProcessManager:ICustomerProcessService
    {
        private readonly ICustomerProcessDal _customerProcessDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public CustomerProcessManager(ICustomerProcessDal customerProcessDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _customerProcessDal = customerProcessDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(CustomerProcess t)
        {
            _customerProcessDal.Delete(t);
            _unitOfWorkDal.Save();
        }

        public CustomerProcess TGetById(int id)
        {
            return _customerProcessDal.GetById(id);
        }

        public List<CustomerProcess> TGetList()
        {
            return _customerProcessDal.GetList();
        }

        public void TInsert(CustomerProcess t)
        {
            _customerProcessDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<CustomerProcess> t)
        {
            _customerProcessDal.MultiUpdate(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(CustomerProcess t)
        {
            _customerProcessDal.Update(t);
            _unitOfWorkDal.Save();
        }
    }
}
