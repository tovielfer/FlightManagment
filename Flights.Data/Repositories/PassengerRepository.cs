using FlightManagment.Entities;
using Flights.Core.Repositories;
using Flights.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Data.Repositories
{
    public class PassengerRepository:IPassengerRepository
    {
        private readonly DataContext _context;
        public PassengerRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IEnumerable<Passenger> Get()
        {
            return _context.Passengers.Include(p=>p.Tickets);
        }
        public Passenger Get(int id)
        {
            return _context.Passengers.Include(p=>p.Tickets).First(p => p.Id == id);
        }
        public async Task<Passenger> PostAsync(Passenger p)
        {
            _context.Passengers.AddAsync(p);
            await _context.SaveChangesAsync();
            return p;
        }
        public async Task<Passenger> PutAsync(int id, Passenger p)
        {
            Passenger temp = _context.Passengers.Find(id);
            if (temp != null)
            {
                temp.Identity = p.Identity;
                temp.Name = p.Name;
                temp.Tickets = p.Tickets;

                await _context.SaveChangesAsync();
                return temp;
            }
            return null;
        }
    }
}

