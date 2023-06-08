using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.AboutDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(AddAboutDto p)
        {
            About about = new About()
            {
                Title = p.Title,
                Description = p.Description,
                ImageURL = p.ImageURL,
                Item = p.Item,
            };

            _aboutService.TInsert(about);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values= _aboutService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto p)
        {
            About about = new About()
            {
                AboutID = p.AboutID,
                Title = p.Title,
                Description = p.Description,
                ImageURL = p.ImageURL,
                Item = p.Item,

            };
            _aboutService.TUpdate(about);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            _aboutService.TDelete(values);
            return Ok();
        }
    }
}
