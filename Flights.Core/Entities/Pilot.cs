namespace FlightManagment.Entities
{
    public class Pilot
    {
        public int Id { get; set; }
         public string Identity { get; set; }
        public string Name { get; set; }
        public List<Flight> Flights { get; set; }
    }
}
