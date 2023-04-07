﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialPhoto { get; set; }
        public string TestimonialMiniPhoto { get; set; }
        public string TestimonialText { get; set; }
    }
}
