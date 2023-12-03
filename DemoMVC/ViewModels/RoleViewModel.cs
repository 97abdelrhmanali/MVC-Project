using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace DemoMVC.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Display (Name ="Role Name")]
        public string RoleName { get; set; }
    }
}
