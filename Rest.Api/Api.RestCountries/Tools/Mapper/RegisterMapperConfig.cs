
using Api.RestCountries.Tools.Mapper.Profiles;
using AutoMapper;

namespace Api.RestCountries.Tools.Mapper
{
    public class RegisterMapperConfig
    {
        public static IMapper Mapper { get; set; }

        public static void CreateMapper()
        {
            var mapperConfiguration = new MapperConfiguration(mapper =>
            {
                mapper.AddProfile<CountryMapperConfig>();
            });

            mapperConfiguration.AssertConfigurationIsValid();
            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}
