using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.TestimonialDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult TestimonialGet(int id)
        {
            var values = _testimonialService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto p)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialID = p.TestimonialID,
                Comment = p.Comment,
                ImageURL = p.ImageURL,
                NameSurname = p.NameSurname,
                Title = p.Title,
            };
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddTestimonial(AddTestimonialDto p)
        {
            Testimonial testimonial = new Testimonial()
            {
                Comment = p.Comment,
                ImageURL = p.ImageURL,
                NameSurname = p.NameSurname,
                Title = p.Title,

            };
            _testimonialService.TInsert(testimonial);
            return Ok();
        }
    }
}
