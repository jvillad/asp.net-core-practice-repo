using Microsoft.AspNetCore.Mvc;
using OlygariaPieShop.Models;
using OlygariaPieShop.ViewModels;

namespace OlygariaPieShop.Controllers
{
	public class PieController : Controller
	{
		private readonly IPieRepository _pieRepository;
		private readonly ICategoryRepository _categoryRepository;

		public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
		{
			_pieRepository = pieRepository;
			_categoryRepository = categoryRepository;
		}

		/*	public IActionResult List()
			{

				PieListViewModel pieListViewModel = new PieListViewModel
					(_pieRepository.AllPies, "All Our Pies");
				return View(pieListViewModel);
			}
	*/
		public ViewResult List(string category)
		{
			IEnumerable<Pie> pies;
			string? currentCategory;

			if (string.IsNullOrEmpty(category))
			{
				pies = _pieRepository.AllPies.OrderBy(p => p.Id);
				currentCategory = "All pies";
			}
			else
			{
				pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
					.OrderBy(p => p.Id);
				currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
			}

			return View(new PieListViewModel(pies, currentCategory));
		}
		public IActionResult Details(int id)
		{
			var pie = _pieRepository.GetPieById(id);
			if (pie == null)
				return NotFound();
			return View(pie);


		}
	}
}
