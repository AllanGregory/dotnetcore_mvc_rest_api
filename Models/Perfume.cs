using System.ComponentModel.DataAnnotations;

namespace Perfume.Models
{
    public class PerfumeModel
    {
        [Key]
        public int Id { get; set; }

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