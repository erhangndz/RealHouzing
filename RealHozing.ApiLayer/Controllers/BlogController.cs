using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.BlogDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [HttpGet]
        public IActionResult BlogList()
        {
            var values= _blogService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult BlogDelete(int id)
        {
            var values= _blogService.TGetByID(id);
            _blogService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddBlog(AddBlogDto p)
        {
            Blog blog = new Blog()
            {
                BlogImage = p.BlogImage,
                Date = DateTime.Parse(DateTime.Now.ToShortDateString()),
                Description = p.Description,
                Title = p.Title,
                Writer = p.Writer,
                WriterImage = p.WriterImage,

            };

            _blogService.TInsert(blog);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBlog(int id)
        {
            var values = _blogService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateBlog(UpdateBlogDto p)
        {
            Blog blog = new Blog()
            {
                BlogID = p.BlogID,
                BlogImage = p.BlogImage,
                Description = p.Description,
                Title = p.Title,
                Writer = p.Writer,
                WriterImage = p.WriterImage,
                Date= DateTime.Parse(DateTime.Now.ToShortDateString()),
            };
            _blogService.TUpdate(blog);
            return Ok();
        }
    }
}
