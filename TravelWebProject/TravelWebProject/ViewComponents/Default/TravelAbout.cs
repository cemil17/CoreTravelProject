using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.ViewComponents.Default
{
	public class TravelAbout : ViewComponent
	{
		TravelAboutManager travelAboutManager = new TravelAboutManager(new EfTravelAboutDal());
		public IViewComponentResult Invoke()
		{
			var listed = travelAboutManager.GetList();
			return View(listed);
		}
	}
}
