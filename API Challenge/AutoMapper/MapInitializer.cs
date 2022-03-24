using API_Challenge.Models;
using API_Challenge.Models.DTOs;
using AutoMapper;

namespace API_Challenge.AutoMapper
{
    public class MapInitializer : Profile
    {
        public MapInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<CountryDetail, CountryDetailDTO>().ReverseMap();
        }
    }
}
