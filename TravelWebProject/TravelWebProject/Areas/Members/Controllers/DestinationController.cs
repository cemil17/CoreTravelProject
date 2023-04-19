using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.Areas.Members.Controllers
{
	[Area("Members")]
	[Route("Members/[controller]/[action]")]

	public class DestinationController : Controller
	{
		DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
		public IActionResult Index()
		{
			var listed = destinationManager.GetList();
			return View(listed);
		}
	}
}
