namespace FlightManagment.Entities
{
    public class Ticket
    {
        public Passenger Passenger { get; set; }
        public int PassengerId { get; set; }
        public Flight Flight { get; set; }
        public int FlightId { get; set; }
        public int Place { get; set; }
    }
}
