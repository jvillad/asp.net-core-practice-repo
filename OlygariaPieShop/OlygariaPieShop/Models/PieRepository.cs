using Microsoft.EntityFrameworkCore;

namespace OlygariaPieShop.Models
{
	public class PieRepository : IPieRepository
	{
		private readonly OlygariaPieShopDbContext _context;

		public PieRepository(OlygariaPieShopDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Pie> AllPies
		{
			get
			{
				return _context.Pies.Include(p => p.Category);
			}
		}

		public IEnumerable<Pie> PiesOfTheWeek
		{
			get { return _context.Pies.Include(p => p.Category).Where(p => p.IsPieOfTheWeek); }
		}

		public Pie? GetPieById(int pieId)
		{
			return _context.Pies.FirstOrDefault(p => p.Id == pieId);
		}

		public IEnumerable<Pie> SearchPies(string searchQuery)
		{
			return _context.Pies.Where(p => p.Name.Contains(searchQuery));
		}
	}
}
