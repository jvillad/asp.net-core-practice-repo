using Microsoft.EntityFrameworkCore;

namespace OlygariaPieShop.Models
{
	public class ShoppingCart : IShoppingCart
	{
		private readonly OlygariaPieShopDbContext _olygariaPieShopDbContext;

		public string? ShoppingCartId { get; set; }

		public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

		private ShoppingCart(OlygariaPieShopDbContext olygariaPieShopDbContext)
		{
			_olygariaPieShopDbContext = olygariaPieShopDbContext;
		}

		public static ShoppingCart GetCart(IServiceProvider services)
		{
			ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

			OlygariaPieShopDbContext context = services.GetService<OlygariaPieShopDbContext>() ?? throw new Exception("Error initializing");

			string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

			session?.SetString("CartId", cartId);

			return new ShoppingCart(context) { ShoppingCartId = cartId };
		}

		public void AddToCart(Pie pie)
		{
			var shoppingCartItem =
					_olygariaPieShopDbContext.ShoppingCartItems.SingleOrDefault(
						s => s.Pie.Id == pie.Id && s.ShoppingCartId == ShoppingCartId);

			if (shoppingCartItem == null)
			{
				shoppingCartItem = new ShoppingCartItem
				{
					ShoppingCartId = ShoppingCartId,
					Pie = pie,
					Amount = 1
				};

				_olygariaPieShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
			}
			else
			{
				shoppingCartItem.Amount++;
			}
			_olygariaPieShopDbContext.SaveChanges();
		}

		public int RemoveFromCart(Pie pie)
		{
			var shoppingCartItem =
					_olygariaPieShopDbContext.ShoppingCartItems.SingleOrDefault(
						s => s.Pie.Id == pie.Id && s.ShoppingCartId == ShoppingCartId);

			var localAmount = 0;

			if (shoppingCartItem != null)
			{
				if (shoppingCartItem.Amount > 1)
				{
					shoppingCartItem.Amount--;
					localAmount = shoppingCartItem.Amount;
				}
				else
				{
					_olygariaPieShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);
				}
			}

			_olygariaPieShopDbContext.SaveChanges();

			return localAmount;
		}

		public List<ShoppingCartItem> GetShoppingCartItems()
		{
			return ShoppingCartItems ??=
					   _olygariaPieShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
						   .Include(s => s.Pie)
						   .ToList();
		}

		public void ClearCart()
		{
			var cartItems = _olygariaPieShopDbContext
				.ShoppingCartItems
				.Where(cart => cart.ShoppingCartId == ShoppingCartId);

			_olygariaPieShopDbContext.ShoppingCartItems.RemoveRange(cartItems);

			_olygariaPieShopDbContext.SaveChanges();
		}

		public decimal GetShoppingCartTotal()
		{
			var total = _olygariaPieShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
				.Select(c => c.Pie.Price * c.Amount).Sum();
			return total;
		}
	}
}
