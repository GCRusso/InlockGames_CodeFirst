using web.api.inlock.codeFirst.manha.Contexts;
using web.api.inlock.codeFirst.manha.Domains;
using web.api.inlock.codeFirst.manha.Interfaces;
using web.api.inlock.codeFirst.manha.Utils;

namespace web.api.inlock.codeFirst.manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Variável privada e somente leitura para armazenar os dados do contexto
        /// </summary>
        private readonly InlockContext ctx;

        /// <summary>
        /// Construtor do repositório
        /// Toda vez que o repositório for instanciado
        /// ele terá acesso aosdados fornecidos pelo contexto
        /// </summary>
        public UsuarioRepository()
        {
            ctx = new InlockContext();
        }
        public Usuario BuscarUsuario(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = ctx.Usuario.FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere == true)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Add(usuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
