using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.BLL.Models
{
    public class Tempo
    {
        public string tempAtual { get; set; }
        public string tempMin { get; set; }
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
