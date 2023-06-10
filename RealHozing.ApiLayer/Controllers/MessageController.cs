using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.ContactDtos;
using Realhouzing.DtoLayer.MessageDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessage(AddMessageDto p)
        {
            Message message = new Message()
            {
                Content = p.Content,
                Mail=p.Mail,
                NameSurname=p.NameSurname,
                Phone=p.Phone,
                Subject=p.Subject

            };

            _messageService.TInsert(message);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var values = _messageService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto p)
        {
            Message message = new Message()
            {
                MessageID=p.MessageID,
                Content = p.Content,
                Mail = p.Mail,
                NameSurname = p.NameSurname,
                Phone = p.Phone,
                Subject = p.Subject

            };
            _messageService.TUpdate(message);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var values = _messageService.TGetByID(id);
            _messageService.TDelete(values);
            return Ok();
        }
    }
}
