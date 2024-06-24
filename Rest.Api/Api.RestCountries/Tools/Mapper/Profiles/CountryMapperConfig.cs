using AutoMapper;
using Models.DTO;
using Models.Models;

namespace Api.RestCountries.Tools.Mapper.Profiles
{
    public class CountryMapperConfig: Profile
    {
        public CountryMapperConfig() 
        {
            CreateMap<Country, CountryDetailDTO>();
          
        }

    }
}
