using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PortfolioBlogWebApp.Models
{
	public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			MyProjectsDbContext context = app.ApplicationServices
				.CreateScope().ServiceProvider.GetRequiredService<MyProjectsDbContext>();

			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}

			if (!context.Projects.Any())
			{
				context.Projects.AddRange(
					new Project
					{
						ProjectTitle = "Test Project 1",
						ProjectShortDesc = "A test short description for project 1.",
						ProjectLongDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ex felis, molestie aliquet risus facilisis, finibus varius enim. Morbi finibus lacus nec commodo rutrum. Suspendisse potenti. Nullam lobortis, neque et pellentesque tincidunt, augue ipsum auctor velit, in volutpat lorem dolor at mi.",
						ProjectDateCreated = Convert.ToDateTime("07/08/2020"),
						ProjectType = "Web",
						ProjectCategory = "Data Tracking",
						ProjectImageFileName = "image1.jpg",
						ProjectLogoFileName = "motorcycle-rider.png"
					},
					new Project
					{
						ProjectTitle = "Test Project 2",
						ProjectShortDesc = "A test short description for project 2.",
						ProjectLongDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ex felis, molestie aliquet risus facilisis, finibus varius enim. Morbi finibus lacus nec commodo rutrum. Suspendisse potenti. Nullam lobortis, neque et pellentesque tincidunt, augue ipsum auctor velit, in volutpat lorem dolor at mi.",
						ProjectDateCreated = Convert.ToDateTime("06/08/2020"),
						ProjectType = "Web",
						ProjectCategory = "Inventory Mgt",
						ProjectImageFileName = "image2.png",
						ProjectLogoFileName = "motorcycle-rider.png"
					},
					new Project
					{
						ProjectTitle = "Test Project 3",
						ProjectShortDesc = "A test short description for project 3.",
						ProjectLongDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ex felis, molestie aliquet risus facilisis, finibus varius enim. Morbi finibus lacus nec commodo rutrum. Suspendisse potenti. Nullam lobortis, neque et pellentesque tincidunt, augue ipsum auctor velit, in volutpat lorem dolor at mi.",
						ProjectDateCreated = Convert.ToDateTime("05/08/2020"),
						ProjectType = "Web",
						ProjectCategory = "Online Store",
						ProjectImageFileName = "image3.jpg",
						ProjectLogoFileName = "motorcycle-rider.png"
					},
					new Project
					{
						ProjectTitle = "Test Project 4",
						ProjectShortDesc = "A test short description for project 4.",
						ProjectLongDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ex felis, molestie aliquet risus facilisis, finibus varius enim. Morbi finibus lacus nec commodo rutrum. Suspendisse potenti. Nullam lobortis, neque et pellentesque tincidunt, augue ipsum auctor velit, in volutpat lorem dolor at mi.",
						ProjectDateCreated = Convert.ToDateTime("07/03/2020"),
						ProjectType = "Web",
						ProjectCategory = "Online Quiz Maker",
						ProjectImageFileName = "image4.jpg",
						ProjectLogoFileName = "motorcycle-rider.png"
					},
					new Project
					{
						ProjectTitle = "Test Project 5",
						ProjectShortDesc = "A test short description for project 5.",
						ProjectLongDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ex felis, molestie aliquet risus facilisis, finibus varius enim. Morbi finibus lacus nec commodo rutrum. Suspendisse potenti. Nullam lobortis, neque et pellentesque tincidunt, augue ipsum auctor velit, in volutpat lorem dolor at mi.",
						ProjectDateCreated = Convert.ToDateTime("06/29/2020"),
						ProjectType = "Mobile",
						ProjectCategory = "Game",
						ProjectImageFileName = "image5.jpg",
						ProjectLogoFileName = "motorcycle-rider.png"
					}
				);
				context.SaveChanges();
			}
		}
	}
}
