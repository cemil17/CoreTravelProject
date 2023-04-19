using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.ViewComponents.Default
{
	public class Testimonial : ViewComponent
	{
		TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
		public IViewComponentResult Invoke()
		{
			var listed = testimonialManager.GetList();
			ViewBag.List = listed.Count();
			if (ViewBag.List == 0)
			{
				ViewBag.Message = "Şuana kadar bir değerlendirme yapılmamıştır.";
			}

			return View(listed);
		}
	}
}
