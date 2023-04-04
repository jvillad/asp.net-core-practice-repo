using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OlygariaPieShop.Models;

namespace OlygariaPieShop.Controllers
{
	[Authorize]
	public class OrderController : Controller
	{
		private readonly IOrderRepository _orderRepository;
		private readonly IShoppingCart _shoppingCart;
		public OrderController(IOrderRepository orderRepository, IShoppingCart shoaderCart)
		{
			_orderRepository = orderRepository;
			_shoppingCart = shoaderCart;
		}

		public ActionResult Checkout() //Get
		{
			return View();
		}
		// called when a post is received
		[HttpPost]
		public IActionResult Checkout(Order order)
		{

			var items = _shoppingCart.GetShoppingCartItems();
			_shoppingCart.ShoppingCartItems = items;

			if (_shoppingCart.ShoppingCartItems.Count == 0)
			{
				// warning
				ModelState.AddModelError("", "Cart is empty, gotta get some yummy pie first!");
			}

			if (ModelState.IsValid)
			{
				_orderRepository.CreateOrder(order);
				_shoppingCart.ClearCart();
				return RedirectToAction("CheckoutComplete");
			}

			return View(order);
		}
		public IActionResult CheckoutComplete()
		{
			ViewBag.CheckoutCompleteMessage = "Order Complete! The supa delicious pie is on your way!";
			return View();
		}

	}
}
