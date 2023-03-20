namespace OlygariaPieShop.Models
{
	public class DbSeedData
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			OlygariaPieShopDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<OlygariaPieShopDbContext>();

			if (!context.Categories.Any())
			{
				context.Categories.AddRange(Categories.Select(c => c.Value));
			}

			if (!context.Pies.Any())
			{
				context.AddRange
				(
					new Pie
					{
						Name = "THE OG Cheese Cake",
						Price = 12.95M,
						ShortDescription = "THE Classic creamy cheesecake",
						LongDescription = "This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = true,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Ultimate Caramel Cheese Cake",
						Price = 19.95M,
						ShortDescription = "Rich and decadent caramel cheesecake",
						LongDescription = "This cheesecake takes indulgence to the next level with its rich, creamy filling and decadent caramel topping. It's perfect for special occasions or just for when you want to treat yourself to something truly special.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = true,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Olygarias Dark Chocolate Cheese Cake",
						Price = 15.95M,
						ShortDescription = "Dark chocolate lover's dream cheesecake.",
						LongDescription = "If you love the intense, rich flavor of dark chocolate, then this cheesecake is for you. With a velvety smooth texture and deep, complex flavor, it's a dessert that's sure to satisfy even the most discerning chocolate lover.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = true,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Coffee Choc Cheese Cake",
						Price = 21.95M,
						ShortDescription = "Coffee-infused chocolate cheesecake.",
						LongDescription = "This delicious dessert combines the rich, indulgent flavor of chocolate with the bold, satisfying taste of coffee. It's the perfect dessert for any coffee lover who wants a little something extra to go with their morning cup of joe.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Strawberry Cheese Cake",
						Price = 19.95M,
						ShortDescription = "Classic cheesecake with fresh strawberries.",
						LongDescription = "This cheesecake combines the classic, creamy texture of cheesecake with the bright, juicy flavor of fresh strawberries. It's a dessert that's perfect for any time of year, but especially during the summer months when strawberries are in season.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "OJ Blueberry Cheese Cake",
						Price = 12.95M,
						ShortDescription = "Classic cheesecake with fresh blueberries.",
						LongDescription = "This cheesecake is similar to the strawberry cheesecake, but with fresh blueberries instead. The sweet, tangy flavor of the blueberries complements the creamy, smooth texture of the cheesecake perfectly, making it a dessert that's both delicious and refreshing.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Blackberry Pie",
						Price = 18.95M,
						ShortDescription = "OJs classic blackberry pie.",
						LongDescription = "This classic pie is filled with juicy blackberries and baked to perfection in a flaky, buttery crust. It's a dessert that's perfect for any time of year, but especially during the summer when blackberries are at their peak.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "The Birthdate Pie",
						Price = 18.95M,
						ShortDescription = "Celebratory pie for any occasion.",
						LongDescription = "This pie is perfect for celebrating birthdays, anniversaries, or any special occasion. It's made with a sweet, buttery crust and filled with a rich, creamy filling that's sure to please any sweet tooth.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Seasonal pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Yapple Pie",
						Price = 15.95M,
						ShortDescription = "Yup! It is sweet and tangy apple pie.",
						LongDescription = "This classic pie is filled with sweet, tangy apples and baked to perfection in a flaky, buttery crust. It's a dessert that's perfect for any time of year, but especially during the fall when apples are at their peak.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Japanese Fruit Pie",
						Price = 13.95M,
						ShortDescription = "Sweet and savory fruit pie.!",
						LongDescription = "This pie is a unique blend of sweet and savory flavors, with a mix of fruits, nuts, and spices baked in a flaky crust. It's a dessert that's perfect for anyone who loves to try new and exciting flavor combinations.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Seasonal pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Season Apple Pie",
						Price = 17.95M,
						ShortDescription = "Seasonal twist on classic apple pie.",
						LongDescription = "This apple pie is made with a blend of seasonal spices and baked to perfection in a flaky, buttery crust. It's a dessert that's perfect for any time of year, but especially during the fall and winter months when the flavors of cinnamon, nutmeg, and clove are especially comforting.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Seasonal pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Cranberry Pie",
						Price = 15.95M,
						ShortDescription = "Tart and sweet cranberry pie.",
						LongDescription = "This pie is filled with tart and tangy cranberries and baked to perfection in a buttery crust. It's a dessert that's perfect for the holiday season, but also makes a great addition to any dinner party or special occasion.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = false,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Peachy Pie",
						Price = 12.95M,
						ShortDescription = "Sweet and juicy peach pie.",
						LongDescription = "IThis classic pie is filled with sweet, juicy peaches and baked to perfection in a flaky, buttery crust. It's a dessert that's perfect for any time of year, but especially during the summer months when peaches are at their peak.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Seasonal pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Blueberry Cream Cheese Pie",
						Price = 15.95M,
						ShortDescription = "Creamy blueberry pie with a twist.",
						LongDescription = "This unique twist on classic blueberry pie features a creamy, tangy cream cheese filling layered on top of a bed of juicy blueberries. It's a dessert that's perfect for anyone who loves the classic combination of blueberries and cream cheese.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Tropical Pie",
						Price = 15.95M,
						ShortDescription = "Sweet and fruity tropical pie.",
						LongDescription = "This pie is filled with a mix of tropical fruits, such as pineapple, mango, and kiwi, and baked to perfection in a flaky, buttery crust. It's a dessert that's perfect for anyone who loves the sweet and tangy flavors of tropical fruits.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Seasonal pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "The Banoffee Pie",
						Price = 18.95M,
						ShortDescription = "Rich and indulgent banana toffee pie.",
						LongDescription = "This decadent pie features a sweet, creamy filling made with bananas and toffee, all baked in a buttery crust. It's a dessert that's perfect for anyone with a sweet tooth who loves the rich, indulgent flavors of banana and toffee.This is the original and classic cheesecake that everyone knows and loves. With a creamy, smooth texture and rich, indulgent flavor, it's perfect for any occasion or just a sweet treat any day of the week.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://dummyimage.com/970x600/000/fff&text=image+url+holder",
						InStock = false,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://dummyimage.com/480x310/000/fff&text=image+holder+thumbnail",
						AllergyInformation = ""
					}
				);
			}

			context.SaveChanges();
		}

		private static Dictionary<string, Category>? categories;

		public static Dictionary<string, Category> Categories
		{
			get
			{
				if (categories == null)
				{
					var genresList = new Category[]
					{
						new Category { CategoryName = "Fruit pies" },
						new Category { CategoryName = "Cheese cakes" },
						new Category { CategoryName = "Seasonal pies" }
					};

					categories = new Dictionary<string, Category>();

					foreach (Category genre in genresList)
					{
						categories.Add(genre.CategoryName, genre);
					}
				}

				return categories;
			}
		}
	}
}
