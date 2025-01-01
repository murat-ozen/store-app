using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;
using store_app.Models;


namespace store_app.Controllers
{
    public class ProductController: Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public ActionResult Index(ProductRequestParameters p)
        {
            var products = _manager.ProductService.GetAllProductsWithDetails(p);
            var pagination = new Pagination()
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _manager.ProductService.GetAllProducts(false).Count()
            };

            return View(new ProductListViewModel()
            {
                Products = products,
                Pagination = pagination
            });
        }

        public ActionResult Get([FromRoute(Name="id")] int id)
        {
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}