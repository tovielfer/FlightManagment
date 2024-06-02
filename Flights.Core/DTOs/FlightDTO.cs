using FlightManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Core.DTOs
{
    public class FlightDTO
    {
        public int Id { get; set; }
        public List<PassengerDTO> Passengers { get; set; }
        public int PlaneId { get; set; }
        public DateOnly Date { get; set; }
        public int PilotId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
