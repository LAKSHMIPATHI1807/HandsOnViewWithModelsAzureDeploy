using Microsoft.AspNetCore.Mvc;

namespace Hands_On_Models.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}
