using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-0A9SGIVO\\SQLEXPRESS;database=DonoAgencyDB;integrated security=true;");
        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactWithAgent> ContactWithAgents { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Propertie> Properties { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        //appuser ve rolü çağırmaya gerek yok

    }
}
