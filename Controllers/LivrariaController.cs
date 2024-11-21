using gerenciador_livraria.Responses;
using gerenciador_livraria.Services;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_livraria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivrariaController : ControllerBase
    {
        private LivrariaService serviceLivros = new LivrariaService();


        [HttpGet]
        [ProducesResponseType(typeof (List<Livro>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult LivrosGetAll()
        {
            try
            {

            var response = serviceLivros.GetAll();


            return Ok(response);
            } 
            catch (Exception error)
            {
                return BadRequest(new { Error = error.Message});
            }
        }


        [HttpPost]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult LivroCreate([FromBody] Livro createBody)
        {
            try
            {

                serviceLivros.Create(createBody);

                return Created();

            }
            catch (Exception error)
            {
                return BadRequest(new { Error = error.Message });
            }

        }


        [HttpPut("/update/{id}")]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult LivroUpdate([FromRoute] int id, [FromBody] UpdateLivro createBody)
        {
            try
            {

                serviceLivros.Update(id, createBody);

                return NoContent();

            }
            catch (Exception error)
            {
                return BadRequest(new { Error = error.Message });
            }

        }



        [HttpDelete("/delete/livro/{id}")]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult LivroDelete([FromRoute] int id)
        {
            try
            {

                serviceLivros.Delete(id);

                return NoContent();

            }
            catch (Exception error)
            {
                return BadRequest(new { Error = error.Message });
            }

        }


    }
}
