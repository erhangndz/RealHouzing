using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.CategoryModels;
using RealHouzing.EntityLayer.Concrete;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44316/api/Category");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CategoryListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryViewModel addCategoryViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addCategoryViewModel);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:44316/api/Category", content);
            if(responseMessage.IsSuccessStatusCode) {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            var client= _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:44316/api/Category/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id) 
        
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:44316/api/Category/{id}");
            if(response.IsSuccessStatusCode)
            {
                var jsonData= await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCategoryViewModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryViewModel p)
        {
            var client= _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var response = await client.PutAsync("https://localhost:44316/api/Category/", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
