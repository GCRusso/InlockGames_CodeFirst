using web.api.inlock.codeFirst.manha.Domains;

namespace web.api.inlock.codeFirst.manha.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(string email, string senha);
        void Cadastrar(Usuario usuario);
   
    }
}
