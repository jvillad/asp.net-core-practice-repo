using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OlygariaPieShop.Pages
{
	public class CheckoutCompletePageModel : PageModel
	{
		public void OnGet()
		{
			ViewData["CheckoutCompleteMessage"] = "Order Complete! The supa delicious pie is on your way!";
		}
	}
}
