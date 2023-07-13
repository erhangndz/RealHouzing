using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RealHouzing.Consume.Models;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.Consume.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index()
		{

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(RegisterViewModel model)
		{
			if (ModelState.IsValid)
			{
				AppUser appUser = new AppUser()
				{
					UserName = model.UserName,
					Name = model.Name,
					Surname = model.Surname,
					Email = model.Mail,
					ImageURL= model.ImageURL,
					
					
				};

				var result = await _userManager.CreateAsync(appUser, model.Password);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Login");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
						
					}
				}


			}

			
			return View();
		}


	}

}
