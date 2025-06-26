
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class VendaRequest
    {
        [JsonPropertyName("_venda")]
        public Venda Venda { get; set; }

        [JsonPropertyName("_assentos")]
        public List<Assento> Assentos { get; set; }

        [JsonPropertyName("_sessaoId")]
        public int SessaoId { get; set; }

        [JsonPropertyName("_quantidadeMeiaEntrada")]
        public int QuantidadeMeiaEntrada { get; set; }

        public VendaRequest() { }
    }
}