using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        //asagıdaki metot da connectıon strıngı tanımlayacagız. need to have optıonsBuılder to do that
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BAHU;database=CoreBlogDb; integrated security=true;TrustServerCertificate=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
