using Casgem_UnitOfWord.EntityLayer.Concrete;
using Casgem_UnitOfWork.DataAccessLayer.Abstract;
using Casgem_UnitOfWork.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.DataAccessLayer.EntityFramework
{
    public class EfCustomerProcessDal:GenericRepository<CustomerProcess>,ICustomerProcessDal
    {
        public EfCustomerProcessDal(Context context) : base(context)
        {

        }
    }
}
