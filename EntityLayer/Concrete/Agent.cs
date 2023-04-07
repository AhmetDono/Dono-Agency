using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Agent
    {
        [Key]
        public int AgentID { get; set; }
        //public int AgentBandID { get; set; }
        //relaitonship with propertie
        //relationship
        public List<Propertie> Properties { get; set; }
        public string AgentName { get; set; }
        public int AgentPhone { get; set; }
        public string AgentEmail { get; set; }
        public string AgentPhoto { get; set; }
        //sonradan social media classı ile ilişkili olacak
        public string AgentSocialMedia { get; set; }
        public string AgentDescription { get; set; }
    }
}

