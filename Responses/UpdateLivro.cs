namespace gerenciador_livraria.Responses
{
    public class UpdateLivro
    {

        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public string? Genero { get; set; } = string.Empty;

        public string? Preco { get; set; } = string.Empty;

        public int? QtdEstoque { get; set; }


    }
}
