
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class Ingresso
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_meia")]
        public bool Meia { get; set; } = false;

        [JsonPropertyName("_sessao")]
        public Sessao Sessao { get; set; }

        [JsonPropertyName("_caixa")]
        public Venda Venda { get; set; }

        [JsonPropertyName("_formaPagamento")]
        public Assento Assento { get; set; }


        public Ingresso() { }
    }
}