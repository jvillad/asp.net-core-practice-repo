namespace OlygariaPieShop.Models
{
	public class MockCategoryRepository : ICategoryRepository
	{
		public IEnumerable<Category> AllCategories => new List<Category>
		{
			new Category {CategoryId = 1, CategoryName = "Fruit Pies", Description = "All Fruty Pies"},
			new Category {CategoryId = 2, CategoryName = "Cheese Cakes", Description = "Cheesy All The Way"},
			new Category {CategoryId = 3, CategoryName = "Seasonal Pies", Description = "Get In The Mood For A Seasonal Pie"}
		};
	}
}
