using Microsoft.EntityFrameworkCore;
using web.api.inlock.codeFirst.manha.Domains;

namespace web.api.inlock.codeFirst.manha.Contexts
{
    //Criar uma classe NORMAL
    public class InlockContext : DbContext
    {
        //Define as entidades do Banco de Dados
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


        /// <summary>
        /// Define as opções de construção do banco(StringConexão)
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //String de conexão, muda um pouco da outra StringConexao que utilizamos no DbFirst
            optionsBuilder.UseSqlServer("Server=NOTE17-S15; Database=inlock_games_codeFirst_manha; User id=sa; pwd=Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
