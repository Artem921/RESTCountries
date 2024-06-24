using Newtonsoft.Json;
using System.Text;
namespace Client.Services.Abstract
{
    public abstract class BaseClient : IDisposable
    {
        protected readonly HttpClient client;
        protected readonly string serviceAddress;

        protected BaseClient(string ServiceAddress)
        {
            serviceAddress = ServiceAddress;

            var handler = new HttpClientHandler();

            handler.AllowAutoRedirect = false;

            client = new HttpClient(handler)
            {

            };

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected async Task<T> GetAsync<T>(string url) where T : new()
        {
            try
            {
                var response =  await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    
                    return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(await response.Content.ReadAsByteArrayAsync()));
                }               
            }
            catch { Console.WriteLine("Произошла какая то ошибка или нет соединения с сервером!"); }

            finally { client.Dispose(); }

            return new T();

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed || !disposing) return;
            _disposed = true;
            client.Dispose();
        }
    }
}

