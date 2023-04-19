﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About
	{
		[Key]
		public int ID { get; set; }
		public string Header { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public bool Status { get; set; }
	}
}
