using Microsoft.AspNetCore.Components;
using OlygariaPieShop.Models;

namespace OlygariaPieShop.Pages.App
{
	public partial class PieCard
	{
		[Parameter]
		public Pie? Pie { get; set; }
	}
}
