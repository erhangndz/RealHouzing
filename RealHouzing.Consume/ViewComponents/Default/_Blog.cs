using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _Blog:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _Blog(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44316/api/Blog");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BlogViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
