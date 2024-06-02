namespace FlightManagment.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
