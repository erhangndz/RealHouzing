using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _ServiceBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
