using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.ViewComponents.Default
{
	public class Statistics : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			using var c = new Context();

			ViewBag.Destination = c.Destinations.Count();

			ViewBag.Guide = c.Guides.Count();

			ViewBag.V1 = "256";
			ViewBag.V2 = "32";

			return View();
		}
	}
}
