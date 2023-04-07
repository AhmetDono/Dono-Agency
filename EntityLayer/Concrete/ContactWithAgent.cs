using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactWithAgent
    {
        //agent ile bağlantılı olacak
        //public int AgentID { get; set; }
        [Key]
        public int ContactWithAgentID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
    }
}
