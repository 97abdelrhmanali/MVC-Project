using System.ComponentModel.DataAnnotations;

namespace DemoMVC.ViewModels
{
	public class LogInViewModel
	{
		[Required(ErrorMessage = "Email Is Required")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Password Is Required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}
