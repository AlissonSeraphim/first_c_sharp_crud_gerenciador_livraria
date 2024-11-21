namespace gerenciador_livraria.Responses
{
    public class Livro
    {
            
        public  int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public string Genero { get; set; } = string.Empty;

        public string Preco { get; set; } = string.Empty;

        public int QtdEstoque { get; set; }

    }
}
