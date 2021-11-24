using Microsoft.AspNetCore.Mvc;

namespace TheBindingPage2.Controllers
{
    public class SeedsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}