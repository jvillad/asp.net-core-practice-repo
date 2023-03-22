namespace OlygariaPieShop.Models
{
	public class OrderRepository : IOrderRepository
	{
		private readonly OlygariaPieShopDbContext _olygariaPieShopDbContext;
		private readonly IShoppingCart _shoppingCart;

		public OrderRepository(OlygariaPieShopDbContext olygariaPieShopDbContext, IShoppingCart shoppingCart)
		{
			_olygariaPieShopDbContext = olygariaPieShopDbContext;
			_shoppingCart = shoppingCart;
		}

		public void CreateOrder(Order order)
		{
			order.OrderPlaced = DateTime.Now;

			List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
			order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

			order.OrderDetails = new List<OrderDetail>();

			//adding the order with its details

			foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
			{
				var orderDetail = new OrderDetail
				{
					Amount = shoppingCartItem.Amount,
					PieId = shoppingCartItem.Pie.Id,
					Price = shoppingCartItem.Pie.Price
				};

				order.OrderDetails.Add(orderDetail);
			}

			_olygariaPieShopDbContext.Orders.Add(order);

			_olygariaPieShopDbContext.SaveChanges();
		}
	}
}
