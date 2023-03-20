namespace OlygariaPieShop.Models
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly OlygariaPieShopDbContext _context;

		public CategoryRepository(OlygariaPieShopDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Category> AllCategories => _context.Categories.OrderBy(p => p.CategoryName);
	}
}
