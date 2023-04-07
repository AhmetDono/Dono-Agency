using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AgentManager : IAgentService
    {
        IAgentDal _agentDal;

        public AgentManager(IAgentDal agentDal)
        {
            _agentDal = agentDal;
        }

        public void TAdd(Agent t)
        {
            _agentDal.Insert(t);
        }

        public void TDelete(Agent t)
        {
            _agentDal.Delete(t);
        }

        public Agent TGetById(int id)
        {
            return _agentDal.GetById(id);
        }

        public List<Agent> TGetLastN(int N)
        {
            return _agentDal.GetLastN(N);
        }

        public List<Agent> TGetList()
        {
            return _agentDal.GetList();
        }

        public List<Agent> TGetListByFilter(Expression<Func<Agent, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Agent t)
        {
            _agentDal.Update(t);
        }
    }
}
