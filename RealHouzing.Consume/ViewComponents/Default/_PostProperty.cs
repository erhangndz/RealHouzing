using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _PostProperty:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
