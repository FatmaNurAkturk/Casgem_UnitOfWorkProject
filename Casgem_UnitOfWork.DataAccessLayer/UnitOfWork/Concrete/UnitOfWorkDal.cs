using Casgem_UnitOfWord.EntityLayer.Concrete;
using Casgem_UnitOfWork.DataAccessLayer.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.DataAccessLayer.UnitOfWork.Concrete
{
    public class UnitOfWorkDal : IUnitOfWorkDal
    {
        private readonly Context _context;

        public UnitOfWorkDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
