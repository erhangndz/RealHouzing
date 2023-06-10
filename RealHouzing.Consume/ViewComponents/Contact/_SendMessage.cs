using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Contact
{
    public class _SendMessage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
