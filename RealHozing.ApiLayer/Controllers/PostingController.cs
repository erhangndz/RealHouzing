using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostingController : ControllerBase
    {
        private readonly IPostingService _postingService;

        public PostingController(IPostingService postingService)
        {
            _postingService = postingService;
        }

        [HttpGet]
        public IActionResult PostingList()
        {
            var values= _postingService.TGetList();
            return Ok(values);
        }
    }
}
