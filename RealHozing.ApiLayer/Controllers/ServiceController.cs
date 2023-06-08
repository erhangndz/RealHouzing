using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.ServiceDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values= _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(AddServiceDto p)
        {
            Service service = new Service()
            {
                Description = p.Description,
                Icon = p.Icon,
                ServiceName = p.ServiceName,
                Title = p.Title
                
            };

            _serviceService.TInsert(service);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values= _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDto p)
        {
            Service service = new Service()
            {
                Description = p.Description,
                Icon = p.Icon,
                ServiceName = p.ServiceName,
                Title = p.Title,
                ServiceID=p.ServiceID,

            };

            _serviceService.TUpdate(service);
            return Ok();
        }
    }
}
