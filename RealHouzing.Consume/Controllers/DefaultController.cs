using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;
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
            if (ModelState.IsValid)
            {
                using (var client = _httpClientFactory.CreateClient())
                {
                    // API endpoint URL'sini belirtin
                    string apiUrl = "https://localhost:44316/api/Subscribe";

                    // Veriyi JSON formatına dönüştürün
                    var content = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");

                    // API'ye HTTP POST isteği gönderin
                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Başarılı bir şekilde ekleme yapıldığında, kullanıcıyı yönlendirebilirsiniz.
                        return RedirectToAction("Index");
                    }
                    
                }
            }

            // Veri geçerli değilse veya API ile iletişimde bir hata olduysa, hata durumunu (400 Bad Request) ve geçersiz model durumunu içeren bir yanıt dönebilirsiniz.
            return View();

        }
    }
}
