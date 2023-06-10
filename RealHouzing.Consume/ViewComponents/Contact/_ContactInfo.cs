using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.AboutModels;
using RealHouzing.Consume.Models.ContactModels;

namespace RealHouzing.Consume.ViewComponents.Contact
{
    public class _ContactInfo:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ContactInfo(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44316/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ContactListViewModel>>(jsonData);
                return View(values);
            }
            return View();

        }
    }
}
