using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.TestimonialModels;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
	[Authorize]
	public class TestimonialController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TestimonialController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44316/api/Testimonial");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsonData);
                return View(values);

            }
            return View();
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:44316/api/Testimonial/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> AddTestimonial(AddTestimonialViewModel p)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(p);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:44316/api/Testimonial", stringContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:44316/api/Testimonial/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateTestimonialViewModel>(jsonData);
                return View(values);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialViewModel p)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:44316/api/Testimonial/", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
