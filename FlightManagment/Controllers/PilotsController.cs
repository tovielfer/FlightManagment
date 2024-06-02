using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Flights.Core.DTOs;
using FlightManagment.Models;
using Flights.Core.Services;
using FlightManagment.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotsController : ControllerBase
    {
        private readonly IPilotService _pilotService;
        private readonly IMapper _mapper;
        public PilotsController(IPilotService PilotService, IMapper mapper)
        {
            _pilotService = PilotService;
            _mapper = mapper;
        }
        // GET: api/<PilotsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _pilotService.Get();
            var listDto = _mapper.Map<IEnumerable<PilotDTO>>(list);
            return Ok(listDto);
        }

        // GET api/<PilotsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var f = _pilotService.Get(id);
            if (f == null)
                return NotFound();
            return Ok(_mapper.Map<PilotDTO>(f));
        }

        // POST api/<PilotsController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] PilotPostModel pilot)
        {
            Pilot f = _mapper.Map<Pilot>(pilot);
            var newPilot = await _pilotService.PostAsync(f);
            return Ok(_mapper.Map<PilotDTO>(newPilot));
        }

        // PUT api/<PilotsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] PilotPostModel pilot)
        {
            Pilot p = _mapper.Map<Pilot>(pilot);
            var newPilot = await _pilotService.PutAsync(id, p);
            if (newPilot == null)
                return NotFound();
            return Ok(_mapper.Map<PilotDTO>(newPilot));
        }
    }
}
