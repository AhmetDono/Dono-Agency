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
    public class ContactWithAgentManager : IContactWithAgentService
    {
        IContactWithAgentDal _contactWithAgentDal;

        public ContactWithAgentManager(IContactWithAgentDal contactWithAgentDal)
        {
            _contactWithAgentDal = contactWithAgentDal;
        }

        public void TAdd(ContactWithAgent t)
        {
            _contactWithAgentDal.Insert(t);
        }

        public void TDelete(ContactWithAgent t)
        {
            _contactWithAgentDal.Delete(t);
        }

        public ContactWithAgent TGetById(int id)
        {
            return _contactWithAgentDal.GetById(id);
        }

        public List<ContactWithAgent> TGetLastN(int N)
        {
            return _contactWithAgentDal.GetLastN(N);
        }

        public List<ContactWithAgent> TGetList()
        {
            return _contactWithAgentDal.GetList();
        }


        public List<ContactWithAgent> TGetListByFilter(Expression<Func<ContactWithAgent, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactWithAgent t)
        {
            _contactWithAgentDal.Update(t);
        }
    }
}
