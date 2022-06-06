using Microsoft.EntityFrameworkCore;

namespace EmpolyeePOC.WebAp.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        //dbset

        public DbSet<Employee> Employee { get; set; }
    }
}
