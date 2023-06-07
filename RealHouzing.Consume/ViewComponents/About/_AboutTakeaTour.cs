using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutTakeaTour:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
