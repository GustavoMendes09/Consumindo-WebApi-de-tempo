using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.DAL.Interfaces;

namespace WebApplication1.DAL.Repositorios
{
    public class TemperaturaRepositorio : ITemperaturaRepositorio
    {
        HttpClient client = new HttpClient();

        public async Task<dynamic> PegarTemperatura(string url)
        {
            var response = await client.GetStringAsync(url);

            return response;

        }
    }
}
