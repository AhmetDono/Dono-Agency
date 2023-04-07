using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.Abstract.IGenericDal;
namespace DataAccessLayer.Abstract
{
    public interface  ITestimonialDal : IGenericDal<Testimonial>
    {
    }
}
