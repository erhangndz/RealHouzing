using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutCounter:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
