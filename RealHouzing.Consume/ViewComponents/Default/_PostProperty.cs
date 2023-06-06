using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _PostProperty:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PostProperty(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44316/api/Posting");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<PostingViewModel>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
