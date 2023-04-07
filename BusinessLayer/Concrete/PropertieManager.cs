using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PropertieManager : IPropertieService
    {
        IPropertieDal _propertieDal;

        public PropertieManager(IPropertieDal propertieDal)
        {
            _propertieDal = propertieDal;
        }

        public void TAdd(Propertie t)
        {
            _propertieDal.Insert(t);
        }

        public void TDelete(Propertie t)
        {
            _propertieDal.Delete(t);
        }

        public Propertie TGetById(int id)
        {
            return _propertieDal.GetById(id);
        }

        public List<Propertie> TGetLastN(int N)
        {
            return _propertieDal.GetLastN(N);
        }

        public List<Propertie> TGetList()
        {
            return _propertieDal.GetList();
        }

        public List<Propertie> TGetListByFilter(Expression<Func<Propertie, bool>> filter)
        {
            return _propertieDal.GetListByFilter(filter);
        }

        public void TUpdate(Propertie t)
        {
            _propertieDal.Update(t);
        }
    }
}
