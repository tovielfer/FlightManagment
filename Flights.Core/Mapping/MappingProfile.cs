using AutoMapper;
using FlightManagment.Entities;
using Flights.Core.DTOs;

namespace Flights.Core.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Flight, FlightDTO>().ReverseMap();
            CreateMap<Passenger, PassengerDTO>().ReverseMap();
            CreateMap<Pilot, PilotDTO>().ReverseMap();
            CreateMap<Ticket, TicketDTO>().ReverseMap();
        }
    }
}
