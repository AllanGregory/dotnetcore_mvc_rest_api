using System.ComponentModel.DataAnnotations;

namespace Perfume.Dtos
{
    //Annotations como required nos campos do DTO
    //servem para que o erro no request do client
    //sejam amigáveis
    public class PerfumeUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string Nome { get; set; }

        [Required]
        public double Valor { get; set; }

        [Required]
        public string Estacao { get; set; }

        [Required]
        public string Projecao { get; set; }

        [Required]
        public string Longevidade { get; set; }
    }
}