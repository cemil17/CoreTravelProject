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

	public class LoginController : Controller
	{
		private readonly SignInManager<APPUser> _signInManager;

		public LoginController(SignInManager<APPUser> signInManager)
		{
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignIn(UserLoginViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.userName, p.password, true, true);

				if (result.Succeeded)
				{
					//var url = Url.RouteUrl("areas", new { controller = "[Profile]", action = "Index", area = "[Members]" });
					//return View(url);
					return RedirectToAction("Index", "Profile");
				}
				else
				{
					ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
				}
			}
			return View();
		}
	}
}
