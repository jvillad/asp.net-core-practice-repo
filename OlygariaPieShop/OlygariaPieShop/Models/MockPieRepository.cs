namespace OlygariaPieShop.Models
{
	public class MockPieRepository : IPieRepository
	{

		private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

		public IEnumerable<Pie> AllPies =>
			new List<Pie>
			{
				new Pie {
					Id = 1,
					Name="Strawberry Pie",
					Price=15.95M,
					ShortDescription="Lorem Ipsum",
					LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
					Category = _categoryRepository.AllCategories.ToList()[0],
					// TODO: change image holder
					ImageUrl="https://dummyimage.com/970x600/000/fff&text=image+url+holder",
					InStock=true,
					IsPieOfTheWeek=false,
					ImageThumbnailUrl="https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail"},
				new Pie {
					Id = 2,
					Name="Cheese cake",
					Price=18.95M,
					ShortDescription="Lorem Ipsum",
					LongDescription="Zu es ort spät kleinem von treibt laue du du so in ihr die vaterland ist dann nicht sanken großer von teuren trübhell zurück in du die sanken wiedersehn lieb trübhell ich mut die so du es großer sanft gesellschaft",
					Category = _categoryRepository.AllCategories.ToList()[1],
					// TODO: change image holder
					ImageUrl="https://dummyimage.com/970x600/000/fff&text=image+url+holder",
					InStock=true,
					IsPieOfTheWeek=false,
					ImageThumbnailUrl="https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail"},
				new Pie {
					Id = 3,
					Name="Rhubarb Pie",
					Price=15.95M,
					ShortDescription="Lorem Ipsum",
					LongDescription="Zu es ort spät kleinem von treibt laue du du so in ihr die vaterland ist dann nicht sanken großer von teuren trübhell zurück in du die sanken wiedersehn lieb trübhell ich mut die so du es großer sanft gesellschaft",
					Category = _categoryRepository.AllCategories.ToList()[0],
					ImageUrl="https://dummyimage.com/970x600/000/fff&text=image+url+holder",
					InStock=true,
					IsPieOfTheWeek=true,
					ImageThumbnailUrl="https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail"},
				new Pie {
					Id = 4,
					Name="Pumpkin Pie",
					Price=12.95M,
					ShortDescription="Lorem Ipsum",
					LongDescription="Zu es ort spät kleinem von treibt laue du du so in ihr die vaterland ist dann nicht sanken großer von teuren trübhell zurück in du die sanken wiedersehn lieb trübhell ich mut die so du es großer sanft gesellschaft",
					Category = _categoryRepository.AllCategories.ToList()[2],
					ImageUrl="https://dummyimage.com/970x600/000/fff&text=image+url+holde",
					InStock=true,
					IsPieOfTheWeek=true,
					ImageThumbnailUrl="https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail"}
			};

		public IEnumerable<Pie> PiesOfTheWeek
		{
			get
			{
				return AllPies.Where(p => p.IsPieOfTheWeek);
			}
		}

		public Pie? GetPieById(int pieId) => AllPies.FirstOrDefault(p => p.Id == pieId);

		public IEnumerable<Pie> SearchPies(string searchQuery)
		{
			throw new NotImplementedException();
		}
	}

}

