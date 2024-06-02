using FlightManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Core.Services
{
    public interface ITicketService
    {
        public IEnumerable<Ticket> Get();
        public IEnumerable<Ticket> Get(int passId);
        public Task<Ticket> PostAsync(Ticket t);
        public Task<Ticket> PutAsync(int passId, int flightId, int place);
    }
}
