using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.PostingDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

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

        [HttpPost]
        public IActionResult AddPosting(AddPostingDto p)
        {
            Posting posting = new Posting()
            {
                Description = p.Description,
                ImageURL = p.ImageURL,
                Title = p.Title,
            };
            _postingService.TInsert(posting);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePosting(int id)
        {
            var values= _postingService.TGetByID(id);
            _postingService.TDelete(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetPosting(int id)
        {
            var values = _postingService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdatePosting(UpdatePostingDto p)
        {
            Posting posting = new Posting()
            {
                PostingID=p.PostingID,
                Description = p.Description,
                ImageURL = p.ImageURL,
                Title = p.Title,
            };
            _postingService.TUpdate(posting);
            return Ok();
        }
    }
}
