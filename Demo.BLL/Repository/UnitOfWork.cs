using Demo.BLL.Interfaces;
using DemoDAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MVCDbContext _dbContext;

        public IDepartmentRepository DepartmentRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }

        public UnitOfWork(MVCDbContext dbContext)
        {
            _dbContext = dbContext;
            DepartmentRepository = new DepartmentRepository(_dbContext);
            EmployeeRepository = new EmployeeRepository(_dbContext);
        }

        public async Task<int> Complete() 
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}
