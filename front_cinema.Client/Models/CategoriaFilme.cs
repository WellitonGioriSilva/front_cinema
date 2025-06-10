
namespace front_cinema.Client.Models
{
    public class CategoriaFilme
    {
        private int _id;
        private string _nome;

        public CategoriaFilme(int id, string nome)
        {
            _id = id;
            SetNome(nome);
        }
        public int GetId()
        {
            return _id;
        }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }
    }
}