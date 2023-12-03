using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Model
{
    public class Employee : BaseEntity
    {

        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; } = DateTime.Now;
        public string PhoneNumber { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string ImageName { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
