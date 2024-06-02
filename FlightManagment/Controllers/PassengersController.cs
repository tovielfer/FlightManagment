using AutoMapper;
using FlightManagment.Entities;
using FlightManagment.Models;
using Flights.Core.DTOs;
using Flights.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private readonly IPassengerService _passengerService;
        private readonly IMapper _mapper;
        public PassengersController(IPassengerService passengerService,IMapper mapper)
        {
            _passengerService = passengerService;
            _mapper = mapper;
        }
        // GET: api/<PassengersController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _passengerService.Get();
            var listDto=_mapper.Map<IEnumerable<PassengerDTO>>(list);
            return Ok(listDto);
        }

        // GET api/<PassengersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var p = _passengerService.Get(id);
            if(p == null)
                return NotFound();
            return Ok(_mapper.Map<PassengerDTO>(p));
        }

        // POST api/<PassengersController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] PassengerPostModel value)
        {
            Passenger p = _mapper.Map<Passenger>(value);
            var newPass=await _passengerService.PostAsync(p);
            return Ok(newPass);
        }

        // PUT api/<PassengersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] PassengerPostModel value)
        {
            Passenger p = _mapper.Map<Passenger>(value);
            var newPass = await _passengerService.PutAsync(id,p);
            if(newPass == null)
                return NotFound();
            return Ok(newPass);
        }
    }
}
