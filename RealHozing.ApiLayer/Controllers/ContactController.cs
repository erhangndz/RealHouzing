using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.ContactDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(AddContactDto p)
        {
            Contact contact = new Contact()
            {
                Address = p.Address,
                Mail=p.Mail,
                Phone=p.Phone
              
            };

            _contactService.TInsert(contact);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _contactService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto p)
        {
            Contact contact = new Contact()
            {
                ContactID=p.ContactID,
                Address = p.Address,
                Mail = p.Mail,
                Phone = p.Phone
            };
            _contactService.TUpdate(contact);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetByID(id);
            _contactService.TDelete(values);
            return Ok();
        }
    }
}
