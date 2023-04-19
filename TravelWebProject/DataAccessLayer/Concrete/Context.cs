using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : IdentityDbContext<APPUser, APPRole, int>
	{
		// Bağlantı Adresi
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=KI2544200421; Database= CoreTravelWebProject; Integrated Security=True; ");
		}

		public DbSet<About> Abouts { get; set; }
		public DbSet<AboutDetail> AboutDetails { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Destination> Destinations { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Guide> Guides { get; set; }
		public DbSet<NewsLetter> NewsLetters { get; set; }
		public DbSet<PostOne> PostOnes { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<TravelAbout> TravelAbouts { get; set; }
	}
}
