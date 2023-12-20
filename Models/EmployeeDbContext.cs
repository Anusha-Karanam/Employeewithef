using System;
using System.Data.Entity;

namespace Employeewithef.Models
{
    public class EmployeeDbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options, EmployeeDbContext employeeDbContext) { }
        public DbSet<Employee> Employees { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}