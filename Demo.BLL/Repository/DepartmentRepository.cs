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
    public class DepartmentRepository : GenericRepository<Department> ,IDepartmentRepository
    {
        public DepartmentRepository(MVCDbContext dbContext):base(dbContext)
        {
        }
        #region Repository Old Code
        //public int Add(Department department)
        //{
        //    _DbContext.Departments.Add(department);
        //    return _DbContext.SaveChanges();
        //}

        //public int Update(Department department)
        //{
        //    _DbContext.Departments.Update(department);
        //    return _DbContext.SaveChanges();
        //}

        //public int Delete(Department department)
        //{
        //    _DbContext.Departments.Remove(department);
        //    return _DbContext.SaveChanges();
        //}

        //public IEnumerable<Department> GetAll()
        //{
        //    return _DbContext.Departments.AsNoTracking().ToList();
        //}

        //public Department GetById(int id)
        //{
        //    return _DbContext.Departments.Find(id);
        //} 
        #endregion

    }
}
