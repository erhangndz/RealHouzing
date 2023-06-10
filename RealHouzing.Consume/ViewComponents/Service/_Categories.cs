using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.CategoryModels;
using RealHouzing.Consume.Models.ServiceModels;
using System.Net.Http;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _Categories:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _Categories(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44316/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ServiceViewModel>>(jsonData);
                return View(values);
            }
            return View();
            
        }
    }
}
