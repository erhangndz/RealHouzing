using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyLeaseController : ControllerBase
    {
        private readonly IBuyLeaseService _buyLeaseService;

        public BuyLeaseController(IBuyLeaseService buyLeaseService)
        {
            _buyLeaseService = buyLeaseService;
        }

        [HttpGet]
        public IActionResult BuyLeaseList()
        {
            
            var values= _buyLeaseService.TGetList();
            return Ok(values);
        }
    }
}
