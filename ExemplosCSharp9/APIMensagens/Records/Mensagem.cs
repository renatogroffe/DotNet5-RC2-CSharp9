using System.ComponentModel.DataAnnotations;

namespace APIMensagens.Records
{
    public record Mensagem
    {
        [Required]
        public string Nome { get; init; }
        
        [Range(12, 150)]
        public int Idade { get; init; }
        
        [Required]
        public string Descricao { get; init; }
    }

}