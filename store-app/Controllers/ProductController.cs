using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;


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
            var model = _manager.ProductService.GetAllProductsWithDetails(p);
            return View(model);
        }

        public ActionResult Get([FromRoute(Name="id")] int id)
        {
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}