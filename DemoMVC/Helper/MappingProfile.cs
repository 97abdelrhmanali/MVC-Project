using AutoMapper;
using DemoDAL.Model;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace DemoMVC.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Employee,EmployeeViewModel>().ReverseMap();
            CreateMap<Department,DepartmentViewModel>().ReverseMap();
            CreateMap<RegisterViewModel, ApplicationUser>();
            CreateMap<UserViewModel,ApplicationUser>().ReverseMap();
            CreateMap<RoleViewModel, IdentityRole>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.RoleName)).ReverseMap();
        }
    }
}
