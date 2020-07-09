using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioBlogWebApp.Models
{
	public class Project
	{
		public int ProjectId { get; set; }
		public string ProjectTitle { get; set; }
		public string ProjectShortDesc { get; set; }
		public string ProjectLongDesc { get; set; }
		public DateTime ProjectDateCreated { get; set; }
		public DateTime ProjectDateCompleted { get; set; }
		public string ProjectType { get; set; } //Web App, Desktop, Mobile
		public string ProjectCategory { get; set; }
		public string ProjectImageFileName { get; set; }
		public string ProjectLogoFileName { get; set; }
		// Features - i.e. Admin Dashboard, Login, 
		// Technologies - i.e. .NET Core, MVC, C#, SQL Server, EF Core, Angular, etc.


	}
}
