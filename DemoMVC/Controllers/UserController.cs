using AutoMapper;
using DemoDAL.Model;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public UserController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                var users = await _userManager.Users.Select(U => new UserViewModel()
                {
                    Id = U.Id,
                    Email = U.Email,
                    UserName = U.UserName,
                    PhoneNumber = U.PhoneNumber,
                    Roles = _userManager.GetRolesAsync(U).Result
                }).ToListAsync();
                return View(users);
            }
            else
            {
                var users = await _userManager.FindByEmailAsync(email);
                if(users is not null) 
                {
                    var mappeduser = _mapper.Map<ApplicationUser, UserViewModel>(users);
                    return View(new List<UserViewModel>() { mappeduser });
                }
                return View(Enumerable.Empty<UserViewModel>());
            }
        }



        public async Task<IActionResult> Details(string id ,string ViewName = "Details")
        {
            if (id == null)
                return BadRequest();
            var user = await _userManager.FindByIdAsync(id);
            if (user is null)
                return NotFound();
            var mappedUser = _mapper.Map<ApplicationUser,UserViewModel>(user);

            return View(ViewName , mappedUser);
        }

        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute]string id ,UserViewModel UpdatedUser)
        {
            if (id != UpdatedUser.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {

                    var user = await _userManager.FindByIdAsync(id);
                    user.Id = UpdatedUser.Id;
                    user.Email = UpdatedUser.Email;
                    user.PhoneNumber = UpdatedUser.PhoneNumber;
                    user.UserName = UpdatedUser.UserName;
                    user.SecurityStamp = Guid.NewGuid().ToString();
                    await _userManager.UpdateAsync(user);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty,ex.Message);
                }
            }
            return View(UpdatedUser);
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
                var user = await _userManager.FindByIdAsync(id);
                await _userManager.DeleteAsync(user);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                ModelState.AddModelError(string.Empty, ex.Message);
                return RedirectToAction(nameof(HomeController.Error), "Home");
            }
            
        }

    }
}
