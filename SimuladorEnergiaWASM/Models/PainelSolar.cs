using System.ComponentModel.DataAnnotations;

namespace SimuladorEnergiaWASM.Models
{
    public class PainelSolar
    {
        public int Id { get; set; }
        [Range(1, 100000)]
        public int Potencia { get; set; } = 550;
        public double Eficiencia { get; set; } = 80;
        [Range(0, double.MaxValue)]
        public decimal Custo { get; set; } = 1500m;
        [Required]
        [Range(1, 24)]
        public int HorasSol { get; set; } = 5;
        public decimal Tarifa { get; set; } = 0.73m;
        public double CalculoKwh() => (Potencia * HorasSol * 30) / 1000.0;
    }
}
