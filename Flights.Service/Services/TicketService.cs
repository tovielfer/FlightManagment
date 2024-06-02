using FlightManagment.Entities;
using Flights.Core.Services;
using Flights.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Service.Services
{
    public class TicketService:ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public IEnumerable<Ticket> Get()
        {
            return _ticketRepository.Get();
        }
        public IEnumerable<Ticket> Get(int passId)
        {
            return _ticketRepository.Get(passId);
        }
        public async Task<Ticket> PostAsync(Ticket t)
        {
            return await _ticketRepository.PostAsync(t);
        }
        public async Task<Ticket> PutAsync(int passId, int flightId, int place)
        {
            return await _ticketRepository.PutAsync(passId, flightId, place);
        }
    }
}
