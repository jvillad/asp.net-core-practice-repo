using LibraryApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data
{
	public class AppDbContext : IdentityDbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
	}
}
