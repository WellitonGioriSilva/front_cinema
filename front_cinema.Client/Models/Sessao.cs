
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class Sessao
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_valor")]
        public double Valor { get; set; }

        [JsonPropertyName("_meia")]
        public bool Meia { get; set; }

        [JsonPropertyName("_data")]
        public DateTime Data { get; set; }
        
        [JsonPropertyName("_hora")]
        public TimeSpan Hora { get; set; }

        [JsonPropertyName("_filme")]
        public Filme Filme { get; set; }

        public Sessao() { }
    }
}