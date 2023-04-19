using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.ViewComponents.Comment
{
	public class CommentList : ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EfCommentDal());
		public IViewComponentResult Invoke(int id)
		{
			var getByComment = commentManager.GetDestinationByID(id);
			ViewBag.CommentCount = getByComment.Count();

			if (ViewBag.CommentCount == 0)
			{
				ViewBag.CommentMessage = "Yorum yapılmamıştır.";
			}

			return View(getByComment);
		}
	}
}
