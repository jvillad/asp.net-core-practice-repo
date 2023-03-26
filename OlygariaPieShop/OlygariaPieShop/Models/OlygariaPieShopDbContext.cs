using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OlygariaPieShop.Models
{
	public class OlygariaPieShopDbContext : IdentityDbContext
	{
		public OlygariaPieShopDbContext(DbContextOptions<OlygariaPieShopDbContext> dbContext) : base(dbContext)
		{
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Pie> Pies { get; set; }
		public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrdersDetail { get; set; }
	}
}
