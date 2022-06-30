
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System;
using onlineclothing2.Controllers;

namespace onlineclothing2.Models
{

	public class DataContext : DbContext
	{
	
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json");

			var configuration = builder.Build();
			optionsBuilder.UseMySql(configuration
				["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 11)), options => options.EnableRetryOnFailure());

		}
		public DbSet<Userregister>userregisters{ get; set; }
		public DbSet<LoginAdmin>adminlogins{ get; set; }
		//public DbSet<Product> Products { get; set; }
		//public DbSet<ProductImage> ProductImages { get; set; }
		public DbSet<Add>? pcs { get; set; }
		public DbSet<AddC>? cat { get; set; }
		public DbSet<Testcart> Testcarts { get; set; }

		public DbSet<Userlogin> Userlogins { get; set; }
		public DbSet<Checkout> check { get; set; }



	}
}