using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.BuyLeaseDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

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
        [HttpPost]
        public IActionResult AddBuyLease(AddBuyLeaseDto p)
        {
            BuyLease buyLease = new BuyLease()
            {
                Button = p.Button,
                ImageURL = p.ImageURL,
                Title1 = p.Title1,
                Title2 = p.Title2,
            };
            _buyLeaseService.TInsert(buyLease);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBuyLease(int id)
        {
            var values= _buyLeaseService.TGetByID(id);
            _buyLeaseService.TDelete(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBuyLease(int id)
        {
            var values = _buyLeaseService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateBuyLease(UpdateBuyLeaseDto p)
        {
            BuyLease buyLease = new BuyLease()
            {
                Button = p.Button,
                ImageURL = p.ImageURL,
                Title1 = p.Title1,
                Title2 = p.Title2,
                BuyLeaseID = p.BuyLeaseID,
            };
            _buyLeaseService.TUpdate(buyLease);
            return Ok();
        }
    }
}
