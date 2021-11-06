namespace Perfume.Dtos
{
    public class PerfumeReadDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        //Não quero exibir isso para o client (exemplo)
        //public double Valor { get; set; }
        public string Estacao { get; set; }
        public string Projecao { get; set; }
        public string Longevidade { get; set; }
    }
}