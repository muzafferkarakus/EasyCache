using Microsoft.AspNetCore.Mvc;

namespace EasyCacheUI.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
