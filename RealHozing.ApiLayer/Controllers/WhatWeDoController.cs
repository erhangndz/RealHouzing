using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.WhatwedoDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhatWeDoController : ControllerBase
    {
        private readonly IWhatWeDoService _whatWeDoService;

        public WhatWeDoController(IWhatWeDoService whatWeDoService)
        {
            _whatWeDoService = whatWeDoService;
        }

        [HttpGet]
        public IActionResult WhatwedoList()
        {
            var values = _whatWeDoService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult WatwedoAdd(AddWhatwedoDto p)
        {
            WhatWeDo whatWeDo = new WhatWeDo()
            {
                ImageURL = p.ImageURL,
                Title = p.Title,
            };
            _whatWeDoService.TInsert(whatWeDo);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletewhatwedo(int id)
        {
            var values= _whatWeDoService.TGetByID(id);
            _whatWeDoService.TDelete(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetWhatwedo(int id)
        {
            var values = _whatWeDoService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult Updatewhatwedo(UpdateWhatwedoDto p)
        {
            WhatWeDo whatWeDo = new WhatWeDo()
            {
                WhatWeDoID= p.WhatWeDoID,
                ImageURL = p.ImageURL,
                Title = p.Title,
            };
            _whatWeDoService.TUpdate(whatWeDo);
            return Ok();
        }

    }
}
//