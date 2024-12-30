using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace store_app.Components
{
    public class ProductSummaryViewComponent: ViewComponent
    {
        public readonly IServiceManager _manager;

        public ProductSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager.ProductService.GetAllProducts(false).Count().ToString();
        }
    }
}