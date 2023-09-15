using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.api.inlock.codeFirst.manha.Domains
{
    [Table("Estudio")]
    public class Estudio
    {
        [Key]
        public Guid IdEstudio { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required (ErrorMessage = "O Nome do estudio é obrigatório")]
        public string? Nome { get; set; } 

        public List<Jogo>? jogos { get; set; }

    }
}
