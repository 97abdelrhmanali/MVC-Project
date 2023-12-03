using System.ComponentModel.DataAnnotations;

namespace DemoMVC.ViewModels
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage ="User Name Is Required")]
		public string UserName { get; set; }
		[EmailAddress(ErrorMessage ="Invalid Mail")]
		[Required(ErrorMessage ="Email Is Required")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Password Is Required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage ="Confirm Password Is Required")]
		[Compare(nameof(Password) , ErrorMessage ="Confirm Password is not matched")]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set; }
		[Required]
		public bool IsAgree { get; set; }
	}
}
