﻿using OlygariaPieShop.Models;

namespace OlygariaPieShop.ViewModels
{
	public class ShoppingCartViewModel
	{
		public IShoppingCart ShoppingCart { get; }
		public decimal ShoppingCartTotal { get; }

		public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
		{
			ShoppingCart = shoppingCart;
			ShoppingCartTotal = shoppingCartTotal;
		}
	}
}
