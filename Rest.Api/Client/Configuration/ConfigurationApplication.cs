using Microsoft.Extensions.Configuration;

namespace Client.Configuration
{
    public static class ConfigurationApplication
    {
        public static IConfiguration AppSetting {get;}
        static ConfigurationApplication()=> AppSetting = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("AddressServiceApi.json").Build();
        
    }
}
