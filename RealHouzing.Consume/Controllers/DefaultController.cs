using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.SubscribeModels;
using RealHouzing.EntityLayer.Concrete;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Subscribe(AddSubscribeViewModel p) 
        {
          
                using (var client = _httpClientFactory.CreateClient())
                {
                   
                    string apiUrl = "https://localhost:44316/api/Subscribe";
                    var content = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    { 
                        return RedirectToAction("Index");
                    }
                    
                }
            

            return View();

        }
    }
}
