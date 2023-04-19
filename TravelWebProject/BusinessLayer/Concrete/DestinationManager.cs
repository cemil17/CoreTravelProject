﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class DestinationManager : IDestinationService
	{
		IDestinationDal _destinationDal;

		public DestinationManager(IDestinationDal destinationDal)
		{
			_destinationDal = destinationDal;
		}

		public void Add(Destination t)
		{
			_destinationDal.Insert(t);
		}

		public void Delete(Destination t)
		{
			_destinationDal.Delete(t);
		}

		public Destination GetByID(int id)
		{
			return _destinationDal.GetByID(id);
		}

		public List<Destination> GetList()
		{
			return _destinationDal.GetList();
		}

		public void Update(Destination t)
		{
			_destinationDal.Update(t);
		}
	}
}
