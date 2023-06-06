using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
