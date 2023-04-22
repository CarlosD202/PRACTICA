using Microsoft.AspNetCore.Mvc;

namespace PRACTICA.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
