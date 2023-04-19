using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.Controllers
{
	public class DestinationController : Controller
	{
		DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
		public IActionResult Index()
		{
			var listed = destinationManager.GetList().Where(x => x.Status == true).Take(9).OrderByDescending(x => x.DestinationID).ToList();
			return View(listed);
		}
		public IActionResult DestinationDetails(int id)
		{
			ViewBag.ID = id;
			var getDetail = destinationManager.GetByID(id);
			return View(getDetail);
		}
	}
}
