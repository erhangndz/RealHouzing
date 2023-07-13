using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.CategoryModels;
using RealHouzing.Consume.Models.VideoandAboutModels;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
	[Authorize]
	public class VideoandAboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VideoandAboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44316/api/VideoandAbout");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<VideoandAboutViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddVideoandAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVideoandAbout(AddVideoandAboutViewModel p)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44316/api/VideoandAbout", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteVideoandAbout(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:44316/api/VideoandAbout/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateVideoandAbout(int id)

        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:44316/api/VideoandAbout/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateVideoandAboutViewModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateVideoandAbout(UpdateVideoandAboutViewModel p)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:44316/api/VideoandAbout/", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
