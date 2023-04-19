using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EfCommentDal());
		

		[HttpGet]
		public PartialViewResult LeaveComment()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult LeaveComment(Comment comment)
		{
			comment.State = true;
			comment.Date = Convert.ToDateTime(DateTime.Now);

			commentManager.Add(comment);

			return RedirectToAction("Index", "Destination");
		}
	}
}
