using web.api.inlock.codeFirst.manha.Domains;

namespace web.api.inlock.codeFirst.manha.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        List<TiposUsuario> Listar();
        TiposUsuario BuscarPorId(Guid id);
        void Cadastrar(TiposUsuario tiposUsuario);
        void Atualizar(Guid id, TiposUsuario tiposUsuario);
        void Deletar(Guid id);
    }
}
