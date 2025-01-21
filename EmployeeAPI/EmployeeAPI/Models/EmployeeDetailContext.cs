using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Models
{
    public class EmployeeDetailContext : DbContext
    {
        public EmployeeDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
