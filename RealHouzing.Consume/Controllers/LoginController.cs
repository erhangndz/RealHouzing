using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.Consume.Models;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.Consume.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(LoginViewModel p)
		{
			AppUser appUser = new AppUser()
			{
				UserName = p.UserName,

			};
			
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false,false);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Category");
				}
				
			}
			return View();

		}
	}
}
