using OlygariaPieShop.Models;

namespace OlygariaPieShop.ViewModels
{
	public class PieListViewModel
	{
		public IEnumerable<Pie> Pies { get; }
		public String? CurrentCategory { get; }
		public PieListViewModel(IEnumerable<Pie> pies, string? currentCategory)
		{
			Pies = pies;
			CurrentCategory = currentCategory;
		}
	}
}
