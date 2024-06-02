using Flights.Core.Services;
using Flights.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagment.Entities;

namespace Flights.Service.Services
{
    public class PassengerService:IPassengerService
    {
        private readonly IPassengerRepository _passengerRepository;
        public PassengerService(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }
        public IEnumerable<Passenger> Get()
        {
            return _passengerRepository.Get();
        }
        public Passenger Get(int id)
        {
            return _passengerRepository.Get(id);
        }
        public async Task<Passenger> PostAsync(Passenger p)
        {
            return await _passengerRepository.PostAsync(p);
        }
        public async Task<Passenger> PutAsync(int id, Passenger p)
        {
            return await _passengerRepository.PutAsync(id, p);
        }
    }
}
