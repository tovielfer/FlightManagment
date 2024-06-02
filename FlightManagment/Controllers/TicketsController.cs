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
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;
        public TicketsController(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }
        // GET: api/<TicketsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _ticketService.Get();
            var listDto = _mapper.Map<IEnumerable<TicketDTO>>(list);
            return Ok(listDto);
        }

        // GET api/<TicketsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int passId)
        {
            var list = _ticketService.Get(passId);
            if (list == null)
                return NotFound();
            return Ok(_mapper.Map<IEnumerable<TicketDTO>>(list));
        }

        // POST api/<TicketsController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] TicketPostModel ticket)
        {
            Ticket t = _mapper.Map<Ticket>(ticket);
            var newTicket = await _ticketService.PostAsync(t);
            return Ok(_mapper.Map<TicketDTO>(newTicket));
        }

        // PUT api/<TicketsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync([FromBody] TicketPostModel ticket)
        {
            Ticket t = _mapper.Map<Ticket>(ticket);
            var newTicket = await _ticketService.PutAsync(t.PassengerId,t.FlightId,t.Place);
            if (newTicket == null)
                return NotFound();
            return Ok(_mapper.Map<TicketDTO>(newTicket));
        }
    }
}
