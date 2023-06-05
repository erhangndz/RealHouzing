using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;

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
            var values= _whatWeDoService.TGetList();
            return Ok(values);

        }
    }
}
//