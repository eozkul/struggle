using AutoMapper;
using Struggle.Data.Requests.Contracts;
using Struggle.Entities;

namespace Struggle.Mapper
{
    internal class MainProfile:Profile
    {
        public MainProfile()
        {
            CreateMap<BoatDto, Boat>();
            CreateMap< Boat, BoatDto>();
            CreateMap< Boat, Boat>();
            CreateMap<BusDto, Bus>();
            CreateMap<Bus, BusDto>();
            CreateMap<Bus, Bus>();
            CreateMap<Car, CarDto>();
            CreateMap<Car, Car>();
            CreateMap<Car, UpdateCarDto>();
            CreateMap<CarDto, Car>();
            CreateMap<UpdateCarDto, Car>();
        }
    }
}
