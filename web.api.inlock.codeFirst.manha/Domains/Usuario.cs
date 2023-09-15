using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.api.inlock.codeFirst.manha.Domains
{
    [Table("Usuario")]

    //Deixa o EMAIL UNIQUE no banco de dados 
    [Index(nameof(Email), IsUnique=true)]
    public class Usuario
    {
        [Key]

        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Email é obrigatório!")]
        public string? Email { get; set; }


        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A Senha é obrigatória!")]
        [StringLength(60, MinimumLength =6, ErrorMessage = "Senha é de 6 a 200 caracteres")]
        public string? Senha { get; set; }


        //Referência da chave estrangeira (Tabelas TiposUsuario)
        [Required(ErrorMessage = "Tipo do usuário obrigatório!")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario? TipoUsuario { get; set; }
    }
}
