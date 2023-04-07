using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonoAgency
{
    public class ViewModel
    {
        public List<Propertie> PropertieList { get; set; }
        public List<Agent> AgentList { get; set; }
        public Propertie properties  { get; set; }
        public Agent agents  { get; set; }
    }
}
