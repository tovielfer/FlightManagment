using FlightManagment.Entities;
using Flights.Core.Repositories;
using Flights.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Service.Services
{
    public class FlightService:IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        public FlightService(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }
        public IEnumerable<Flight> Get()
        {
            return _flightRepository.Get();
        }
        public Flight Get(int id)
        {
            return _flightRepository.Get(id);
        }
        public async Task<Flight> PostAsync(Flight f)
        {
            return await _flightRepository.PostAsync(f);
        }
        public async Task<Flight> PutAsync(int id, Flight f)
        {
            return await _flightRepository.PutAsync(id, f);
        }
    }
}
