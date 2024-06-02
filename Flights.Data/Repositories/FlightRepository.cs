using FlightManagment.Entities;
using Flights.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Flights.Data.Repositories
{
    public class FlightRepository:IFlightRepository
    {
        private readonly DataContext _context;
        public FlightRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IEnumerable<Flight> Get()
        {
            var l= _context.Flights.Include(f=>f.Passengers);
            return l;
        }
        public Flight Get(int id)
        {
            return _context.Flights.Include(f=>f.Passengers).First(f => f.Id == id);
        }
        public async Task<Flight> PostAsync(Flight f)
        {
            _context.Flights.AddAsync(f);
            await _context.SaveChangesAsync();
            return f;
        }
        public async Task<Flight> PutAsync(int id,Flight f)
        {
            Flight temp = _context.Flights.Find(id);
            if(temp != null)
            {
                temp.Pilot=f.Pilot;
                temp.Passengers=f.Passengers;
                temp.Destination=f.Destination;
                temp.Date=f.Date;
                temp.Source=f.Source;
                temp.PlaneId=f.PlaneId;

                await _context.SaveChangesAsync();
                return temp;
            }
            return null;
        }
    }
}
