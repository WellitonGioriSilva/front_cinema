
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class FormaPagamento
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_nome")]
        public string Nome { get; set; }

        public FormaPagamento() { }
    }
}