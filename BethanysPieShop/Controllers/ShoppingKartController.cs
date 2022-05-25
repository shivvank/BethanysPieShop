using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class ShoppingKartController:Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ShoppingKart _shoppingKart;
        public ShoppingKartController(IPieRepository pieRepository,ShoppingKart shoppingKart)
        {
            _pieRepository = pieRepository;
            _shoppingKart = shoppingKart;
        }
         public  IActionResult Index()
        {
            var items = _shoppingKart.GetShoppingCartItems();
            _shoppingKart.ShoppingKartItems = items;
            var shoppingKartViewModel = new ShoppingKartViewModel
            {
                ShoppingKart = _shoppingKart,
                ShoppingKartTotal = _shoppingKart.GetShoppingCartTotal()
            };
            return View(shoppingKartViewModel) ;
        }
        public RedirectToActionResult AddToShoppingKart(int pieId)
        {
            var item = _pieRepository.GetPieById(pieId);
            if(item!=null)
            {
                _shoppingKart.AddToCart(item, 1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingKart(int pieId)
        {
            var item = _pieRepository.GetPieById(pieId);
            if (item != null)
            {
                _shoppingKart.RemoveFromCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
