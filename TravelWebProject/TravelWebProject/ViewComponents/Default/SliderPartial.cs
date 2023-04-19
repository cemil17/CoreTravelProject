using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.ViewComponents.Default
{
    public class SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
