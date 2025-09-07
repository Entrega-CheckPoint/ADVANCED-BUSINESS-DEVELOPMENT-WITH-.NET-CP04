using Checkpoint.Model;
using Checkpoint.Services;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroApiController : ControllerBase
    {

        private readonly LivroService _service;

        public LivroApiController(LivroService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<ActionResult<List<Livro>>> GetAll() =>
            await _service.ObterTodosAsync();

        [HttpGet("{id:length(24)}", Name = "ObterLivro")]
        public async Task<ActionResult<Livro>> GetById(string id)
        {
            var livro = await _service.ObterPorIdAsync(id);
            return livro is null ? NotFound() : livro;
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> Create([FromBody] Livro livro)
        {
            await _service.CriarAsync(livro);
            return CreatedAtRoute("ObterLivro", new { id = livro.Id }, livro);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Livro livroAtualizado)
        {
            var livroExistence = await _service.ObterPorIdAsync(id);
            if (livroExistence is null) { return NotFound(); }
            ;

            livroAtualizado.Id = livroExistence.Id;
            var atualizado = await _service.AtualizarAsync(id, livroAtualizado);
            return atualizado ? NoContent() : NotFound();


        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var livroExistence = await _service.ObterPorIdAsync(id);
            if (livroExistence is null) { return NotFound(); }
            ;

            var removido = await _service.RemoverAsync(id);
            return removido ? NoContent() : NotFound();
        }
    }
}
