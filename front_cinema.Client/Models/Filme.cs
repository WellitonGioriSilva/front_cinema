
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class Filme
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_nome")]
        public string Nome { get; set; }

        [JsonPropertyName("_sinopse")]
        public string Sinopse { get; set; }

        [JsonPropertyName("_duracao")]
        public TimeSpan Duracao { get; set; }
        
        [JsonPropertyName("_categoria")]
        public CategoriaFilme Categoria { get; set; }

        public Filme() { }
    }
}