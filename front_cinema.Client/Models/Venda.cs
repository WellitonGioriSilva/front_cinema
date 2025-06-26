
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class Venda
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_data")]
        public DateTime Data { get; set; } = DateTime.Today;

        [JsonPropertyName("_subTotal")]
        public double SubTotal { get; set; }

        [JsonPropertyName("_desconto")]
        public double Desconto { get; set; }

        [JsonPropertyName("_total")]
        public double Total { get; set; }

        [JsonPropertyName("_cliente")]
        public Cliente Cliente { get; set; }

        [JsonPropertyName("_caixa")]
        public Caixa Caixa { get; set; }

        [JsonPropertyName("_formaPagamento")]
        public FormaPagamento FormaPagamento { get; set; }
        
        [JsonPropertyName("_clienteId")]
        public int ClienteId { get; set; }

        [JsonPropertyName("_caixaId")]
        public int CaixaId { get; set; }

        [JsonPropertyName("_formaPagamentoId")]
        public int FormaPagamentoId { get; set; }


        public Venda() { }
    }
}