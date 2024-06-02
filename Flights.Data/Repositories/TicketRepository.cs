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
    public class TicketRepository:ITicketRepository
    {
        private readonly DataContext _context;
        public TicketRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IEnumerable<Ticket> Get()
        {
            return _context.Tickets.Include(t=>t.Passenger).Include(t=>t.Flight);
        }
        public IEnumerable<Ticket> Get(int passId)
        {
            return _context.Tickets.Include(t=>t.Passenger).Include(t=>t.Flight).Where(t=>t.PassengerId==passId);
        }
        public async Task<Ticket> PostAsync(Ticket t)
        {
            _context.Tickets.AddAsync(t);
            await _context.SaveChangesAsync();
            return t;
        }
        public async Task<Ticket> PutAsync(int passId,int flightId, int place)
        {
            Ticket temp = _context.Tickets.First(t=>t.PassengerId==passId &&t.FlightId==flightId);
            if (temp != null)
            {
               temp.Place = place;

                await _context.SaveChangesAsync();
                return temp;
            }
            return null;
        }
    }
}

