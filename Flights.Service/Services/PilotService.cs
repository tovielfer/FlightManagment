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
    public class PilotService:IPilotService
    {
        private readonly IPilotRepository _pilotRepository;
        public PilotService(IPilotRepository pilotRepository)
        {
            _pilotRepository = pilotRepository;
        }
        public IEnumerable<Pilot> Get()
        {
            return _pilotRepository.Get();
        }
        public Pilot Get(int id)
        {
            return _pilotRepository.Get(id);
        }
        public async Task<Pilot> PostAsync(Pilot p)
        {
            return await _pilotRepository.PostAsync(p);
        }
        public async Task<Pilot> PutAsync(int id, Pilot p)
        {
            return await _pilotRepository.PutAsync(id, p);
        }
    }
}
