using System.Threading.Tasks;

namespace WebApplication1.DAL.Interfaces
{
    public interface ITemperaturaRepositorio
    {
        Task<dynamic> PegarTemperatura(string url);
    }
}
