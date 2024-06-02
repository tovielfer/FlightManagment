
namespace FlightManagment.Models
{
    public class FlightPostModel
    {
        public DateOnly Date { get; set; }
        public int PilotId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
