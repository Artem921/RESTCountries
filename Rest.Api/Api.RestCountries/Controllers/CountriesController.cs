using AutoMapper;
using Client.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;

namespace Api.RestCountries.Controllers
{
    [Route("api/countries")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountrieyService countryService;

        private readonly IMapper mapper;

        public CountriesController(ICountrieyService CountryService, IMapper mapper)
        {
            this.countryService = CountryService;
            this.mapper = mapper;
           
        }
        /// <summary>
        /// Возвращает список стран
        /// </summary>
        /// <returns></returns>

        [HttpGet("GetCountries")]
        public async Task<IEnumerable<CountryDTO>> GetAllCountries()
        {
            var countries = await countryService.GetAllCounties();

            var selectedCountries = from country in countries
                                    orderby country.Name.Official
                                    select new CountryDTO { Name = country.Name.Official, Capital = country.Capital };

            return selectedCountries;
        }

        /// <summary>
        /// Возвращает страну по именни
        /// </summary>
        /// <param name="name">Название страны</param> 
        /// <returns></returns>
        [HttpGet("GetCountryByName/{name}")]
        public async Task<CountryDetailDTO> GetCountryByName(string name)
        {
            var country = await countryService.GetCountryByName(name);

            var countryDTO = mapper.Map<CountryDetailDTO>(country.FirstOrDefault());

            return countryDTO;
        }

        /// <summary>
        /// Возвращает страну по полному именни
        /// </summary>
        /// /// <param name="name">Название страны</param> 
        /// <returns></returns>
        [HttpGet("GetCountryByFullName/{name}")]
        public async Task<CountryDetailDTO> GetCountryByFullName(string name, bool fullText)
        {
            var country = await countryService.GetCountryByFullName(name,fullText);

            var countryDetailDTO = mapper.Map<CountryDetailDTO>(country.FirstOrDefault());

            return countryDetailDTO;
        }
    }
}
