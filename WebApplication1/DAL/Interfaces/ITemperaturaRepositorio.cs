using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication1.DAL.Interfaces
{
    public interface ITemperaturaRepositorio
    {
        Task<string> PegarTemperatura(string url);
    }
}
