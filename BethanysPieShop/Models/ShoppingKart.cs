using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class ShoppingKart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingKartId { get; set; }
        public List<ShoppingKartItem> ShoppingKartItems { get; set; }
        public ShoppingKart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public static  ShoppingKart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingKart(context) { ShoppingKartId=cartId};
        }
        public void AddToCart(Pie pie,int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingKartItems.SingleOrDefault(s => s.Pie.PieId == pie.PieId && s.ShoppingKartId == ShoppingKartId);
            if(shoppingCartItem==null)
            {
                shoppingCartItem = new ShoppingKartItem
                {
                    ShoppingKartId = ShoppingKartId,
                    Pie = pie,
                    Amount = amount
                };
                _appDbContext.ShoppingKartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }
        public int RemoveFromCart(Pie pie)
        {
            var shoppingCartItem = _appDbContext.ShoppingKartItems.SingleOrDefault(c => c.Pie.PieId == pie.PieId && c.ShoppingKartId == ShoppingKartId);
            var localAmount = 0;
            if(shoppingCartItem!=null)
            {
                if(shoppingCartItem.Amount>1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingKartItems.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;
        }
        public List<ShoppingKartItem> GetShoppingCartItems()
        {
            return ShoppingKartItems ?? (ShoppingKartItems =
            _appDbContext.ShoppingKartItems.Where(c => c.ShoppingKartId == ShoppingKartId)
            .Include(s => s.Pie)
            .ToList());
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingKartItems.Where(c => c.ShoppingKartId == ShoppingKartId);
            _appDbContext.ShoppingKartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingKartItems
                .Where(c => c.ShoppingKartId == ShoppingKartId)
                .Select(c => c.Pie.Price * c.Amount).Sum();
            return total;
        }
    }
}
