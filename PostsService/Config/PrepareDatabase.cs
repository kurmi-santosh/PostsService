using System;
using Microsoft.EntityFrameworkCore;
using PostsService.Database;

namespace PostsService.Config
{
	public static class PrepareDatabase
	{
		public static void PreparePopulation(IApplicationBuilder app)
		{
			using(var serviceScope = app.ApplicationServices.CreateScope())
			{
				SeedData(serviceScope.ServiceProvider.GetService<DataContext>());
			}
		}

		public static void SeedData(DataContext? context)
		{
			System.Console.WriteLine("Applying Migrations...");
			context?.Database.Migrate();
		}
	}
}

