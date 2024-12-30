using Microsoft.AspNetCore.Mvc;

namespace store_app.Components
{
    public class ProductFilterMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}