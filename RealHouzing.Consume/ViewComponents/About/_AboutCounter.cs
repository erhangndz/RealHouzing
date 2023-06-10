using Microsoft.AspNetCore.Mvc;
using RealHouzing.DataAccessLayer.Concrete;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutCounter:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Services.Count();
            ViewBag.v2 = c.Products.Where(x=>x.ProductType=="Satılık").Count();
            ViewBag.v3 = c.Products.Where(x=>x.ProductType=="Kiralık").Count();
            ViewBag.v4= c.Testimonials.Count();
            return View();
        }
    }
}
