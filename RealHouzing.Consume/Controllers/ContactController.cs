using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.MessageModels;
using RealHouzing.Consume.Models.SubscribeModels;
using System.Net.Http;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(AddMessageViewModel p)
        {

            using (var client = _httpClientFactory.CreateClient())
            {

                string apiUrl = "https://localhost:44316/api/Message";
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
