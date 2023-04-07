using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        //public int UserID { get; set; } isim id ve photo user ile bağlantılı olacak
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
        public string Photo { get; set; }
        public DateTime Datetime { get; set; }
    }
}
