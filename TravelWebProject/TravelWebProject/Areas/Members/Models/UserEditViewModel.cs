namespace TravelWebProject.Areas.Members.Models
{
	public class UserEditViewModel
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string? UserName { get; set; }
		public string Password { get; set; }
		public string Confirmpassword { get; set; }
		public string? ImageURL { get; set; }
		public string? Phonenumber { get; set; }
		public string? Mail { get; set; }
	}
}
