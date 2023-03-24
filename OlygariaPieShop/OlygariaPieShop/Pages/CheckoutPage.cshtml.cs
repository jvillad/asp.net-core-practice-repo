using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OlygariaPieShop.Models;

namespace OlygariaPieShop.Pages
{
	public class CheckoutPageModel : PageModel
	{
		private readonly IOrderRepository _orderRepository;
		private readonly IShoppingCart _shoppingCart;
		public CheckoutPageModel(IOrderRepository orderRepository, IShoppingCart shoaderCart)
		{
			_orderRepository = orderRepository;
			_shoppingCart = shoaderCart;
		}
		[BindProperty]
		public Order Order { get; set; }
		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			var items = _shoppingCart.GetShoppingCartItems();
			_shoppingCart.ShoppingCartItems = items;

			if (_shoppingCart.ShoppingCartItems.Count == 0)
			{
				// warning
				ModelState.AddModelError("", "Cart is empty, gotta get some yummy pie first!");
			}

			if (ModelState.IsValid)
			{
				_orderRepository.CreateOrder(Order);
				_shoppingCart.ClearCart();
				return RedirectToAction("CheckoutComplete");
			}

			return Page();
		}
	}
}
