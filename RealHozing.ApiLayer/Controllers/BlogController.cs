using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;

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
    }
}
