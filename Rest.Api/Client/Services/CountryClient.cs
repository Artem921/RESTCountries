using Client.Configuration;
using Client.Services.Abstract;
using Client.Services.Interfaces;
using Models.Models;

namespace Client.Service
{
    public class CountryClient : BaseClient, ICountrieyService
    {
        public CountryClient() : base(ConfigurationApplication.AppSetting["ResCountries:Countries"]) { }


        public async Task <IEnumerable<Country>> GetAllCounties()
        {
            var countries = await GetAsync<List<Country>>($"{serviceAddress}/all");

            return countries;
        }

        public async Task<List<Country>> GetCountryByName(string name)
        {
            var country = await GetAsync<List<Country>>($"{serviceAddress}/name/{name}");

            return country;
        }

        public async Task<List<Country>> GetCountryByFullName(string name,bool fullText)
        {
            var country = await GetAsync<List<Country>>($"{serviceAddress}/name/{name}?{fullText}");

            return country;
        }
    }
}
