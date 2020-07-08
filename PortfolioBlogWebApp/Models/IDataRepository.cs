using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioBlogWebApp.Models
{
	public interface IDataRepository
	{
		IQueryable<Project> Projects { get; }
	}
}
