using Microsoft.AspNetCore.Mvc;

namespace EasyCacheUI.Controllers
{
    public class MyAccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
