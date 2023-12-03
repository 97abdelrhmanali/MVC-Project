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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private protected readonly MVCDbContext _DbContext;

        public GenericRepository(MVCDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public void Add(T entity)
        {
            _DbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _DbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _DbContext.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            if (typeof(T) == typeof(Employee))
                return (IEnumerable<T>) await _DbContext.Employees
                    .Include(E => E.Department)
                    .AsNoTracking().ToListAsync();
            return await _DbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
                =>await _DbContext.Set<T>().FindAsync(id);
    }
}
