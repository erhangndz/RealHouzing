using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class Head:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
