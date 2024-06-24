using Models.Models;

namespace Client.Services.Interfaces
{
    public interface ICountrieyService
    {
        public Task<IEnumerable<Country>> GetAllCounties();
        public Task<List<Country>> GetCountryByName(string name);
        public Task<List<Country>> GetCountryByFullName(string name,bool fullText);
    }
}
