using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelWebProject.Areas.Members.Models;
using TravelWebProject.Models;

namespace TravelWebProject.Areas.Members.Controllers
{
	[AllowAnonymous]

	[Area("Members")]
	[Route("Members/[controller]/[action]")]

	public class RegisterController : Controller
	{
		private readonly UserManager<APPUser> _userManager;

		public RegisterController(UserManager<APPUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignUp(UserRegisterViewModel p)
		{
			if (ModelState.IsValid)
			{
				APPUser appUser = new APPUser()
				{
					UserName = p.UserName,
					Name = p.Name,
					Surname = p.Surname,
					Email = p.Mail
				};

				if (p.Password == p.ConfirmPassword)
				{
					var result = await _userManager.CreateAsync(appUser, p.Password);

					if (result.Succeeded)
					{
						return RedirectToAction("SignIn", "AccountSettings");
					}

					else
					{
						foreach (var item in result.Errors)
						{
							ModelState.AddModelError("", item.Description);
						}
					}
				}
			}

			return View();
		}
	}
}
