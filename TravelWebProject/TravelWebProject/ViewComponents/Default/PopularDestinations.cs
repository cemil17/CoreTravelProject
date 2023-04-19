using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.ViewComponents.Default
{
    public class PopularDestinations : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var listed = destinationManager.GetList().Where(x => x.Status == true).Take(8).OrderByDescending(x => x.DestinationID).ToList();
            return View(listed);
        }
    }
}
