using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewManager : INewService
    {
        INewDal _newDal;

        public NewManager(INewDal newDal)
        {
            _newDal = newDal;
        }

        public void TAdd(New t)
        {
            _newDal.Insert(t);
        }

        public void TDelete(New t)
        {
            _newDal.Delete(t);
        }

        public New TGetById(int id)
        {
            return _newDal.GetById(id);
        }

        public List<New> TGetLastN(int N)
        {
            return _newDal.GetLastN(N);
        }

        public List<New> TGetList()
        {
            return _newDal.GetList();
        }

        public List<New> TGetListByFilter(Expression<Func<New, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(New t)
        {
            _newDal.Update(t);
        }
    }
}
