using Microsoft.AspNetCore.Mvc;
using OlygariaPieShop.Models;

namespace OlygariaPieShop.Controllers
{
	public class OrderController : Controller
	{
		private readonly IOrderRepository _orderRepository;
		private readonly IShoppingCart _shoaderCart;
		public OrderController(IOrderRepository orderRepository, IShoppingCart shoaderCart)
		{
			_orderRepository = orderRepository;
			_shoaderCart = shoaderCart;
		}

		public ActionResult Checkout()
		{
			return View();
		}
	}
}
