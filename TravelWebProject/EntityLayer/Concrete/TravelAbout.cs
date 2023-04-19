using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class TravelAbout
	{
		[Key]
		public int TravelAboutID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
