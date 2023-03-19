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

		public IActionResult List()
		{
			/*ViewBag.CurrentCategory = "Cheese Cakes";
			return View(_pieRepository.AllPies);*/
			PieListViewModel pieListViewModel = new PieListViewModel
				(_pieRepository.AllPies, "Cheese Cakes");
			return View(pieListViewModel);
		}
	}
}
