using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Propertie
    {
        [Key]
        public int PropertieID { get; set; }

        //relationship
        //[ForeignKey("Agent")]
        public int AgentID { get; set; }
        public Agent Agent { get; set; }
        public string PropertieName { get; set; }
        public int PropertiePrice { get; set; }
        public string PropertieIntroPhoto { get; set; }
        public string PropertieMainPhoto { get; set; }
        public string PropertieGridPhoto1 { get; set; }
        public string PropertieGridPhoto2 { get; set; }
        public string PropertieFloorPlans { get; set; }
        public string PropertieVideo { get; set; }
        public string Ubication { get; set; }
        public string PropertieLocation { get; set; }
        public string PropertieType { get; set; }
        public int Area { get; set; }
        public int Bed { get; set; }
        public int Bath { get; set; }
        public int Garage { get; set; }
        public bool Balcony { get; set; }
        public bool Deck { get; set; }
        public bool Parking { get; set; }
        public bool SportCourts { get; set; }
        public bool SunRoom { get; set; }
        public bool OutdoorKitchen { get; set; }
        public bool CableTV { get; set; }
        public bool Internet { get; set; }
        public bool ConcreteFlooring { get; set; }
        public string PropertyDescription { get; set; }
        public string Status { get; set; }
    }
}
