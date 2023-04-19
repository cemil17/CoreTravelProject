using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void Add(Comment t)
		{
			_commentDal.Insert(t);
		}

		public void Delete(Comment t)
		{
			_commentDal.Delete(t);
		}

		public Comment GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetDestinationByID(int id)
		{
			return _commentDal.GetListByFilter(x => x.DestinationID == id);
		}

		public List<Comment> GetList()
		{
			return _commentDal.GetList();
		}

		public void Update(Comment t)
		{
			_commentDal.Update(t);
		}
	}
}
