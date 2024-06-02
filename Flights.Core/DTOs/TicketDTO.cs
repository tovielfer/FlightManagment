using FlightManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Core.DTOs
{
    public class TicketDTO
    {
        public PassengerDTO Passenger { get; set; }
        public int PassengerId { get; set; }
        public FlightDTO Flight { get; set; }
        public int FlightId { get; set; }
        public int Place { get; set; }
    }
}
