using Microsoft.AspNetCore.Mvc;

namespace store_app.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}