using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.TeamDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.Consume.Models;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        [HttpGet]
        public IActionResult TeamList()
        {
            var values= _teamService.TGetList();
            return Ok(values);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTeam(int id) 
        {
            var values= _teamService.TGetByID(id);
            _teamService.TDelete(values);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddTeam(AddTeamDto p)
        {
            Team team = new Team()
            {
                NameSurname = p.NameSurname,
                Facebook=p.Facebook,
                ImageURL=p.ImageURL,
                Linkedin=p.Linkedin,
                Title = p.Title,
                Twitter=p.Twitter

            };
            _teamService.TInsert(team);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTeam(UpdateTeamDto p)
        {
            Team team = new Team()
            {
                TeamID = p.TeamID,
                NameSurname = p.NameSurname,
                Facebook = p.Facebook,
                Twitter = p.Twitter,
                ImageURL = p.ImageURL,
                Linkedin = p.Linkedin,
                Title = p.Title
            };
            _teamService.TUpdate(team);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTeam(int id)
        {
            var values= _teamService.TGetByID(id);
            return Ok(values);
        }
    }
}
