using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Guide
	{
		[Key]
		public int ID { get; set; }
		public string FullName { get; set; }
		public string Brief { get; set; }
		public string Image { get; set; }
		public string SocialMedia1 { get; set; }
		public string SocialMedia2 { get; set; }
		public bool Status { get; set; }
	}
}
