using Microsoft.AspNetCore.Mvc;

namespace EasyCacheUI.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
