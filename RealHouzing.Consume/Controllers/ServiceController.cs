using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Controllers
{
	[AllowAnonymous]
	public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
