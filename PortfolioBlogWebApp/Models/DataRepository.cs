using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioBlogWebApp.Models
{
	public class DataRepository : IDataRepository
	{
		private MyProjectsDbContext context;

		public DataRepository(MyProjectsDbContext ctx)
		{
			context = ctx;
		}
		public IQueryable<Project> Projects => context.Projects;
	}
}
