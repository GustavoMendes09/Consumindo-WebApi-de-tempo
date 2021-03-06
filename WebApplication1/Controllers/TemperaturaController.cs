using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.BLL.Models;
using WebApplication1.DAL.Interfaces;
using Newtonsoft.Json;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturaController : ControllerBase
    {
        private readonly ITemperaturaRepositorio _temperatura;

        public TemperaturaController(ITemperaturaRepositorio temperatura)
        {
            _temperatura = temperatura;
        }

        [HttpGet]
        public async Task<Tempo> Get()
        {
            try
            {
                string url = "https://api.openweathermap.org/data/2.5/weather?q=SAO%20PAULO&appid=c02891c1ba6b87156a106730fb724b77";
                var novaTemp = await _temperatura.PegarTemperatura(url);

                //Convertendo json anonimo
                #region
                var anonymousType = new
                    {
                    main = new
                    {
                        temp = "",
                        temp_min = "",
                        temp_max = ""
                    }
                };

                var tempo = JsonConvert.DeserializeAnonymousType(novaTemp, anonymousType)?.main;
                Tempo tempoSPAnonimo = new Tempo(tempo.temp, tempo.temp_min ,tempo.temp_max);
                #endregion


                //Convertendo json model
                #region
                var tempoSP = JsonConvert.DeserializeObject<main>(novaTemp);
                #endregion


                //Convertendo em tempo de execução
                #region
                dynamic dynamic = JsonConvert.DeserializeObject(novaTemp);

                var tempoDynamic = new Tempo
                {
                    tempAtual = dynamic.main.temp,
                    tempMin = dynamic.main.temp_min,
                    tempMax = dynamic.main.temp_max
                };
                #endregion

                return tempoDynamic;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
