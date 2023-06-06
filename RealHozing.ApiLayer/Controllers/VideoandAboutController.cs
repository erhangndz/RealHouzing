using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoandAboutController : ControllerBase
    {
        private readonly IVideoandAboutService _videoandAboutService;

        public VideoandAboutController(IVideoandAboutService videoandAboutService)
        {
            _videoandAboutService = videoandAboutService;
        }

        [HttpGet]
        public IActionResult VideoandAboutList()
        {
            var values= _videoandAboutService.TGetList();
            return Ok(values);

        }
    }
}
