using AutoMapper;
using FlightManagment.Entities;
using FlightManagment.Models;

namespace FlightManagment.Mapping
{
    public class PostModelMappingProfile:Profile
    {
        public PostModelMappingProfile()
        {
            CreateMap<Flight, FlightPostModel>().ReverseMap();
            CreateMap<Passenger, PassengerPostModel>().ReverseMap();
            CreateMap<Pilot, PilotPostModel>().ReverseMap();
            CreateMap<Ticket, TicketPostModel>().ReverseMap();
        }
    }
}
