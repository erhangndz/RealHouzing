using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _MainArea:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
