
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class Assento
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_numero")]
        public int Numero { get; set; }

        [JsonPropertyName("_sala")]
        public Sala Sala { get; set; }
        public bool Selecionado{ get; set; }
        public bool Ocupado{ get; set; }

        public Assento() { }
    }
}