using Demo.BLL.Interfaces;
using DemoDAL.Data;
using DemoDAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        

        public EmployeeRepository(MVCDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Employee> GetEmployeeByName(string Name)
        {
            return _DbContext.Employees.Where(e => e.Name.Trim()
                                                         .ToLower().Contains(Name.Trim().ToLower()));
        }

        public IQueryable<Employee> Search(string name)
        {
            return _DbContext.Employees.Include(E => E.Department)
                                       .Where(e => e.Name.Trim()
                                                         .ToLower()
                                                         .Contains(name.Trim().ToLower()));
        }
    }
}
