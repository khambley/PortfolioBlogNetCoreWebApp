using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBlogWebApp.Models
{
	public class MyProjectsDbContext : DbContext
	{
		public MyProjectsDbContext(DbContextOptions<MyProjectsDbContext> options) : base(options)
		{
			
		}
		public DbSet<Project> Projects { get; set; }
	}
}
