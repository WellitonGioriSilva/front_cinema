
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class Sala
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_numero")]
        public int Numero { get; set; }

        public Sala() { }
    }
}