using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employeewithef.Models
{
    public class EmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public object GetEmployee(object empid)
        {
            throw new NotImplementedException();
        }
    }
}