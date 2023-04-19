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
	public class AboutDetailManager : IAboutDetailService
	{
		IAboutDetailDal _aboutDetailDal;

		public AboutDetailManager(IAboutDetailDal aboutDetailDal)
		{
			_aboutDetailDal = aboutDetailDal;
		}

		public void Add(AboutDetail t)
		{
			_aboutDetailDal.Insert(t);
		}

		public void Delete(AboutDetail t)
		{
			throw new NotImplementedException();
		}

		public AboutDetail GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<AboutDetail> GetList()
		{
			return _aboutDetailDal.GetList();
		}

		public void Update(AboutDetail t)
		{
			throw new NotImplementedException();
		}
	}
}
