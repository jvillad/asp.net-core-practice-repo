using Microsoft.AspNetCore.Mvc;
using OlygariaPieShop.Models;
using OlygariaPieShop.ViewModels;

namespace OlygariaPieShop.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPieRepository _pieRepository;

		public HomeController(IPieRepository pieRepository)
		{
			_pieRepository = pieRepository;
		}
		public IActionResult Index()
		{
			var piesOfThWeek = _pieRepository.PiesOfTheWeek;
			var homeViewModel = new HomeViewModel(piesOfThWeek);
			return View(homeViewModel);
		}
	}
}
