using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace front_cinema.Client.Models.Graficos
{
    public class FaturamentoMensal
    {
        [JsonPropertyName("_anoGraf")]
        public string Ano { get; set; }
        [JsonPropertyName("_mesGraf")]
        public string Mes { get; set; }
        [JsonPropertyName("_totalEntradaMensalGraf")]
        public double TotalEntradaMensal { get; set; }
        [JsonPropertyName("_totalSaidaMensalGraf")]
        public double TotalSaidaMensal { get; set; }
        [JsonPropertyName("_totalLucroMensalGraf")]
        public double TotalLucroMensal { get; set; }
    }
}