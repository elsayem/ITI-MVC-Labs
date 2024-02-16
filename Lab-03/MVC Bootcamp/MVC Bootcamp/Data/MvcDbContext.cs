using Microsoft.EntityFrameworkCore;
using MVC_Bootcamp.Models;

namespace MVC_Bootcamp.Data
{
    public class MvcDbContext : DbContext
    {
        public DbSet<Student> Students {  get; set; }
        public DbSet<Department> Departments {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MVC_Bootcamp_DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MVC_DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            base.OnConfiguring(optionsBuilder);
            }
      
    }
}
