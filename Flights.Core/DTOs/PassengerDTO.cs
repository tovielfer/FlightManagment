using FlightManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Core.DTOs
{
    public class PassengerDTO
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string Name { get; set; }
        public List<TicketDTO> Tickets { get; set; }
    }
}
