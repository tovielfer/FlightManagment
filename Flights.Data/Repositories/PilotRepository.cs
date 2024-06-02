using FlightManagment.Entities;
using Flights.Data;
using Microsoft.EntityFrameworkCore;
using Flights.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Data.Repositories
{
    public class PilotRepository: IPilotRepository
    {
        private readonly DataContext _context;
        public PilotRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IEnumerable<Pilot> Get()
        {
            return _context.Pilots.Include(p=>p.Flights);
        }
        public Pilot Get(int id)
        {
            return _context.Pilots.Include(p=>p.Flights).First(p => p.Id == id);
        }
        public async Task<Pilot> PostAsync(Pilot p)
        {
            _context.Pilots.AddAsync(p);
            await _context.SaveChangesAsync();
            return p;
        }
        public async Task<Pilot> PutAsync(int id, Pilot p)
        {
            Pilot temp = _context.Pilots.Find(id);
            if (temp != null)
            {
                temp.Identity=p.Identity;
                temp.Name=p.Name;
                temp.Flights=p.Flights; 

                await _context.SaveChangesAsync();
                return temp;
            }
            return null;
        }
    }
}

