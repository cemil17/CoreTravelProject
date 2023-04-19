using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelWebProject.Areas.Members.Models;

namespace TravelWebProject.Areas.Members.Controllers
{
	[AllowAnonymous]
	[Area("Members")]
	[Route("Members/[controller]/[action]")]

	public class ProfileController : Controller
	{
		private readonly UserManager<APPUser> _userManager;

		public ProfileController(UserManager<APPUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel viewModel = new UserEditViewModel();
			
			viewModel.Name = values.Name;
			viewModel.Surname = values.Surname;
			viewModel.Phonenumber = values.PhoneNumber;
			viewModel.Mail = values.Email;

			return View(viewModel);


		}
	}
}
