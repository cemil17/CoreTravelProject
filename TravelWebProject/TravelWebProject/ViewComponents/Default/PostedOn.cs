using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.ViewComponents.Default
{
	public class PostedOn : ViewComponent
	{
		FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
		public IViewComponentResult Invoke()
		{
			var listed = featureManager.GetList().OrderByDescending(x => x.ID).Take(5).ToList();
			return View(listed);
		}
	}
}
