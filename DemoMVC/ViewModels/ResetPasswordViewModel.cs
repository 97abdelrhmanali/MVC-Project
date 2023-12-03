using System.ComponentModel.DataAnnotations;

namespace DemoMVC.ViewModels
{
	public class ResetPasswordViewModel
	{
		[Required(ErrorMessage = "Password Is Required")]
		[DataType(DataType.Password)]
		public string NewPassword { get; set; }
		[Required(ErrorMessage = "Confirm Password Is Required")]
		[Compare(nameof(NewPassword), ErrorMessage = "Confirm Password is not matched")]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set; }
	}
}
