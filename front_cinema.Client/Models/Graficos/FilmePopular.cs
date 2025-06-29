using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace front_cinema.Client.Models.Graficos
{
    public class FilmePopular
    {
        [JsonPropertyName("_nomeGraf")]
        public string NomeGraf { get; set; }
        [JsonPropertyName("_quantidadeVendidaGraf")]
        public int QuantidadeVendidaGraf { get; set; }
    }
}