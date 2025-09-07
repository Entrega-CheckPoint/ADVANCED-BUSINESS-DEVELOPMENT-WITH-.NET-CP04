using Checkpoint.Model;
using MongoDB.Driver;

namespace Checkpoint.Services
{
    public class LivroService
    {
        private readonly IMongoCollection<Livro> _colecaoLivro;

        public LivroService(IMongoCollection<Livro> colecaoLivro)
        {
            _colecaoLivro = colecaoLivro;
        }

        public async Task<List<Livro>> ObterTodosAsync() => await _colecaoLivro.Find(_ => true).ToListAsync();

        public async Task<Livro?> ObterPorIdAsync(string id) => await _colecaoLivro.Find(a => a.Id == id).FirstOrDefaultAsync();

        public async Task<bool> RemoverAsync(string id)
        {
            var resultado = await _colecaoLivro.DeleteOneAsync(a => a.Id == id);
            return resultado.DeletedCount > 0;
        }

        public async Task<Livro> CriarAsync(Livro livro)
        {
            await _colecaoLivro.InsertOneAsync(livro);
            return livro;
        }

        public async Task<bool> AtualizarAsync(string id, Livro livroAtualizado)
        {
            var resultado = await _colecaoLivro.ReplaceOneAsync(a => a.Id == id, livroAtualizado);
            return resultado.MatchedCount > 0;
        }
    }
}
