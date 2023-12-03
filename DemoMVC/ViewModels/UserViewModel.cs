using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
