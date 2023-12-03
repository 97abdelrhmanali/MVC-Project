using AutoMapper;
using DemoDAL.Model;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager,
            IMapper mapper,
            UserManager<ApplicationUser> userManager) 
        {
            _roleManager = roleManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string name)
        {
            if(name == null)
            {
                var role =await _roleManager.Roles.Select(R => new RoleViewModel()
                {
                    Id = R.Id,
                    RoleName = R.Name
                }).ToListAsync();
                return View(role);

            }
            else
            {
                var role = await _roleManager.FindByNameAsync(name);
                if (role != null)
                {
                    var MappedRole = _mapper.Map<IdentityRole, RoleViewModel>(role);
                    return View(new List<RoleViewModel>() { MappedRole });
                }
                return View(Enumerable.Empty<RoleViewModel>());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                var MappedRole = _mapper.Map<RoleViewModel, IdentityRole>(model);
                await _roleManager.CreateAsync(MappedRole);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Details(string id , string ViewName = "Details")
        {
            if (id is null)
                return BadRequest();
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();
            var mappedRole = _mapper.Map<IdentityRole, RoleViewModel>(role);
            return View(ViewName, mappedRole);
        }

        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id , RoleViewModel model)
        {
            if (id != model.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var role = await _roleManager.FindByIdAsync(id);
                    role.Id = model.Id;
                    role.Name = model.RoleName;
                    await _roleManager.UpdateAsync(role);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {

                    ModelState.AddModelError(string.Empty, e.Message);
                }
            }
            return View(model);
        }
        
        public async Task<IActionResult> Delete(string id)
        {
            return await Details(id, "Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(string id)
        {
            try
            {
                var role = await _roleManager.FindByIdAsync(id);
                await _roleManager.DeleteAsync(role);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                ModelState.AddModelError(string.Empty, e.Message);
                return RedirectToAction(nameof(HomeController.Error), "Home");
            }            
        }


        public async Task<IActionResult> AddOrRemoveUser(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            ViewBag.RoleId = id;
            if (role is null)
                return BadRequest();

            var UserInRole = await _userManager.Users.Select(U => new UserInRoleViewModel()
            {
                UserId = U.Id,
                UserName = U.UserName,
                IsSelected = _userManager.IsInRoleAsync(U, role.Name).Result
            }).ToListAsync();

            return View(UserInRole);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrRemoveUser(List<UserInRoleViewModel> users , string id )
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role is null)
                return BadRequest();
            if (ModelState.IsValid)
            {
                foreach (var user in users)
                {
                    var appUser = await _userManager.FindByIdAsync(user.UserId);
                    var checkTheUserInRole = await _userManager.IsInRoleAsync(appUser, role.Name);
                    if (appUser is not null)
                    {
                        if (user.IsSelected && !(checkTheUserInRole))
                            await _userManager.AddToRoleAsync(appUser, role.Name);
                        else if(!user.IsSelected && checkTheUserInRole)
                            await _userManager.RemoveFromRoleAsync(appUser, role.Name);
                    }
                }
                return RedirectToAction(nameof(Edit),new { id = id });
            }
            return View(users);
        }


    }
}
