
namespace front_cinema.Client.Models
{
    public class Filme
    {
        private int _id;
        private string _nome;
        private string _sinopse;
        private TimeSpan _duracao;
        private CategoriaFilme _categoriaFilme;

        public Filme(int id, string nome/*, string sinopse, TimeSpan duracao, CategoriaFilme categoriaFilme*/)
        {
            _id = id;
            _nome = nome;
        }
        public int GetId()
        {
            return _id;
        }
        public string GetNome()
        {
            return _nome;
        }
        public string GetSinopse()
        {
            return _sinopse;
        }
        public TimeSpan GetDuracao()
        {
            return _duracao;
        }
        public CategoriaFilme GetCategoriaFilme()
        {
            return _categoriaFilme;
        }
    }
}