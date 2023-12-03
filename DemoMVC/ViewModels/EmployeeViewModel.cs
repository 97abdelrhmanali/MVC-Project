using DemoDAL.Model;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using Microsoft.AspNetCore.Http;

namespace DemoMVC.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required !!! :(")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Range(20, 30)]
        public int? Age { get; set; }
        [RegularExpression(@"^[1-9]{1,3}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$"
        , ErrorMessage = "Address must be like 123-street-city-country")]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; } = DateTime.Now;
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public IFormFile Image { get; set; }
        public string ImageName { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
