using Microsoft.AspNetCore.Mvc;

namespace AspNet_Practica.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
