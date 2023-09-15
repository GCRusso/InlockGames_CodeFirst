using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.api.inlock.codeFirst.manha.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Tipo do usuário é obrigatório!")]
        public string? Titulo { get; set; }
    }
}
