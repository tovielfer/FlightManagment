using FlightManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Core.Repositories
{
    public interface IFlightRepository
    {
        public IEnumerable<Flight> Get();
        public Flight Get(int id);
        public Task<Flight> PostAsync(Flight f);
        public Task<Flight> PutAsync(int id, Flight f);
    }
}
