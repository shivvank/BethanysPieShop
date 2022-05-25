using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Components
{
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly ShoppingKart _shoppingKart;
        public ShoppingCartSummary(ShoppingKart shoppingKart)
        {
            _shoppingKart = shoppingKart;
        }
        public IViewComponentResult Invoke()
        {
            var items = _shoppingKart.GetShoppingCartItems();
            _shoppingKart.ShoppingKartItems = items;
            ShoppingKartViewModel shoppingKartViewModel = new ShoppingKartViewModel
            {
                ShoppingKart = _shoppingKart,
                ShoppingKartTotal = _shoppingKart.GetShoppingCartTotal()
            };
            return View(shoppingKartViewModel);
        }
    }
}
