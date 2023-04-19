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
	public class TravelAboutManager : ITravelAboutService
	{
		ITravelAboutDal _travelAboutDal;

		public TravelAboutManager(ITravelAboutDal travelAboutDal)
		{
			_travelAboutDal = travelAboutDal;
		}

		public void Add(TravelAbout t)
		{
			throw new NotImplementedException();
		}

		public void Delete(TravelAbout t)
		{
			throw new NotImplementedException();
		}

		public TravelAbout GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<TravelAbout> GetList()
		{
			return _travelAboutDal.GetList();
		}

		public void Update(TravelAbout t)
		{
			throw new NotImplementedException();
		}
	}
}
