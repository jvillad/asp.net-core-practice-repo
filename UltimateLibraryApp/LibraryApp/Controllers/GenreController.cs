using LibraryApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
	public class GenreController : Controller
	{
		private readonly AppDbContext _context;
		public GenreController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View(_context.Genres.ToList());
		}
		//get action?
		public IActionResult Create()
		{
			return View();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

	}
}
