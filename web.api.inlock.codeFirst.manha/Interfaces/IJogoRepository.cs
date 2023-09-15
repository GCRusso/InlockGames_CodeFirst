using web.api.inlock.codeFirst.manha.Domains;

namespace web.api.inlock.codeFirst.manha.Interfaces
{
    public interface IJogoRepository
    {
        List<Jogo> Listar();
        Jogo BuscarPorId(Guid id);
        void Cadastrar(Jogo jogo);
        void Atualizar(Guid id, Jogo jogo);
        void Deletar(Guid id);
    }
}
