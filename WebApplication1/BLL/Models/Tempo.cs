using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.BLL.Models
{
    public class main
    {
        [JsonProperty("main")]
        public Tempo tempo { get; set; }
    }

    public class Tempo
    {
        [JsonProperty("temp")]
        public string tempAtual { get; set; }
        [JsonProperty("temp_min")]
        public string tempMin { get; set; }
        [JsonProperty("temp_max")]
        public string tempMax { get; set; }

        public Tempo()
        {
        }

        public Tempo(string tempAtual, string tempMin, string tempMax)
        {
            this.tempAtual = tempAtual;
            this.tempMin = tempMin;
            this.tempMax = tempMax;
        }
    }

}
