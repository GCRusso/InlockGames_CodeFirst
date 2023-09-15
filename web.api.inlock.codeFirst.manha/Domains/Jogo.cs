using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.api.inlock.codeFirst.manha.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome do jogo é obrigatório!")]
        public string? Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A Descrição do jogo é obrigatória!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A Data do jogo é obrigatória!")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "Decimal(4,2)")] //o número que vem a esquerda é o total de casas se for acima de 1000,00 Seria "Decimal(6,2)"
        [Required(ErrorMessage = "O Preço do jogo é obrigatório!")]
        public decimal? Preco { get; set; }



        //Referência da chave estrangeira (Tabela de Estúdio)
        [Required(ErrorMessage = "Informe o estúdio que produziu o jogo!")]
        public Guid IdEstudio { get; set; }


        [ForeignKey("IdEstudio")]
        public Estudio? Estudio { get; set; }
    }
}
