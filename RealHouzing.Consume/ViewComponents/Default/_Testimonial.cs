using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
