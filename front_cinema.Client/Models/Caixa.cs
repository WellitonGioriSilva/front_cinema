
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class Caixa
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_valorIni")]
        public double ValorIni { get; set; }

        [JsonPropertyName("_valorFim")]
        public double ValorFim { get; set; }

        [JsonPropertyName("_totalEnt")]
        public double TotalEnt { get; set; }

        [JsonPropertyName("_totalSai")]
        public double TotalSai { get; set; }

        [JsonPropertyName("_dtIni")]
        public DateTime DtIni { get; set; }

        [JsonPropertyName("_dtFim")]
        public DateTime DtFim { get; set; }

        public Caixa() { }
    }
}