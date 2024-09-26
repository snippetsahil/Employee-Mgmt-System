using Microsoft.EntityFrameworkCore;
using MyNameSahil.Models.Domain;

namespace MyNameSahil.Data
{
    public class MVCDemoDbcontext : DbContext
    {
        public MVCDemoDbcontext(DbContextOptions options) : base(options) 
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
