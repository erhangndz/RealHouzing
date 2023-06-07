using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutFAQ:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
