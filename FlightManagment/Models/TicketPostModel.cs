using FlightManagment.Entities;

namespace FlightManagment.Models
{
    public class TicketPostModel
    {
        public int PassengerId { get; set; }
        public int FlightId { get; set; }
        public int Place { get; set; }
    }
}
