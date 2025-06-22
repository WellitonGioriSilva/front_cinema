
using System.Text.Json.Serialization;
namespace front_cinema.Client.Models
{
    public class Funcionario
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_nome")]
        public string Nome { get; set; }

        [JsonPropertyName("_cpf")]
        public string Cpf { get; set; }

        [JsonPropertyName("_dtNascimento")]
        public DateTime DtNascimento { get; set; }

        [JsonPropertyName("_rg")]
        public string Rg { get; set; }

        [JsonPropertyName("_salario")]
        public double Salario { get; set; }

        public Funcionario() { }
    }
}