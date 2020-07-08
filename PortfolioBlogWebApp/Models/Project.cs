using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioBlogWebApp.Models
{
	public class Project
	{
		public int ProjectId { get; set; }
		public string Title { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateCompleted { get; set; }
		public string Category { get; set; }
		public string ImageFileName { get; set; }
		public string IconFileName { get; set; }

	}
}
