using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class BuyorLease:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
