using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.VideoandAboutModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _VideoandAbout:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _VideoandAbout(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
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
    }
}
