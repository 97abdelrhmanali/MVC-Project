using AutoMapper;
using DemoDAL.Model;
using DemoMVC.Helper;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
    public class AccountController : Controller
    {
		#region Constructor And Fields

		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly IMapper _mapper;

		public AccountController(
			UserManager<ApplicationUser> userManager,
			SignInManager<ApplicationUser> signInManager,
			IMapper mapper)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_mapper = mapper;
		} 

		#endregion

		#region SignUp
		public IActionResult Register()
		{
			return View();
		}
		//https://localhost:44320/Account/Register
		//P@ssw0rd
		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByNameAsync(model.UserName);
				if(user is null)
				{
					var Register = _mapper.Map<RegisterViewModel, ApplicationUser>(model);
					var result = await _userManager.CreateAsync(Register, model.Password);
					if (result.Succeeded)
						return RedirectToAction(nameof(LogIn));
					foreach (var Errors in result.Errors)
						ModelState.AddModelError(string.Empty, Errors.Description);
				}
				ModelState.AddModelError(string.Empty, "User Is Already Exists");

			}
			return View(model);
		}
		#endregion

		#region SignIn
		public IActionResult LogIn()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> LogIn(LogInViewModel logIn)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(logIn.Email);
				if (user is not null)
				{
					var flag = await _userManager.CheckPasswordAsync(user, logIn.Password);
					if (flag)
					{
						var result = await _signInManager.PasswordSignInAsync(user, logIn.Password, logIn.RememberMe, false);
						if (result.Succeeded)
							return RedirectToAction(nameof(HomeController.Index), "Home");

					}
				}
				ModelState.AddModelError(string.Empty, "Invalid LogIn");
			}
			return View(logIn);
		}
		#endregion

		#region SignOut
		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction(nameof(LogIn));
		}

		#endregion

		#region ForgetPassword

		public IActionResult ForgetPassword()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SendResetPasswordUrl(ForgetPasswordViewModel model)
		{
			if(ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(model.Email);
				if(user is not null)
				{
					var token =  _userManager.GeneratePasswordResetTokenAsync(user);
					var ResetPasswordURL =
						Url.Action("ResetPassword", "Account", new { email = model.Email, token = token });
					var email = new Email()
					{
						Subject = "Reset Your Password",
						Recipients = model.Email,
						Body = ResetPasswordURL
					};
					EmailSettings.SendEmail(email);
					RedirectToAction(nameof(CheckYourInbox));
				}
				ModelState.AddModelError(string.Empty, "Invalid Email");
			}
			return View(model);
		}

		public IActionResult CheckYourInbox()
		{
			return View();
		}

		#endregion

		#region ResetPassword

		public IActionResult ResetPassword(string email , string token)
		{
			TempData["email"] = email;
			TempData["token"] = token;
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
		{
			if (ModelState.IsValid)
			{
				string email = TempData["email"] as string;
				string token = TempData["token"] as string;
				var user = await _userManager.FindByNameAsync(email);
				var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);
				if (result.Succeeded)
					return RedirectToAction(nameof(LogIn));
				foreach (var error in result.Errors)
					ModelState.AddModelError(string.Empty,error.Description);
			}
			return View(model);
		}
		#endregion
	}
}
