using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.VideoandAboutDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

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
            var values = _videoandAboutService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddVideo(AddVideoDto p)
        {
            VideoandAbout videoandAbout = new VideoandAbout()
            {
                Title = p.Title,
                Description = p.Description,
                VideoURL = p.VideoURL,

            };
            _videoandAboutService.TInsert(videoandAbout);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideo(int id)
        {
            var values = _videoandAboutService.TGetByID(id);
            _videoandAboutService.TDelete(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetVideo(int id)
        {
            var values = _videoandAboutService.TGetByID(id);
            return Ok(values);

        }

        [HttpPut]
        public IActionResult UpdateVideo(UpdateVideoDto p)
        {
            VideoandAbout videoandAbout = new VideoandAbout()
            {
                VideoandAboutID = p.VideoandAboutID,
                Title = p.Title,
                Description = p.Description,
                VideoURL = p.VideoURL,

            };

            _videoandAboutService.TUpdate(videoandAbout);
            return Ok();
        }

    }
}
