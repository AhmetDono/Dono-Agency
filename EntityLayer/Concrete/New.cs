using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class New
    {
        [Key]
        public int NewsID { get; set; }
        public string NewsTitle { get; set; }
        public string NewsSubject { get; set; }
        public DateTime Datetime { get; set; }
        public string NewsPhoto { get; set; }
        public string Author { get; set; }
        public string NewsText { get; set; }
    }
}
