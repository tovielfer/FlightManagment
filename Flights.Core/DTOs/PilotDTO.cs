using FlightManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Core.DTOs
{
    public class PilotDTO
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string Name { get; set; }
        public List<FlightDTO> Flights { get; set; }
    }
}
