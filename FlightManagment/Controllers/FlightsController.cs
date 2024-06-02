using AutoMapper;
using FlightManagment.Entities;
using FlightManagment.Models;
using Flights.Core.DTOs;
using Flights.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;
        private readonly IMapper _mapper;
        public FlightsController(IFlightService flightService, IMapper mapper)
        {
            _flightService = flightService;
            _mapper = mapper;
        }
        // GET: api/<FlightsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _flightService.Get();
            var listDto=_mapper.Map<IEnumerable<FlightDTO>>(list);
            return Ok(listDto);
        }

        // GET api/<FlightsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var f=_flightService.Get(id);
            if(f == null)
                return NotFound();
            return Ok(_mapper.Map<FlightDTO>(f));
        }

        // POST api/<FlightsController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] FlightPostModel flight)
        {
            Flight f=_mapper.Map<Flight>(flight);
            var newFlight=await _flightService.PostAsync(f);
            return Ok(_mapper.Map<FlightDTO>(newFlight));
        }

        // PUT api/<FlightsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] FlightPostModel flight)
        {
            Flight f = _mapper.Map<Flight>(flight);
            var newFlight = await _flightService.PutAsync(id,f);
            if (newFlight == null)
                return NotFound();
            return Ok(_mapper.Map<FlightDTO>(newFlight));
        }
    }
}
