using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutCoLiving:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
