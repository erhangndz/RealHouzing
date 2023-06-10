using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _Pricing:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
