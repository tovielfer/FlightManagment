namespace FlightManagment.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public List<Passenger> Passengers { get; set; }
        public int PlaneId { get; set; }
        public DateOnly Date { get; set; }
        public int PilotId { get; set; }
        public Pilot Pilot { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
