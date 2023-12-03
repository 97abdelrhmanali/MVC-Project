using System.ComponentModel.DataAnnotations;

namespace DemoMVC.ViewModels
{
	public class ForgetPasswordViewModel
	{
		[EmailAddress(ErrorMessage = "Invalid Mail")]
		[Required(ErrorMessage = "Email Is Required")]
		public string Email { get; set; }
	}
}
