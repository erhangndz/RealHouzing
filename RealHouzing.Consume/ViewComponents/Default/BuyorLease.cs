using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.BuyLeaseModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class BuyorLease : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BuyorLease(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44316/api/BuyLease");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<BuyLeaseViewModel>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
