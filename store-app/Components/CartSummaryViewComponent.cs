using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace store_app.Components
{
    public class CartSummaryViewComponent: ViewComponent
    {
        public readonly Cart _cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            _cart = cartService;
        }
        public string Invoke()
        {
            return _cart.Lines.Count().ToString();
        }
    }
}