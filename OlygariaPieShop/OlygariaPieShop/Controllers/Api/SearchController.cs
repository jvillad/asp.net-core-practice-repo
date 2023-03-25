using Microsoft.AspNetCore.Mvc;
using OlygariaPieShop.Models;

namespace OlygariaPieShop.Controllers.Api
{
	[Route("api/[controller]")]
	[ApiController]
	public class SearchController : ControllerBase
	{
		private readonly IPieRepository _pieRepository;
		public SearchController(IPieRepository pieRepository)

		{
			_pieRepository = pieRepository;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var allPies = _pieRepository.AllPies;
			return Ok(allPies); //200
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			if (!_pieRepository.AllPies.Any(p => p.Id == id))
				return NotFound(); //404

			return Ok(_pieRepository.AllPies.Where(p => p.Id == id)); //200 if pie exist
		}
		[HttpPost]
		public IActionResult SearchPies([FromBody] string searchQuery)
		{
			IEnumerable<Pie> pies = new List<Pie>();
			if (!string.IsNullOrEmpty(searchQuery))
			{
				pies = _pieRepository.SearchPies(searchQuery);
			}
			return new JsonResult(pies);
		}
	}
}
