using gerenciador_livraria.Responses;

namespace gerenciador_livraria.Services
{
    public class LivrariaService
    {
        public List<Livro> GetAll()
        {

            var livros = new List<Livro>
            {
                new Livro
                {
                    Id = 1,
                    Titulo = "O Senhor dos Anéis",
                    Autor = "J.R.R. Tolkien",
                    Genero = "Fantasia",
                    Preco = "R$ 54,90",
                    QtdEstoque = 10
                },
                new Livro
                {
                    Id = 2,
                    Titulo = "Harry Potter e a Pedra Filosofal",
                    Autor = "J.K. Rowling",
                    Genero = "Fantasia",
                    Preco = "R$ 39,90",
                    QtdEstoque = 15
                },
                new Livro
                {
                    Id = 3,
                    Titulo = "A Culpa é das Estrelas",
                    Autor = "John Green",
                    Genero = "Romance",
                    Preco = "R$ 29,90",
                    QtdEstoque = 8
                }
            };

            return livros;
   

        }

        public void Create(Livro createBody)
        {
            // regra de negocio para criar um livro no banco de dados
        }


        public void Update(int id, UpdateLivro updateBody)
        {
            // regra de negocio para atualizar um livro no banco de dados
        }


        public void Delete(int id)
        {
            // regra de negocio para remover um livro no banco de dados
        }

    }
}
