using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace store_app.Components
{
    public class CategoriesMenuViewComponent: ViewComponent
    {
        public readonly IServiceManager _manager;

        public CategoriesMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _manager.CategoryService.GetAllCategories(false);
            return View(categories);
        }
    }
}