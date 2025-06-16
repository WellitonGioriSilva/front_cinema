using System.Text.Json.Serialization;

namespace front_cinema.Client.Models
{
    public class CategoriaFilme
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("_nome")]
        public string Nome { get; set; }

        public CategoriaFilme(){

        }

        public CategoriaFilme(int id, string nome){
            Id = id;
            Nome = nome;
        }
    }
}