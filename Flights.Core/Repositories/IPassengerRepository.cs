using FlightManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Core.Repositories
{
    public interface IPassengerRepository
    {
        public IEnumerable<Passenger> Get();
        public Passenger Get(int id);
        public Task<Passenger> PostAsync(Passenger p);
        public Task<Passenger> PutAsync(int id, Passenger p);
    }
}
