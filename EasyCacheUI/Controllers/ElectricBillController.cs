using Microsoft.AspNetCore.Mvc;

namespace EasyCacheUI.Controllers
{
    public class ElectricBillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
