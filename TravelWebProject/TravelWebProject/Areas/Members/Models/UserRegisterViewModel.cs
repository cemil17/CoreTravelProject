using System.ComponentModel.DataAnnotations;

namespace TravelWebProject.Areas.Members.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen adınızı girin")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen soyadınız girin")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Lütfen kullanıcı adınızı girin")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Lütfen geçerli bir mail girin")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Lütfen şifreyi girin")]
		public string Password { get; set; }
		[Compare("Password", ErrorMessage = "Şifreler aynı değil")]
		public string ConfirmPassword { get; set; }
	}
}
