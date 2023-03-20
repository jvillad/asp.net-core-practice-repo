﻿using Microsoft.EntityFrameworkCore;

namespace OlygariaPieShop.Models
{
	public class OlygariaPieShopDbContext : DbContext
	{
		public OlygariaPieShopDbContext(DbContextOptions<OlygariaPieShopDbContext> dbContext) : base(dbContext)
		{
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Pie> Pies { get; set; }

	}
}